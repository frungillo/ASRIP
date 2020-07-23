using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASRIP
{
    public partial class Form3 : Form
    {

        private DataTable dt = new DataTable();
        public DataTable dtAppoggio = new DataTable();
        public Form3(DataTable _dt)
        {
            InitializeComponent();
            dt = _dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUTENTE_AD.DataSource = dt;
            }
            catch (Exception exc)
            {

                MessageBox.Show("Form3_Load: " + exc.Message);
            }
        }

        private void dgvUTENTE_AD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                dtAppoggio = dt.Clone();
                DataRow dr = dt.NewRow();
                dr = dt.Rows[dgvUTENTE_AD.CurrentRow.Index];
                dtAppoggio.LoadDataRow(dr.ItemArray, true);
                this.Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show("dgvUTENTE_AD_CellDoubleClick: " + exc.Message);
            }
        }
    }
}
