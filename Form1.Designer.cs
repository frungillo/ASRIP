namespace ASRIP
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grigliaRichieste = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rifiutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.lblRicerca = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCaricaVariazioni = new System.Windows.Forms.Button();
            this.btnVARIAZIONI_USERLIST = new System.Windows.Forms.Button();
            this.btnCestino = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.txtUtenteSel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RichiestetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnApprovaTutte = new System.Windows.Forms.Button();
            this.btnNegaTutte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grigliaRichieste
            // 
            this.grigliaRichieste.AllowUserToAddRows = false;
            this.grigliaRichieste.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grigliaRichieste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grigliaRichieste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.grigliaRichieste, 2);
            this.grigliaRichieste.ContextMenuStrip = this.contextMenu;
            this.grigliaRichieste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grigliaRichieste.Location = new System.Drawing.Point(3, 83);
            this.grigliaRichieste.MultiSelect = false;
            this.grigliaRichieste.Name = "grigliaRichieste";
            this.grigliaRichieste.ReadOnly = true;
            this.grigliaRichieste.RowHeadersVisible = false;
            this.grigliaRichieste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grigliaRichieste.Size = new System.Drawing.Size(1172, 658);
            this.grigliaRichieste.TabIndex = 0;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUtenteSel,
            this.toolStripSeparator1,
            this.approvaToolStripMenuItem,
            this.rifiutaToolStripMenuItem,
            this.attesaToolStripMenuItem,
            this.RichiestetoolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(261, 126);
            // 
            // approvaToolStripMenuItem
            // 
            this.approvaToolStripMenuItem.Name = "approvaToolStripMenuItem";
            this.approvaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.approvaToolStripMenuItem.Text = "Approva";
            // 
            // rifiutaToolStripMenuItem
            // 
            this.rifiutaToolStripMenuItem.Name = "rifiutaToolStripMenuItem";
            this.rifiutaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.rifiutaToolStripMenuItem.Text = "Rifiuta";
            // 
            // attesaToolStripMenuItem
            // 
            this.attesaToolStripMenuItem.Name = "attesaToolStripMenuItem";
            this.attesaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.attesaToolStripMenuItem.Text = "Attesa";
            // 
            // txtRicerca
            // 
            this.txtRicerca.Location = new System.Drawing.Point(55, 6);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(378, 20);
            this.txtRicerca.TabIndex = 1;
            // 
            // lblRicerca
            // 
            this.lblRicerca.AutoSize = true;
            this.lblRicerca.Location = new System.Drawing.Point(5, 9);
            this.lblRicerca.Name = "lblRicerca";
            this.lblRicerca.Size = new System.Drawing.Size(44, 13);
            this.lblRicerca.TabIndex = 2;
            this.lblRicerca.Text = "Ricerca";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(371, 6);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(200, 20);
            this.txtData.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grigliaRichieste, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1178, 744);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRicerca);
            this.panel1.Controls.Add(this.lblRicerca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCaricaVariazioni);
            this.panel2.Controls.Add(this.btnVARIAZIONI_USERLIST);
            this.panel2.Controls.Add(this.btnCestino);
            this.panel2.Controls.Add(this.btnStampa);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(592, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnCaricaVariazioni
            // 
            this.btnCaricaVariazioni.Location = new System.Drawing.Point(246, 5);
            this.btnCaricaVariazioni.Name = "btnCaricaVariazioni";
            this.btnCaricaVariazioni.Size = new System.Drawing.Size(108, 23);
            this.btnCaricaVariazioni.TabIndex = 7;
            this.btnCaricaVariazioni.Text = "Carica in BDROP";
            this.btnCaricaVariazioni.UseVisualStyleBackColor = true;
            this.btnCaricaVariazioni.Click += new System.EventHandler(this.btnCaricaVariazioni_Click);
            // 
            // btnVARIAZIONI_USERLIST
            // 
            this.btnVARIAZIONI_USERLIST.Location = new System.Drawing.Point(165, 5);
            this.btnVARIAZIONI_USERLIST.Name = "btnVARIAZIONI_USERLIST";
            this.btnVARIAZIONI_USERLIST.Size = new System.Drawing.Size(75, 23);
            this.btnVARIAZIONI_USERLIST.TabIndex = 6;
            this.btnVARIAZIONI_USERLIST.Text = "Abilitazioni";
            this.btnVARIAZIONI_USERLIST.UseVisualStyleBackColor = true;
            this.btnVARIAZIONI_USERLIST.Click += new System.EventHandler(this.btnVARIAZIONI_USERLIST_Click);
            // 
            // btnCestino
            // 
            this.btnCestino.Location = new System.Drawing.Point(84, 4);
            this.btnCestino.Name = "btnCestino";
            this.btnCestino.Size = new System.Drawing.Size(75, 23);
            this.btnCestino.TabIndex = 5;
            this.btnCestino.Text = "Cestino";
            this.btnCestino.UseVisualStyleBackColor = true;
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(3, 4);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(75, 23);
            this.btnStampa.TabIndex = 4;
            this.btnStampa.Text = "Stampa Dati";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // txtUtenteSel
            // 
            this.txtUtenteSel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtenteSel.Name = "txtUtenteSel";
            this.txtUtenteSel.ReadOnly = true;
            this.txtUtenteSel.Size = new System.Drawing.Size(200, 26);
            this.txtUtenteSel.Text = "Utente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // RichiestetoolStripMenuItem1
            // 
            this.RichiestetoolStripMenuItem1.Name = "RichiestetoolStripMenuItem1";
            this.RichiestetoolStripMenuItem1.Size = new System.Drawing.Size(260, 22);
            this.RichiestetoolStripMenuItem1.Text = "Info Richieste";
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.btnNegaTutte);
            this.panel3.Controls.Add(this.btnApprovaTutte);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 34);
            this.panel3.TabIndex = 2;
            // 
            // btnApprovaTutte
            // 
            this.btnApprovaTutte.Location = new System.Drawing.Point(7, 6);
            this.btnApprovaTutte.Name = "btnApprovaTutte";
            this.btnApprovaTutte.Size = new System.Drawing.Size(88, 23);
            this.btnApprovaTutte.TabIndex = 0;
            this.btnApprovaTutte.Text = "Approva Tutte";
            this.btnApprovaTutte.UseVisualStyleBackColor = true;
            // 
            // btnNegaTutte
            // 
            this.btnNegaTutte.Location = new System.Drawing.Point(99, 6);
            this.btnNegaTutte.Name = "btnNegaTutte";
            this.btnNegaTutte.Size = new System.Drawing.Size(75, 23);
            this.btnNegaTutte.TabIndex = 1;
            this.btnNegaTutte.Text = "Nega Tutte";
            this.btnNegaTutte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1194, 808);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Alterazione Stato RIchieste Perrsonale";
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.contextMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grigliaRichieste;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.Label lblRicerca;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem approvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rifiutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attesaToolStripMenuItem;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnCestino;
        private System.Windows.Forms.Button btnVARIAZIONI_USERLIST;
        private System.Windows.Forms.Button btnCaricaVariazioni;
        private System.Windows.Forms.ToolStripTextBox txtUtenteSel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem RichiestetoolStripMenuItem1;
        private System.Windows.Forms.Button btnNegaTutte;
        private System.Windows.Forms.Button btnApprovaTutte;
    }
}

