using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ASRIP.classi
{
    public class commons
    {

        public static void SetDoubleBuffer(Control dgv, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgv, new object[] { DoubleBuffered });
        }

        public static void scriviLog(string msg)
        {
            string UTENTE_ULTIMA_MODIFICA = Environment.UserName;
            string TERMINALE_ULTIMA_MODIFICA = Environment.MachineName;
            string DATA_ULTIMA_MODIFICA = "to_date('" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "', 'dd/mm/yyyy HH24:MI')";
            string sql_log = $@"insert into malattie_log values(
                            {DATA_ULTIMA_MODIFICA},
                            '{UTENTE_ULTIMA_MODIFICA}',
                            '{TERMINALE_ULTIMA_MODIFICA}',
                            '{msg.Replace("'", "''")}', 'ASRIP')";
            db db = new db();
            db.exe(sql_log);
            db.Dispose();
        }

        public static void alteraStatoRichiesta(string StatoRichiesta, string _numProtocollo)
        {
            string UTENTE_ULTIMA_MODIFICA = Environment.UserName;
            string TERMINALE_ULTIMA_MODIFICA = Environment.MachineName;
            string DATA_ULTIMA_MODIFICA = "to_date('" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "', 'dd/mm/yyyy HH24:MI')";
            string sql_update = $@"update anm_vros_d_variazioni set VARIAZIONI_FLAG_CONSENSO='{StatoRichiesta}', 
                                    variazioni_data_inserimento_up={DATA_ULTIMA_MODIFICA},
                                    variazioni_utente_up = '{UTENTE_ULTIMA_MODIFICA}',
                                    variazioni_terminale_up = '{TERMINALE_ULTIMA_MODIFICA}'
                                    where VARIAZIONI_NUM_PROTOCOLLO = '{_numProtocollo}' ";

            db db = new db();
            db.exe(sql_update);
            db.Dispose();
        }
    }


}
