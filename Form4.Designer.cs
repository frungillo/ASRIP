namespace ASRIP
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVAI = new System.Windows.Forms.Button();
            this.dtpDA = new System.Windows.Forms.DateTimePicker();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Da data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "A data";
            // 
            // btnVAI
            // 
            this.btnVAI.BackColor = System.Drawing.Color.LightGreen;
            this.btnVAI.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAI.Location = new System.Drawing.Point(17, 80);
            this.btnVAI.Name = "btnVAI";
            this.btnVAI.Size = new System.Drawing.Size(434, 70);
            this.btnVAI.TabIndex = 4;
            this.btnVAI.Text = "Vai";
            this.btnVAI.UseVisualStyleBackColor = false;
            this.btnVAI.Click += new System.EventHandler(this.btnVAI_Click);
            // 
            // dtpDA
            // 
            this.dtpDA.Location = new System.Drawing.Point(17, 35);
            this.dtpDA.Name = "dtpDA";
            this.dtpDA.Size = new System.Drawing.Size(200, 20);
            this.dtpDA.TabIndex = 5;
            // 
            // dtpA
            // 
            this.dtpA.Location = new System.Drawing.Point(251, 35);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(200, 20);
            this.dtpA.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 162);
            this.Controls.Add(this.dtpA);
            this.Controls.Add(this.dtpDA);
            this.Controls.Add(this.btnVAI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(478, 201);
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periodo di riferimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVAI;
        private System.Windows.Forms.DateTimePicker dtpDA;
        private System.Windows.Forms.DateTimePicker dtpA;
    }
}