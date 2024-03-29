﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASRIP.classi;


namespace ASRIP
{
    public partial class frmStato : Form
    {
        string _numProtocollo;
        private bool _reload;

        public bool Reload { get => _reload;}

        public frmStato(string numProtocollo)
        {
            InitializeComponent();
            _reload = false;
            _numProtocollo = numProtocollo;
            btnAnnulla.Click += (se, ev) => { this.Close(); };
            btnElimina.Click += BtnElimina_Click;
            //btnSalva.Click += BtnSalva_Click;
            compilaDati();

        }
        private void compilaDati()
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
                A.VARIAZIONI_NUM_PROTOCOLLO, 
                A.DATA_COM_EVENTO
            FROM ANMIS1.ANM_VROS_D_VARIAZIONI A where VARIAZIONI_NUM_PROTOCOLLO ={_numProtocollo} ";
            db db = new db();
            OracleDataReader r = db.getReader(sql);
            if (r.HasRows)
            {
                r.Read();
                txtMonitor.Text = "Richiesta tipo [" + r[0].ToString() + "] effettuata da " + r[3].ToString() + " \r\n " +
                                  "Impianto: " + r[4].ToString() + " [" + r[5].ToString() + "-" + r[6].ToString() + "]";
                txtDataDal.Value = DateTime.Parse(r[1].ToString());
                txtDataAl.Value = DateTime.Parse(r[2].ToString());
                switch (r[9].ToString())
                {
                    case "S":
                        lstStato.SelectedIndex = 0;
                        break;
                    case "N":
                        lstStato.SelectedIndex = 1;
                        break;
                    case "A":
                        lstStato.SelectedIndex = 2;
                        break;
                    default:
                        break;
                }
                //codice per la gestione delle richieste non soggette ad approvazione
                if (r[0].ToString().Substring(0, 1) == "1")
                {
                    btnSalva.Visible = false;
                }
                else
                {
                    btnSalva.Visible = true;
                }
            }




        }
        private void frmStato_Load(object sender, EventArgs e)
        {

        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                string StatoRichiesta = "";
                switch (lstStato.SelectedIndex)
                {
                    case 0:
                        StatoRichiesta = "S";
                        break;
                    case 1:
                        StatoRichiesta = "N";
                        break;
                    case 2:
                        StatoRichiesta = "A";
                        break;
                }
                commons.scriviLog($@"Modifica stato richiesta {_numProtocollo}, nuovo stato={StatoRichiesta}");
                commons.alteraStatoRichiesta(StatoRichiesta, _numProtocollo);
            
                _reload = true;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("BtnSalva_Click: " + exc.Message, "Attenzione");
            }
            
        }
        private void BtnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_insert = $@"insert into malattie_log values(
                            to_date('{DateTime.Now.ToShortDateString()}','dd/mm/yyyy'),
                            '{Environment.UserName}',
                            '{Environment.MachineName}',
                            'Eliminazione Richiesta prot. {_numProtocollo}', 'ASRIP')";

                string sql_copy = $@"INSERT INTO ANMIS1.ANM_VROS_D_CESTINOVARIAZIONI (
                                   VARIAZIONI_CODICE_BDROP, VARIAZIONI_CODICE_ANM, VARIAZIONI_DA_DATA, 
                                   VARIAZIONI_A_DATA, VARIAZIONI_MATRICOLA, VARIAZIONI_DOMICILIO, 
                                   VARIAZIONI_DEP_INTERESSATO, VARIAZIONI_COD_DISTRETTOASL, VARIAZIONI_1CONTATTO_ORA, 
                                   VARIAZIONI_1CONTATTO_RIC, VARIAZIONI_2CONTATTO_ORA, VARIAZIONI_2CONTATTO_RIC, 
                                   VARIAZIONI_LINEA, VARIAZIONI_TRENO, VARIAZIONI_MONTO, 
                                   VARIAZIONI_FASCIA_ORARIA_DA, VARIAZIONI_FASCIA_ORARIA_A, VARIAZIONI_PREF_LINEA1, 
                                   VARIAZIONI_PREF_LINEA2, VARIAZIONI_PREF_LINEA3, VARIAZIONI_PREF_LINEA4, 
                                   VARIAZIONI_PREF_LINEA5, VARIAZIONI_PREF_LINEA6, VARIAZIONI_PREF_LINEA7, 
                                   VARIAZIONI_PREF_LINEA8, VARIAZIONI_PREF_LINEA9, VARIAZIONI_PREF_LINEA10, 
                                   VARIAZIONI_SCAMBIA_CON, VARIAZIONI_FLAG_PROSIEGUO, VARIAZIONI_FLAG_DISP_STRAORD, 
                                   VARIAZIONI_FLAG_CONSENSO, VARIAZIONI_DATA_INSERIMENTO_UP, VARIAZIONI_UTENTE_UP, 
                                   VARIAZIONI_TERMINALE_UP, VARIAZIONI_DATA_INSERIMENTO, VARIAZIONI_UTENTE, 
                                   VARIAZIONI_TERMINALE, VARIAZIONI_NOTE, VARIAZIONI_CODICE_TRATTAMENTO, 
                                   VARIAZIONI_DATA_TRATTAMENTO, VARIAZIONI_NUM_PROTOCOLLO, VARIAZIONI_VERIFICA_RICHIESTA) 
                                select VARIAZIONI_CODICE_BDROP, VARIAZIONI_CODICE_ANM, VARIAZIONI_DA_DATA, 
                                   VARIAZIONI_A_DATA, VARIAZIONI_MATRICOLA, VARIAZIONI_DOMICILIO, 
                                   VARIAZIONI_DEP_INTERESSATO, VARIAZIONI_COD_DISTRETTOASL, VARIAZIONI_1CONTATTO_ORA, 
                                   VARIAZIONI_1CONTATTO_RIC, VARIAZIONI_2CONTATTO_ORA, VARIAZIONI_2CONTATTO_RIC, 
                                   VARIAZIONI_LINEA, VARIAZIONI_TRENO, VARIAZIONI_MONTO, 
                                   VARIAZIONI_FASCIA_ORARIA_DA, VARIAZIONI_FASCIA_ORARIA_A, VARIAZIONI_PREF_LINEA1, 
                                   VARIAZIONI_PREF_LINEA2, VARIAZIONI_PREF_LINEA3, VARIAZIONI_PREF_LINEA4, 
                                   VARIAZIONI_PREF_LINEA5, VARIAZIONI_PREF_LINEA6, VARIAZIONI_PREF_LINEA7, 
                                   VARIAZIONI_PREF_LINEA8, VARIAZIONI_PREF_LINEA9, VARIAZIONI_PREF_LINEA10, 
                                   VARIAZIONI_SCAMBIA_CON, VARIAZIONI_FLAG_PROSIEGUO, VARIAZIONI_FLAG_DISP_STRAORD, 
                                   VARIAZIONI_FLAG_CONSENSO, VARIAZIONI_DATA_INSERIMENTO_UP, VARIAZIONI_UTENTE_UP, 
                                   VARIAZIONI_TERMINALE_UP, VARIAZIONI_DATA_INSERIMENTO, VARIAZIONI_UTENTE, 
                                   VARIAZIONI_TERMINALE, VARIAZIONI_NOTE, VARIAZIONI_CODICE_TRATTAMENTO, 
                                   VARIAZIONI_DATA_TRATTAMENTO, VARIAZIONI_NUM_PROTOCOLLO, VARIAZIONI_VERIFICA_RICHIESTA
                                   from anm_vros_d_variazioni v where  v.VARIAZIONI_NUM_PROTOCOLLO = '{_numProtocollo}'";

                string sql_delete = $@"delete from anm_vros_d_variazioni where VARIAZIONI_NUM_PROTOCOLLO = '{_numProtocollo}'";

                if (MessageBox.Show("Elimino la richiesta selezionata? ATTENZIONE L'operazione eliminirà la richiesta dall'archivio!",
                                        "Eliminazione Richiesta",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    db db = new db();
                    if (db.exe(sql_insert) == 0)
                    {
                        MessageBox.Show("Errore in fase 1 eliminazione, contattare ICT. LA RICHIESTA NON E' STATA ELIMINATA!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (db.exe(sql_copy) == 0)
                    {
                        MessageBox.Show("Errore in fase 2 eliminazione, contattare ICT. LA RICHIESTA NON E' STATA ELIMINATA!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (db.exe(sql_delete) == 0)
                    {
                        MessageBox.Show("Errore in fase 3 eliminazione, contattare ICT. LA RICHIESTA NON E' STATA ELIMINATA!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.Dispose();
                    _reload = true;
                    this.Close();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("BtnElimina_Click: " + exc.Message, "Attenzione");
            }

        }
    }
}
