namespace exercise_3._5
{
    partial class Form1
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
            this.btnKor = new System.Windows.Forms.Button();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKor
            // 
            this.btnKor.Location = new System.Drawing.Point(409, 260);
            this.btnKor.Name = "btnKor";
            this.btnKor.Size = new System.Drawing.Size(75, 23);
            this.btnKor.TabIndex = 0;
            this.btnKor.Text = "Kör";
            this.btnKor.UseVisualStyleBackColor = true;
            this.btnKor.Click += new System.EventHandler(this.btnKor_Click);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(335, 88);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(41, 15);
            this.lblNamn.TabIndex = 1;
            this.lblNamn.Text = "Namn";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(335, 134);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(62, 15);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Födelseår";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(406, 208);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 15);
            this.lblSvar.TabIndex = 3;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(409, 134);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 20);
            this.tbxYear.TabIndex = 4;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(409, 88);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnKor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKor;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxNamn;
    }
}

