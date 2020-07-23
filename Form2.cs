using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ASRIP
{
    public partial class Form2 : Form
    {

        private OracleConnection connString = new OracleConnection("Data Source =ANM;User ID=WEBSITEANM;Password=SITO.WEB;Unicode=True");
        private OracleCommand generiCommand = new OracleCommand();
        private BindingSource bin = new BindingSource();
        private DataTable dt = new DataTable();
        private string AMBITO = "";
        private Regex rgx = new Regex(@"[A-Z]\.??[A-Z]");
        private Boolean aBuonFine = true;
        private Int32 contatore = 0;
        private Boolean esiste = false;
        private string ambitoGlobale = "";
        private string[] splitter;

        private void clrScreen()
        {
            txtUTENTE_AD.Text = "";
            txtSTAZIONE.Text = "";
            chkAMBITO.Checked = false;
            for (int i = 0; i < clbCENTRI_COSTO.Items.Count; i++) clbCENTRI_COSTO.SetItemChecked(i, false);
        }

        public void compilaCAMPI(DataTable _dt)
        {
            splitter = _dt.Rows[0][4].ToString().Split(',');
            txtUTENTE_AD.Text = _dt.Rows[0][0].ToString();
            txtSTAZIONE.Text = _dt.Rows[0][1].ToString();
            switch (_dt.Rows[0][2].ToString())
            {
                case "R":
                    chkAMBITO.Checked = false;
                    break;
                default:
                    chkAMBITO.Checked = true;
                    if (_dt.Rows[0][2].ToString() == "admin")
                    { ambitoGlobale = "admin"; }
                    else { ambitoGlobale = "W"; }
                    break;
            }
            foreach (string valore in splitter)
            {

                for (int i = 0; i < clbCENTRI_COSTO.Items.Count; i++)
                {
                    if (valore.Replace("'", "") == clbCENTRI_COSTO.Items[i].ToString())
                    {
                        clbCENTRI_COSTO.SetItemChecked(i, true);
                        break;
                    }
                }

            }
        }

        private Boolean getUTENTE_AD(string UTENTE_AD)
        {
            Boolean esito = false;
            string qry = "";          
            dt = new DataTable();            
            qry = "SELECT * FROM WEBSITEANM.VARIAZIONI_USERLIST WHERE UTENTE_AD = '" + UTENTE_AD + "'";
            if (connString.State == ConnectionState.Closed) connString.Open();
            generiCommand.CommandText = qry;
            dt.Load(generiCommand.ExecuteReader());
            if (dt.Rows.Count > 0 && dt.Rows.Count < 2)
            {
                esito = true;
                compilaCAMPI(dt);
            }else
            {
                if (dt.Rows.Count > 1) {
                    esito = true;
                    Form3 frmSCELTA = new Form3(dt);
                    frmSCELTA.ShowDialog();
                    compilaCAMPI(frmSCELTA.dtAppoggio);
                }
            }
            
            if (connString.State == ConnectionState.Open) connString.Close();
            return esito;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                generiCommand = new OracleCommand();
                generiCommand = connString.CreateCommand();
                AMBITO = "R";
                this.Name = "frmVARIAZIONI_USERLIST";
            }
            catch (Exception exc)
            {
                MessageBox.Show("Form2_Load: " + exc.Message);
                //throw;
            }
        }

        private void btnREGISTRA_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowsAffected = 0;
                string UTENTE_AD = txtUTENTE_AD.Text.Trim();
                string STAZIONE = txtSTAZIONE.Text.Trim();
                string CENTRI_COSTO = "";
                string comando = "";

                if (chkAMBITO.Checked)
                {
                    if (ambitoGlobale == "admin") {
                        AMBITO = "admin";
                        ambitoGlobale = "";
                    } else { AMBITO = "W"; }
                }
                else
                { AMBITO = "R"; }
                foreach (string item in clbCENTRI_COSTO.CheckedItems)
                {
                    CENTRI_COSTO += "''" + item + "'',";
                }
                CENTRI_COSTO = CENTRI_COSTO.Substring(0, (CENTRI_COSTO.Length - 1));

                if (esiste) //esiste
                {
                    comando = "UPDATE WEBSITEANM.VARIAZIONI_USERLIST SET STAZIONE = '" + STAZIONE + "', AMBITO = '" +
                        AMBITO + "', CENTRI_COSTO = '" + CENTRI_COSTO + "' WHERE UTENTE_AD = '" + UTENTE_AD + "' AND STAZIONE = '" + STAZIONE + "'";
                }
                else
                {
                    comando = "INSERT INTO WEBSITEANM.VARIAZIONI_USERLIST VALUES('" + UTENTE_AD + "','" +
                        STAZIONE + "','" + AMBITO + "',NULL,'" + CENTRI_COSTO + "')";
                }

                if (connString.State == ConnectionState.Closed) connString.Open();
                generiCommand.CommandText = comando;
                rowsAffected = generiCommand.ExecuteNonQuery();
                if (connString.State == ConnectionState.Open) connString.Close();
                if (rowsAffected > 0)
                { aBuonFine = true; }
                else
                { aBuonFine = false; }
                timer1.Start();

            }
            catch (Exception exc)
            {
                MessageBox.Show("btnREGISTRA_Click: " + exc.Message);
            }
        }

        private void txtUTENTE_AD_Validated(object sender, EventArgs e)
        {
            try
            {
                string UTENTE_AD = txtUTENTE_AD.Text.Trim();
                esiste = getUTENTE_AD(UTENTE_AD);
                  
            }
            catch (Exception exc)
            {
                MessageBox.Show("txtUTENTE_AD_Validated: " + exc.Message);
            }
        }

        private void btnPULISCI_Click(object sender, EventArgs e)
        {
            try
            {
                clrScreen();
            }
            catch (Exception exc)
            {

                MessageBox.Show("btnPULISCI_Click: " + exc.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contatore += 1;
            if (contatore > 10)
            {
                lblMONITOR.Visible = false;
                contatore = 0;
                timer1.Stop();
            }
            else
            {
                if (aBuonFine)
                {
                    lblMONITOR.Text = "Aggiornamento db effettuato.";

                }
                else
                {
                    lblMONITOR.Text = "Aggiornamento non riuscito.";
                }
                if (lblMONITOR.Visible == true)
                {
                    lblMONITOR.Visible = false;
                }
                else
                {
                    lblMONITOR.Visible = true;
                }
            }
            
        }

        private void btnCancellaRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowsAffected = 0;
                string UTENTE_AD = txtUTENTE_AD.Text.Trim();
                string STAZIONE = txtSTAZIONE.Text.Trim();
                string comando = "DELETE FROM WEBSITEANM.VARIAZIONI_USERLIST  WHERE UTENTE_AD = '" + UTENTE_AD + "'";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                //scelta
                result = MessageBox.Show("Se scegli 'si', verranno eliminati tutti i record relativi all'utente selezionato. Procedo?", "Attenzione", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (connString.State == ConnectionState.Closed) connString.Open();
                    generiCommand.CommandText = comando;
                    rowsAffected = generiCommand.ExecuteNonQuery();
                    if (connString.State == ConnectionState.Open) connString.Close();
                    if (rowsAffected > 0)
                    {
                        aBuonFine = true;
                        clrScreen();
                    }
                    else
                    { aBuonFine = false; }
                    timer1.Start();
                }
                
            }
            catch (Exception exc)
            {

                MessageBox.Show("btnCancellaRecord_Click: " + exc.Message);
            }
        }

        //private void btnCERCA_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string qry = "";
        //        string[] splitter;
        //        string UTENTE_AD = txtUTENTE_AD.Text.Trim();
        //        if (!rgx.IsMatch(UTENTE_AD))
        //        {
        //            MessageBox.Show("Il nome utente deve rispettare il seguente formato: 'gruppoLettere.gruppoLettere");
        //            txtUTENTE_AD.Text = "";
        //        } else
        //        {
        //            qry = "SELECT * FROM WEBSITEANM.VARIAZIONI_USERLIST WHERE UTENTE_AD = '" + UTENTE_AD + "'";
        //            generiCommand.CommandText = qry;
        //            dt.Load(generiCommand.ExecuteReader());
        //            splitter = dt.Rows[0][4].ToString().Split(',');
        //            txtUTENTE_AD.Text = dt.Rows[0][0].ToString();
        //            txtSTAZIONE.Text = dt.Rows[0][1].ToString();
        //            switch (dt.Rows[0][2].ToString())
        //            {
        //                case "R":
        //                    chkAMBITO.Checked = false;
        //                    break;
        //                default:
        //                    chkAMBITO.Checked = true;
        //                    break;
        //            }
        //            foreach(string valore in splitter)
        //            {
        //                for (int i = 0; i < clbCENTRI_COSTO.Items.Count; i++)
        //                { if (valore == clbCENTRI_COSTO.Items[i].ToString())
        //                    { clbCENTRI_COSTO.SetItemChecked(i, true);
        //                      break;                               
        //                    }
        //                }

        //            }
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show("btnCERCA_Click: " + exc.Message);

        //    }
        //}
    }
}
