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
    public partial class frmInfoRichieste : Form
    {
        private string _matricola;
        private BindingSource _bs;
        public frmInfoRichieste()
        {
            InitializeComponent();
        }

        public frmInfoRichieste(string matricola)
        {
            InitializeComponent();
            this.Text = "Richieste -30/+30 -- " + matricola;
            matricola = matricola.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
            _matricola = matricola;
            this.Load += FrmInfoRichieste_Load;

        }

        private void FrmInfoRichieste_Load(object sender, EventArgs e)
        {
            compilaGriglia();
            grigliaRichieste.CellMouseEnter += GrigliaRichieste_CellMouseEnter;
        }

        private void GrigliaRichieste_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*tooltip*/
            if (e.RowIndex >= 0 && e.ColumnIndex==0)
            {
                ttNote.Show(grigliaRichieste[4, e.RowIndex].Value.ToString(),this,
                    grigliaRichieste.PointToClient(new Point(MousePosition.X+5, MousePosition.Y+20) ));
             
            }
        }

        private void coloraRIGHE()
        {
            foreach (DataGridViewRow dgvRIGA in grigliaRichieste.Rows)
            {
                foreach (DataGridViewCell cella in dgvRIGA.Cells)
                {
                    cella.ReadOnly = true;

                }
                if (dgvRIGA.Cells[0].Value.ToString().StartsWith("1") ||
                    dgvRIGA.Cells[0].Value.ToString().StartsWith("4"))
                {
                    dgvRIGA.DefaultCellStyle.BackColor = Color.LightGray;
                    dgvRIGA.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Italic);
                    dgvRIGA.DefaultCellStyle.ForeColor = Color.Gray;
                }
                if (dgvRIGA.Cells[3].Value.ToString() == "S")
                {
                    dgvRIGA.Cells[3].Style.BackColor = Color.LightGreen;

                }
                if (dgvRIGA.Cells[3].Value.ToString() == "N")
                {
                    dgvRIGA.Cells[3].Style.BackColor = Color.LightSalmon;

                }
                if (dgvRIGA.Cells[3].Value.ToString() == "A")
                {
                    dgvRIGA.Cells[3].Style.BackColor = Color.LightYellow;

                }
            }
        }

        public void compilaGriglia()
        {
            db db = new db();
            DataTable dt = new DataTable();
            string sql = $@"SELECT
                A.VARIAZIONI_CODICE_BDROP||'-'||A.VARIAZIONI_CODICE_ANM as CODICE, 
                A.VARIAZIONI_DA_DATA as DA_DATA, 
                A.VARIAZIONI_A_DATA as A_DATA, 
                --A.VARIAZIONI_MATRICOLA ||' - '|| (select cognome||' '|| nome from paghenet.arcdipan where coddip =A.VARIAZIONI_MATRICOLA) as NOMINATIVO, 
                CASE A.VARIAZIONI_CODICE_BDROP 
                    when 1 then '--'
                    when 4 then '--'
                    else  A.VARIAZIONI_FLAG_CONSENSO
                end as CONS, 
                LOWER(A.VARIAZIONI_NOTE) as NOTE
                from ANMIS1.ANM_VROS_D_VARIAZIONI A WHERE TRIM(A.VARIAZIONI_CODICE_BDROP) IN ('1','2','4','5','6','7') 
            and A.variazioni_da_data between to_date('{DateTime.Now.AddDays(-30).ToShortDateString()}','dd/mm/yyyy') and to_date('{DateTime.Now.AddDays(30).ToShortDateString()}','dd/mm/yyyy')
            and
            A.variazioni_matricola = '{_matricola}'
            order by A.VARIAZIONI_DA_DATA desc ";
            //AND TRIM(VARIAZIONI_CODICE_ANM) IN ('11A','11C','A','AA','33A','33C','7')

            _bs = new BindingSource();
            
            dt = db.getDataTable(sql);
            _bs.DataSource = dt;
           commons.SetDoubleBuffer(grigliaRichieste, true);
            grigliaRichieste.DataSource = _bs;
            grigliaRichieste.Columns[4].Visible = false;
            db.Dispose();
            coloraRIGHE();

        }
    }
}
