﻿namespace ASRIP
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
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.lblRicerca = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rifiutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenu.SuspendLayout();
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
            this.grigliaRichieste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grigliaRichieste.Location = new System.Drawing.Point(3, 40);
            this.grigliaRichieste.MultiSelect = false;
            this.grigliaRichieste.Name = "grigliaRichieste";
            this.grigliaRichieste.ReadOnly = true;
            this.grigliaRichieste.RowHeadersVisible = false;
            this.grigliaRichieste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grigliaRichieste.Size = new System.Drawing.Size(1172, 701);
            this.grigliaRichieste.TabIndex = 0;
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
            this.tableLayoutPanel1.Controls.Add(this.grigliaRichieste, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
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
            this.panel1.Size = new System.Drawing.Size(583, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(592, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 31);
            this.panel2.TabIndex = 1;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approvaToolStripMenuItem,
            this.rifiutaToolStripMenuItem,
            this.attesaToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(120, 70);
            // 
            // approvaToolStripMenuItem
            // 
            this.approvaToolStripMenuItem.Name = "approvaToolStripMenuItem";
            this.approvaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.approvaToolStripMenuItem.Text = "Approva";
            // 
            // rifiutaToolStripMenuItem
            // 
            this.rifiutaToolStripMenuItem.Name = "rifiutaToolStripMenuItem";
            this.rifiutaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rifiutaToolStripMenuItem.Text = "Rifiuta";
            // 
            // attesaToolStripMenuItem
            // 
            this.attesaToolStripMenuItem.Name = "attesaToolStripMenuItem";
            this.attesaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.attesaToolStripMenuItem.Text = "Attesa";
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
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
    }
}

