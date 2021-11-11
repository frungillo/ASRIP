using System;
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
        private int i = 0;
        private int x, y;
        string LISTA_CC;
        string AMBITO;

        private void confermaRigheConCodiceUno(ref DataTable dt)
        {
            int i = 0;
            foreach (DataRow riga in dt.Rows)
            {
                if (riga.ItemArray[0].ToString().Substring(0, 1) == "1")
                {
                    dt.Rows[i][9] = "S";
                }
                i++;
            }
        }
        private void coloraRIGHE()
        {
            foreach(DataGridViewRow dgvRIGA in grigliaRichieste.Rows)
            {
                if(dgvRIGA.Cells[0].Value.ToString().Substring(0,1) == "1")
                {
                    dgvRIGA.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
        private void compilaGriglia()
        {

            //string sql = @"SELECT
            //    A.VARIAZIONI_CODICE_BDROP||'-'||A.VARIAZIONI_CODICE_ANM as CODICE, 
            //    A.VARIAZIONI_DA_DATA as DA_DATA, 
            //    A.VARIAZIONI_A_DATA as A_DATA, 
            //    A.VARIAZIONI_MATRICOLA ||' - '|| (select cognome||' '|| nome from paghenet.arcdipan where coddip =A.VARIAZIONI_MATRICOLA) as NOMINATIVO, 
            //    A.VARIAZIONI_DEP_INTERESSATO as DEPOSITO, 
            //    A.VARIAZIONI_LINEA as LINEA, 
            //    A.VARIAZIONI_TRENO as TRENO, 
            //    A.VARIAZIONI_MONTO as MONTO, 
            //    A.VARIAZIONI_SCAMBIA_CON as SCAMBIANTE, 
            //    A.VARIAZIONI_FLAG_CONSENSO as CONS, 
            //    A.VARIAZIONI_UTENTE as UTENTE, 
            //    LOWER(A.VARIAZIONI_NOTE) as NOTE, 
            //    A.VARIAZIONI_NUM_PROTOCOLLO as PROTOCOLLO";
            //if (currentSate == "ANMIS1.ANM_VROS_D_VARIAZIONI") sql += "    ,A.DATA_COM_EVENTO as Data_Comun";
            //sql += $@" FROM {currentSate} A where VARIAZIONI_CODICE_BDROP=6 and to_date('{txtData.Value.ToShortDateString()}','dd/mm/yyyy')
            //between variazioni_da_data and variazioni_a_data and
            //variazioni_matricola in (select Matricolaautista 
            //                            from bdroptables.residenzeautisti 
            //                            where residenza in ({LISTA_CC})
            //                         and trunc(sysdate) between iniziovalidita and finevalidita )
            //order by VARIAZIONI_DA_DATA, VARIAZIONI_MATRICOLA ";

            //VERSIONE PROVA
            int i = 0;
            db db = new db();
            DataTable dt = new DataTable();
            string sql = @"SELECT
                A.VARIAZIONI_CODICE_BDROP||'-'||A.VARIAZIONI_CODICE_ANM as CODICE, 
                A.VARIAZIONI_DA_DATA as DA_DATA, 
                A.VARIAZIONI_A_DATA as A_DATA, 
                A.VARIAZIONI_MATRICOLA ||' - '|| (select cognome||' '|| nome from paghenet.arcdipan where coddip =A.VARIAZIONI_MATRICOLA) as NOMINATIVO, 
                A.VARIAZIONI_DEP_INTERESSATO as DEPOSITO, 
                A.VARIAZIONI_LINEA as LINEA, 
                A.VARIAZIONI_TRENO as TRENO, 
                A.VARIAZIONI_MONTO as MONTO, 
                A.VARIAZIONI_SCAMBIA_CON as SCAMBIANTE, 
                A.VARIAZIONI_FLAG_CONSENSO as CONS, 
                A.VARIAZIONI_UTENTE as UTENTE, 
                LOWER(A.VARIAZIONI_NOTE) as NOTE, 
                A.VARIAZIONI_NUM_PROTOCOLLO as PROTOCOLLO";
            if (currentSate == "ANMIS1.ANM_VROS_D_VARIAZIONI") sql += "    ,A.DATA_COM_EVENTO as Data_Comun";
            sql += $@" FROM {currentSate} A WHERE TRIM(A.VARIAZIONI_CODICE_BDROP) IN ('1','2','4','5','6','7') 
            and to_date('{txtData.Value.ToShortDateString()}','dd/mm/yyyy')
            between A.variazioni_da_data and A.variazioni_a_data and
            A.variazioni_matricola in (select Matricolaautista 
                                        from bdroptables.residenzeautisti 
                                        where residenza in ({LISTA_CC})
                                     and trunc(sysdate) between iniziovalidita and finevalidita )
            order by A.VARIAZIONI_DA_DATA, A.VARIAZIONI_MATRICOLA ";
            //AND TRIM(VARIAZIONI_CODICE_ANM) IN ('11A','11C','A','AA','33A','33C','7')

            
            _bs = new BindingSource();           
            dt = db.getDataTable(sql);
            //_bs.DataSource = db.getDataTable(sql);
            //snocciolo la datatable per mettere ad "S" tutti i codici bdrop = 1
            confermaRigheConCodiceUno(ref dt);
            _bs.DataSource = dt;
            bnCOMANDI.BindingSource = _bs;
            grigliaRichieste.DataSource = _bs;
            coloraRIGHE();
            db.Dispose();
        }
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
        private List<string> snocciolaGridView()
        {
            List<string> listaCOMANDI = new List<string>();
            string command = "";
            i = 0;
            foreach (DataGridViewRow riga in grigliaRichieste.Rows)
            {
                if (riga.Cells[9].Value.ToString() != "A")
                {
                    DateTime dataINIZIO = new DateTime();
                    DateTime dataFINE = new DateTime();
                    DateTime dataDaINSERIRE = new DateTime();
                    string[] codBDROP_ANM = riga.Cells[0].Value.ToString().Split('-');
                    string[] coddip = riga.Cells[3].Value.ToString().Split(' ');
                    string coddipSCAMBIO = riga.Cells[8].Value.ToString();
                    string codiceTRATTAMENTO = riga.Cells[9].Value.ToString();
                    if (coddipSCAMBIO == "") coddipSCAMBIO = "NULL";
                    if (codiceTRATTAMENTO == "S") codiceTRATTAMENTO = "9"; else codiceTRATTAMENTO = "8";
                    dataINIZIO = Convert.ToDateTime(riga.Cells[1].Value.ToString());
                    dataFINE = Convert.ToDateTime(riga.Cells[2].Value.ToString());
                    dataDaINSERIRE = dataINIZIO;
                    i += 1;
                    command = "";
                    command = "UPDATE ANMIS1.ANM_VROS_D_VARIAZIONI SET VARIAZIONI_DATA_INSERIMENTO_UP = TRUNC(SYSDATE), VARIAZIONI_UTENTE_UP = '"
                        + Environment.UserName + "',VARIAZIONI_TERMINALE_UP = '" + Environment.MachineName + "' WHERE VARIAZIONI_CODICE_BDROP = '"
                        + codBDROP_ANM[0] + "' AND VARIAZIONI_CODICE_ANM = '" + codBDROP_ANM[1] + "' AND VARIAZIONI_MATRICOLA = '" + coddip[0]
                        + "' AND VARIAZIONI_DA_DATA = TO_DATE('" + dataINIZIO.ToShortDateString() + "','DD/MM/YYYY')";
                    listaCOMANDI.Add(command);
                    while (dataDaINSERIRE <= dataFINE)
                    {
                        //NON INSERISCO CODICE PER LA VERIFICA DI UN PRECEDENTE INSERIMENTO DELLA RIGA CORRENTE PERCHE' E' PRESENTE UNA CHIAVE PRIMARIA SUL DB
                        //NEL CASO IL DB RISPONDESSE PICCHE, VADO IN ECCEZIONE E MANDO TUTTO IN ROLLBACK
                        command = "";
                        command = "INSERT INTO BDROPTABLES.VARIAZIONI VALUES('" + codBDROP_ANM[0] + "','" + codBDROP_ANM[1] + "',TO_DATE('" + dataDaINSERIRE.ToShortDateString() + "','DD/MM/YYYY'),'" +
                            coddip[0] + "',NULL,NULL,'" + riga.Cells[5].Value.ToString() + "NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'" + coddipSCAMBIO + "', NULL,'" +
                            codiceTRATTAMENTO + "',NULL,NULL,NULL,NULL,NULL, TO_DATE('" + riga.Cells[13].Value.ToString() + "','DD/MM/YYYY'))";
                        dataDaINSERIRE = dataDaINSERIRE.AddDays(1);
                        listaCOMANDI.Add(command);
                    }
                }
            }
            return listaCOMANDI;
        }
        public Form1()
        {
            InitializeComponent();
            _bs = new BindingSource();
            this.Load += Form1_Load;
           // btnCestino.Click += BtnCestino_Click;
            //txtData.ValueChanged += TxtData_ValueChanged;
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!checkAut())
                {
                    MessageBox.Show("Utente/Stazione non autorizzato all'uso del programma, contattare il gestiore della procedura.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Application.Exit();
                }
                if (AMBITO == "R")
                {
                    btnCestino.Visible = false;
                    btnABILITAZIONI.Visible = false;
                    btnCaricaVariazioni.Visible = false;
                }

                if (AMBITO != "admin")
                {
                    //btnCestino.Visible = false;
                    btnABILITAZIONI.Visible = false;
                    //btnCaricaVariazioni.Visible = false;
                }


                txtData.Value = DateTime.Now;
                if (ApplicationDeployment.IsNetworkDeployed) this.Text += " - Ver." + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

                //caricamento iniziale della gridview
                compilaGriglia();


                //txtRicerca.TextChanged += TxtRicerca_TextChanged;
                //grigliaRichieste.RowsAdded += GrigliaRichieste_RowsAdded;
                grigliaRichieste.CellDoubleClick += GrigliaRichieste_CellDoubleClick;
                //  grigliaRichieste.ContextMenu = contextMenu;
                grigliaRichieste.MouseDown += GrigliaRichieste_MouseClick;
                txtUtenteSel.TextChanged += txtUtenteSel_TextChanged;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Form1_Load: " + exc.Message, "Attenzione");
                Application.Exit();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.F2:
                        btnVARIAZIONI_USERLIST_Click(null, null);
                        break;
                    case Keys.F7:
                        btnStampa_Click(null, null);
                        break;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Form1_KeyUp: " + exc.Message, "Attenzione");
            }
        }         
        private void txtUtenteSel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Size size = TextRenderer.MeasureText(txtUtenteSel.Text, txtUtenteSel.Font);
                txtUtenteSel.Width = size.Width + 10;
                //textBox1.Height = size.Height;
            }
            catch (Exception exc)
            {
                MessageBox.Show("txtUtenteSel_TextChanged: " + exc.Message, "Attenzione");
            }
        }
        private void GrigliaRichieste_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    x = 0; y = 0;
                    x = e.X; y = e.Y;
                    DataGridView.HitTestInfo row = grigliaRichieste.HitTest(e.X, e.Y);
                    if (row.RowIndex > -1)
                    {
                        grigliaRichieste.ClearSelection();
                        txtUtenteSel.Text = (string)grigliaRichieste[3, row.RowIndex].Value;
                        grigliaRichieste.Rows[row.RowIndex].Selected = true;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("GrigliaRichieste_MouseClick: " + exc.Message, "Attenzione");
            }
        }
        private void GrigliaRichieste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (AMBITO == "R") { MessageBox.Show("Utente non autorizzato alla modifica", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                    string numprot = grigliaRichieste[12, e.RowIndex].Value.ToString();
                    frmStato frm = new frmStato(numprot);
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog(this);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("GrigliaRichieste_CellDoubleClick: " + exc.Message, "Attenzione");
            }
        }
        private void TxtData_ValueChanged(object sender, EventArgs e)
        {
            compilaGriglia();
        }
        private void TxtRicerca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = @"CODICE like'*{0}*'  or NOMINATIVO like '*{0}*' or NOTE like '*{0}*' or DEPOSITO like '*{0}*'";
                if (txtRicerca.Text.StartsWith("?"))
                {
                    if (txtRicerca.Text.EndsWith("?"))
                    {
                        try
                        {
                            _bs.Filter = txtRicerca.Text.Replace("?", "");
                        }
                        catch (Exception ex)
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
                coloraRIGHE();
            }
            catch (Exception exc)
            {
                MessageBox.Show("TxtRicerca_TextChanged: " + exc.Message, "Attenzione");
            }
            
        }
        private void BtnCestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCestino.Text == "Cestino")
                {
                    btnCestino.Text = "Variazioni";
                    currentSate = "ANMIS1.ANM_VROS_D_CESTINOVARIAZIONI";
                    compilaGriglia();
                }
                else
                {
                    btnCestino.Text = "Cestino";
                    currentSate = "ANMIS1.ANM_VROS_D_VARIAZIONI";
                    compilaGriglia();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("BtnCestino_Click: " + exc.Message, "Attenzione");
            }
        }
        private void btnStampa_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dg = new SaveFileDialog();
                dg.Filter = "Valori separati da virgola (*.csv)|*.csv";
                dg.FileName = "StampaRichieste";
                dg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dg.AddExtension = true;
                dg.DefaultExt = "csv";
                dg.Title = "Stampa Dati";
                if (dg.ShowDialog(this) == DialogResult.OK)
                {
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
            }
            catch (Exception exc)
            {
                MessageBox.Show("btnStampa_Click: " + exc.Message, "Attenzione");
            }
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
        private void btnCaricaVariazioni_Click(object sender, EventArgs e)
        {
            string esito = "";
            List<string> listaCOMANDI = new List<string>();
            DialogResult scelta;
            scelta = MessageBox.Show("Questo processo è irreversibile; vuoi confermare?", "Attenzione", MessageBoxButtons.YesNo);
            if (scelta == DialogResult.Yes)
            {
                try
                {
                    listaCOMANDI = snocciolaGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("btnCaricaVariazioni_Click; durante la creazione della lista comandi di aggiornamento db, si è verificato il seguente errore: " + exc.Message);
                    return;
                }
                //ESECUZIONE DELLA LISTA COMANDI SUL DB
                db ddbb = new db();
                esito = ddbb.exeMultiplo(listaCOMANDI.ToArray());
                try
                {
                    if (esito == "OK")
                    {
                        foreach (DataGridViewRow riga in grigliaRichieste.Rows)
                        {
                            if (riga.Cells[9].Value.ToString() != "A") riga.DefaultCellStyle.BackColor = Color.Azure;
                        }
                        scelta = new DialogResult();
                        scelta = MessageBox.Show("Le righe presenti in questa maschera, in stato diverso da 'attesa', sono " + i.ToString() + " e sono state correttamente caricate in VARIAZIONI BDROP. Vuoi stamparle?", "?", MessageBoxButtons.YesNo);
                        if (scelta == DialogResult.Yes) btnStampa_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show(esito, "Attenzione");
                    }
                    ddbb.Dispose();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("btnCaricaVariazioni_Click: " + exc.Message);
                }              
            }
        }
        private void btnAllineaDB_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 frmDATE = new Form4();
                frmDATE.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("btnAllineaDB_Click: " + exc.Message, "Attenzione");
            }
        }
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception exc)
            {
                MessageBox.Show("btnEXIT_Click: " + exc.Message, "Attenzione");
            }
        }
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRIGA = new DataGridViewRow();
                int rowIndex = grigliaRichieste.HitTest(x, y).RowIndex;
                if (rowIndex < 0)
                {
                    e.Cancel = true;
                }
                else
                {
                    dgvRIGA = grigliaRichieste.Rows[rowIndex];
                    if (dgvRIGA.Cells[0].Value.ToString().Substring(0, 1) == "1")
                    {
                        e.Cancel = true;
                        MessageBox.Show("Richiesta non soggetta ad alterazione dello stato", "Attenzione");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("contextMenu_Opening: " + exc.Message, "Attenzione");
            }
        }
    }
}
