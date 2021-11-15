
namespace ASRIP
{
    partial class frmInfoRichieste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grigliaRichieste = new System.Windows.Forms.DataGridView();
            this.ttNote = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).BeginInit();
            this.SuspendLayout();
            // 
            // grigliaRichieste
            // 
            this.grigliaRichieste.AllowUserToAddRows = false;
            this.grigliaRichieste.AllowUserToDeleteRows = false;
            this.grigliaRichieste.AllowUserToResizeRows = false;
            this.grigliaRichieste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grigliaRichieste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grigliaRichieste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaRichieste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grigliaRichieste.Location = new System.Drawing.Point(0, 0);
            this.grigliaRichieste.MultiSelect = false;
            this.grigliaRichieste.Name = "grigliaRichieste";
            this.grigliaRichieste.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grigliaRichieste.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grigliaRichieste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grigliaRichieste.Size = new System.Drawing.Size(318, 450);
            this.grigliaRichieste.TabIndex = 0;
            // 
            // ttNote
            // 
            this.ttNote.AutomaticDelay = 250;
            this.ttNote.AutoPopDelay = 5000;
            this.ttNote.InitialDelay = 250;
            this.ttNote.IsBalloon = true;
            this.ttNote.ReshowDelay = 50;
            this.ttNote.ToolTipTitle = "Info Richiesta";
            // 
            // frmInfoRichieste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.grigliaRichieste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInfoRichieste";
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRichieste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grigliaRichieste;
        private System.Windows.Forms.ToolTip ttNote;
    }
}