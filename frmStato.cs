using System;
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
        public frmStato(string numProtocollo)
        {
            InitializeComponent();
            _numProtocollo = numProtocollo;
            btnAnnulla.Click += (se, ev) => { this.Close(); };
            btnElimina.Click += BtnElimina_Click;
            btnSalva.Click += BtnSalva_Click;
            compilaDati();

        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            string UTENTE_ULTIMA_MODIFICA = Environment.UserName;
            string TERMINALE_ULTIMA_MODIFICA = Environment.MachineName;
            string DATA_ULTIMA_MODIFICA = "to_date('" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "', 'dd/mm/yyyy HH24:MI')";
            string StatoRichiesta = "";
            switch(lstStato.SelectedIndex)
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
            string sql_log = $@"insert into malattie_log values(
                            {DATA_ULTIMA_MODIFICA},
                            '{UTENTE_ULTIMA_MODIFICA}',
                            '{TERMINALE_ULTIMA_MODIFICA}',
                            'Modifica stato richiesta {_numProtocollo}, nuovo stato={StatoRichiesta}', 'ASRIP')";
            string sql_update = $@"update anm_vros_d_variazioni set VARIAZIONI_FLAG_CONSENSO='{StatoRichiesta}', 
                                    variazioni_data_inserimento_up={DATA_ULTIMA_MODIFICA},
                                    variazioni_utente_up = '{UTENTE_ULTIMA_MODIFICA}',
                                    variazioni_terminale_up = '{TERMINALE_ULTIMA_MODIFICA}'
                                    where VARIAZIONI_NUM_PROTOCOLLO = '{_numProtocollo}' ";

            db db = new db();
            db.exe(sql_log);
            db.exe(sql_update);
            db.Dispose();

        }

        private void BtnElimina_Click(object sender, EventArgs e)
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
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                
                db db = new db();
                if(db.exe(sql_insert) == 0)
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

            }
            
        }

        private void compilaDati() {
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
                txtMonitor.Text = "Richiesta tipo ["+r[0].ToString()+"] effettuata da "+r[3].ToString()+" \r\n "+
                                  "Impianto: "+r[4].ToString()+" ["+r[5].ToString()+"-"+r[6].ToString()+"]";
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
            }

            


        }
    }
}
