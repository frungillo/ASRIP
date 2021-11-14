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
    public partial class frmRicercaAvanzata : Form
    {
        private DataGridView _dgv;
        public string filtro { get; set; }
        public frmRicercaAvanzata()
        {
            InitializeComponent();
        }
        public frmRicercaAvanzata(DataGridView dgv)
        {
            InitializeComponent();
            _dgv = dgv;
            int x = 5; int y = 5;
            foreach (DataGridViewColumn col in dgv.Columns)
            {

                Label lbl = new Label();
                lbl.Text = col.HeaderText;
                lbl.Location = new Point(x, y);
                TextBox txt = new TextBox();
                txt.Tag = col.HeaderText;
                txt.Location = new Point(lbl.Size.Width + 20, y);
                txt.Size = new Size(100, 20);
                y += 35;

                this.Controls.Add(lbl);
                this.Controls.Add(txt);
            }
        }
    }
}
