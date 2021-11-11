using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASRIP.classi;

namespace ASRIP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnVAI_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime da = new DateTime();
                DateTime a = new DateTime();
                DateTime dataRILEVAMENTO = new DateTime();
                db db = new db();
                DataTable dt = new DataTable();
                da = dtpDA.Value;
                a = dtpA.Value;

                if(da > a)
                {
                    MessageBox.Show("Date selezionate incongruenti", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //CONTROLLO CHE TUTTE LE RICHIESTE PRESENTI SU BDROP.VARIAZIONI ABBIANO UN RISCONTRO IN ANM_VROS_D_VARIAZIONI
                    dataRILEVAMENTO = da;
                    while (dataRILEVAMENTO <= a)
                    {
                        string sql = $@"SELECT CODICE_BDROP CBD,CODICE CANM,MATRICOLA MATRICOLA,NVL(MATR_SCAMBIO,'UYJFG') MATR_SCAMBIO
                                    FROM   VARIAZIONI
                                    WHERE  DATA = TO_DATE('{ dataRILEVAMENTO }','DD/MM/YYYY')
                                    MINUS
                                    SELECT TO_CHAR(VARIAZIONI_CODICE_BDROP),VARIAZIONI_CODICE_ANM ,VARIAZIONI_MATRICOLA,NVL(VARIAZIONI_SCAMBIA_CON,'UYJFG') 
                                    FROM   ANM_VROS_D_VARIAZIONI
                                    WHERE  TO_DATE('{ dataRILEVAMENTO }','DD/MM/YYYY')
                                           BETWEEN VARIAZIONI_DA_DATA
                                           AND     NVL(VARIAZIONI_A_DATA,TO_DATE('31/12/9999','DD/MM/YYYY'))
                                    UNION       
                                    SELECT CODICE_BDROP CBD,CODICE CANM,MATRICOLA MATRICOLA,NVL(MATR_SCAMBIO,'UYJFG') MATR_SCAMBIO
                                    FROM   VARIAZIONI
                                    WHERE  DATA = TO_DATE('{ dataRILEVAMENTO }','DD/MM/YYYY')
                                           AND CODICE_BDROP  = '6'
                                    MINUS
                                    SELECT TO_CHAR(VARIAZIONI_CODICE_BDROP),VARIAZIONI_CODICE_ANM ,VARIAZIONI_MATRICOLA,NVL(VARIAZIONI_SCAMBIA_CON,'UYJFG') 
                                    FROM   ANM_VROS_D_VARIAZIONI
                                    WHERE  TO_DATE('{ dataRILEVAMENTO }','DD/MM/YYYY')
                                           BETWEEN VARIAZIONI_DA_DATA
                                           AND NVL(VARIAZIONI_A_DATA,TO_DATE('31/12/9999','DD/MM/YYYY'))
                                           AND TO_CHAR(VARIAZIONI_CODICE_BDROP) = '6'
                                           AND VARIAZIONI_FLAG_CONSENSO = 'S'";
                    }
                    
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("btnVAI_Click: " + exc.Message, "Attenzione");
            }
        }
    }
}
