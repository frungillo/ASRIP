namespace ASRIP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtUTENTE_AD = new System.Windows.Forms.TextBox();
            this.txtSTAZIONE = new System.Windows.Forms.TextBox();
            this.chkAMBITO = new System.Windows.Forms.CheckBox();
            this.clbCENTRI_COSTO = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnREGISTRA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMONITOR = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPULISCI = new System.Windows.Forms.Button();
            this.btnCancellaRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUTENTE_AD
            // 
            this.txtUTENTE_AD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUTENTE_AD.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUTENTE_AD.Location = new System.Drawing.Point(13, 59);
            this.txtUTENTE_AD.Name = "txtUTENTE_AD";
            this.txtUTENTE_AD.Size = new System.Drawing.Size(214, 23);
            this.txtUTENTE_AD.TabIndex = 0;
            this.txtUTENTE_AD.Validated += new System.EventHandler(this.txtUTENTE_AD_Validated);
            // 
            // txtSTAZIONE
            // 
            this.txtSTAZIONE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSTAZIONE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTAZIONE.Location = new System.Drawing.Point(241, 59);
            this.txtSTAZIONE.Name = "txtSTAZIONE";
            this.txtSTAZIONE.Size = new System.Drawing.Size(214, 23);
            this.txtSTAZIONE.TabIndex = 1;
            // 
            // chkAMBITO
            // 
            this.chkAMBITO.AutoSize = true;
            this.chkAMBITO.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAMBITO.Location = new System.Drawing.Point(16, 136);
            this.chkAMBITO.Name = "chkAMBITO";
            this.chkAMBITO.Size = new System.Drawing.Size(15, 14);
            this.chkAMBITO.TabIndex = 2;
            this.chkAMBITO.UseVisualStyleBackColor = true;
            // 
            // clbCENTRI_COSTO
            // 
            this.clbCENTRI_COSTO.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCENTRI_COSTO.FormattingEnabled = true;
            this.clbCENTRI_COSTO.Items.AddRange(new object[] {
            "CAosta",
            "CAosta2",
            "CarloIII",
            "Garittone",
            "Posillipo",
            "SGiovann",
            "StPolare",
            "VPuglie",
            "VPuglie2"});
            this.clbCENTRI_COSTO.Location = new System.Drawing.Point(335, 136);
            this.clbCENTRI_COSTO.Name = "clbCENTRI_COSTO";
            this.clbCENTRI_COSTO.Size = new System.Drawing.Size(120, 166);
            this.clbCENTRI_COSTO.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "UTENTE_AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "STAZIONE (asterisco per tutte)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CENTRI_COSTO";
            // 
            // btnREGISTRA
            // 
            this.btnREGISTRA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREGISTRA.Location = new System.Drawing.Point(16, 266);
            this.btnREGISTRA.Name = "btnREGISTRA";
            this.btnREGISTRA.Size = new System.Drawing.Size(253, 36);
            this.btnREGISTRA.TabIndex = 7;
            this.btnREGISTRA.Text = "Registra";
            this.btnREGISTRA.UseVisualStyleBackColor = true;
            this.btnREGISTRA.Click += new System.EventHandler(this.btnREGISTRA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Spunta per abilitare alla scrittura";
            // 
            // lblMONITOR
            // 
            this.lblMONITOR.AutoSize = true;
            this.lblMONITOR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMONITOR.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMONITOR.Location = new System.Drawing.Point(94, 317);
            this.lblMONITOR.Name = "lblMONITOR";
            this.lblMONITOR.Size = new System.Drawing.Size(290, 22);
            this.lblMONITOR.TabIndex = 10;
            this.lblMONITOR.Text = "Aggiornamento db effettuato.";
            this.lblMONITOR.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "La ricerca può essere effettuata solo per UTENTE_AD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(15, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 2);
            this.panel1.TabIndex = 12;
            // 
            // btnPULISCI
            // 
            this.btnPULISCI.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPULISCI.Location = new System.Drawing.Point(16, 224);
            this.btnPULISCI.Name = "btnPULISCI";
            this.btnPULISCI.Size = new System.Drawing.Size(253, 36);
            this.btnPULISCI.TabIndex = 13;
            this.btnPULISCI.Text = "Pulisci form";
            this.btnPULISCI.UseVisualStyleBackColor = true;
            this.btnPULISCI.Click += new System.EventHandler(this.btnPULISCI_Click);
            // 
            // btnCancellaRecord
            // 
            this.btnCancellaRecord.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaRecord.Location = new System.Drawing.Point(16, 182);
            this.btnCancellaRecord.Name = "btnCancellaRecord";
            this.btnCancellaRecord.Size = new System.Drawing.Size(253, 36);
            this.btnCancellaRecord.TabIndex = 14;
            this.btnCancellaRecord.Text = "Cancella record";
            this.btnCancellaRecord.UseVisualStyleBackColor = true;
            this.btnCancellaRecord.Click += new System.EventHandler(this.btnCancellaRecord_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 346);
            this.Controls.Add(this.btnCancellaRecord);
            this.Controls.Add(this.btnPULISCI);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMONITOR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnREGISTRA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbCENTRI_COSTO);
            this.Controls.Add(this.chkAMBITO);
            this.Controls.Add(this.txtSTAZIONE);
            this.Controls.Add(this.txtUTENTE_AD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 385);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VARIAZIONI USER LIST";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUTENTE_AD;
        private System.Windows.Forms.TextBox txtSTAZIONE;
        private System.Windows.Forms.CheckBox chkAMBITO;
        private System.Windows.Forms.CheckedListBox clbCENTRI_COSTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnREGISTRA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMONITOR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPULISCI;
        private System.Windows.Forms.Button btnCancellaRecord;
    }
}