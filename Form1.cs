﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using ASRIP.classi;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Deployment.Application;

namespace ASRIP
{
    public partial class Form1 : Form
    {

        private BindingSource _bs;
        private string currentSate = "ANMIS1.ANM_VROS_D_VARIAZIONI";

        public Form1()
        {
            InitializeComponent();
            _bs = new BindingSource();
            this.Load += Form1_Load;
            btnCestino.Click += BtnCestino_Click;
            txtData.ValueChanged += TxtData_ValueChanged;
        }

        private void TxtData_ValueChanged(object sender, EventArgs e)
        {
            compilaGriglia();
        }

        private void BtnCestino_Click(object sender, EventArgs e)
        {
            if (btnCestino.Text == "Cestino")
            {
                btnCestino.Text = "Variazioni";
                currentSate = "ANMIS1.ANM_VROS_D_CESTINOVARIAZIONI";
                compilaGriglia();

            } else
            {
                btnCestino.Text = "Cestino";
                currentSate = "ANMIS1.ANM_VROS_D_VARIAZIONI";
                compilaGriglia();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!checkAut())
            {
                MessageBox.Show("Utente/Stazione non autorizzato all'uso del programma, contattare il gestiore della procedura.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                Application.Exit();

            }
            if (AMBITO != "admin")
            {
                btnCestino.Visible = false;
                btnVARIAZIONI_USERLIST.Visible = false;
            }


                txtData.Value = DateTime.Now;
            if (ApplicationDeployment.IsNetworkDeployed) this.Text += " - Ver." + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            
            compilaGriglia();


            txtRicerca.TextChanged += TxtRicerca_TextChanged;
            grigliaRichieste.RowsAdded += GrigliaRichieste_RowsAdded;
            grigliaRichieste.CellDoubleClick += GrigliaRichieste_CellDoubleClick;
        }

        private void GrigliaRichieste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string numprot = grigliaRichieste[12, e.RowIndex].Value.ToString();
            frmStato frm = new frmStato(numprot);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void GrigliaRichieste_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(e.RowIndex>-1)
            {

            }
        }

        private void TxtRicerca_TextChanged(object sender, EventArgs e)
        {
            string sql = @"VARIAZIONI_CODICE like'*{0}*'  or NOMINATIVO like '*{0}*' or VARIAZIONI_NOTE like '*{0}*' or VARIAZIONI_DEP_INTERESSATO like '*{0}*'";
            if(txtRicerca.Text.StartsWith("?"))
            {
                if(txtRicerca.Text.EndsWith("?"))
                {
                    try
                    {
                        _bs.Filter = txtRicerca.Text.Replace("?", "");
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Errore:" + ex.Message, "Errore QRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                return;
            }

            if (txtRicerca.Text.Length >= 2)
            {
                _bs.Filter = string.Format(sql, txtRicerca.Text);
            }
            else _bs.RemoveFilter();
        }

        private void compilaGriglia()
        {
            string sql = $@"SELECT 
                A.VARIAZIONI_CODICE_BDROP||'-'||A.VARIAZIONI_CODICE_ANM as VARIAZIONI_CODICE, 
                A.VARIAZIONI_DA_DATA, 
                A.VARIAZIONI_A_DATA, 
                A.VARIAZIONI_MATRICOLA ||' - '|| (select cognome||' '|| nome from paghenet.arcdipan where coddip =A.VARIAZIONI_MATRICOLA) as NOMINATIVO, 
                A.VARIAZIONI_DEP_INTERESSATO, 
                A.VARIAZIONI_LINEA, 
                A.VARIAZIONI_TRENO, 
                A.VARIAZIONI_MONTO, 
                A.VARIAZIONI_SCAMBIA_CON, 
                A.VARIAZIONI_FLAG_CONSENSO, 
                A.VARIAZIONI_UTENTE, 
                LOWER(A.VARIAZIONI_NOTE) as VARIAZIONI_NOTE, 
                A.VARIAZIONI_NUM_PROTOCOLLO";
            if(currentSate== "ANMIS1.ANM_VROS_D_VARIAZIONI") sql += "    ,A.DATA_COM_EVENTO";
            sql +=$@" FROM {currentSate} A where VARIAZIONI_CODICE_BDROP=6 and to_date('{txtData.Value.ToShortDateString()}','dd/mm/yyyy')
            between variazioni_da_data and variazioni_a_data and
            variazioni_matricola in (select Matricolaautista 
                                        from bdroptables.residenzeautisti 
                                        where residenza in ({LISTA_CC})
                                     and trunc(sysdate) between iniziovalidita and finevalidita )
            order by VARIAZIONI_DA_DATA, VARIAZIONI_MATRICOLA ";
            db db = new db();
            _bs.DataSource = db.getDataTable(sql);
            grigliaRichieste.DataSource = _bs;
            db.Dispose();
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            SaveFileDialog dg = new SaveFileDialog();
            dg.Filter="Valori separati da virgola (*.csv)|*.csv";
            dg.FileName = "StampaRichieste";
            dg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dg.AddExtension = true;
            dg.DefaultExt = "csv";
            dg.Title = "Stampa Dati";
            dg.ShowDialog(this);

            StreamWriter w = new StreamWriter(dg.FileName, false);
            string ret = "NOMINATIVO;Richiesta;Tratt.;\r\n";
            foreach (DataGridViewRow row in grigliaRichieste.Rows)
            {
                ret += row.Cells[3].Value.ToString() + ";" +
                    row.Cells[0].Value.ToString() + " (" +
                    row.Cells[11].Value.ToString() + ");" +
                    row.Cells[9].Value.ToString() + ";\r\n";


            }
            w.Write(ret);
            w.Flush();
            w.Close();
            Process.Start(dg.FileName);

        }

        string LISTA_CC;
        string AMBITO;

        private bool checkAut()
        {
            db db = new db();
            string sql = "select * from variazioni_userlist where utente_ad = '" + Environment.UserName.ToUpper() + "' and (stazione = '" + Environment.MachineName + "' or stazione='*')";
            OracleDataReader r = db.getReader(sql);
            if (!r.HasRows) { db.Dispose(); return false; }
            r.Read();
            LISTA_CC = r[4].ToString();
            AMBITO = r[2].ToString();
            db.Dispose();
            return true;

        }

        private void btnVARIAZIONI_USERLIST_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frmVARIAZIONI_USERLIST = new Form2();
                frmVARIAZIONI_USERLIST.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("btnVARIAZIONI_USERLIST_Click: " + exc.Message);
                //throw;
            }
        }
    }

}
