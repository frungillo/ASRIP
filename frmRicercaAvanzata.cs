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
            int x = 5; int y = 15;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.HeaderText == "SEL") continue;
                Label lbl = new Label();
                lbl.Text = col.HeaderText;
                lbl.Location = new Point(x, y);
                Control txt;
                if (col.ValueType == typeof(DateTime))
                {
                     txt = new DateTimePicker();
                    ((DateTimePicker)txt).Value = new DateTime(1900, 01, 01);
                    ((DateTimePicker)txt).Format = DateTimePickerFormat.Short;
                } else
                {
                    txt = new TextBox();
                }
                txt.Tag = col.HeaderText;
                txt.Location = new Point(lbl.Size.Width + 20, y);
                txt.Size = new Size(100, 20);
                y += 35;

                grpCampi.Controls.Add(lbl);
                grpCampi.Controls.Add(txt);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            filtro = "";
            foreach(Control c in grpCampi.Controls)
            {
                
                if(c.GetType() == typeof(TextBox))
                {
                    if (c.Text != "") filtro += c.Tag.ToString() + " like '*" + c.Text.Replace("'","''") + "*' and ";
                }
                if (c.GetType() == typeof(DateTimePicker))
                {
                    if (((DateTimePicker)c).Value.ToShortDateString() != "01/01/1900") filtro += c.Tag.ToString() + " =  '" + ((DateTimePicker)c).Value.ToShortDateString() + "' and ";
                }

            }
            filtro += " 1=1";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtro = "";
            this.Close();
        }
    }
}
