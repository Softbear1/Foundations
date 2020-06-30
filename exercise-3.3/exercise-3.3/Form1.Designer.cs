namespace exercise_3._3
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblMedel = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(308, 164);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(51, 21);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Tal A";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(427, 158);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 22);
            this.txtBoxA.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(427, 388);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(427, 202);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 22);
            this.txtBoxB.TabIndex = 4;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(308, 208);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(51, 21);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Tal B";
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(427, 248);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(100, 22);
            this.txtBoxC.TabIndex = 6;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(308, 254);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(51, 21);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Tal C";
            // 
            // lblMedel
            // 
            this.lblMedel.AutoSize = true;
            this.lblMedel.Location = new System.Drawing.Point(424, 338);
            this.lblMedel.Name = "lblMedel";
            this.lblMedel.Size = new System.Drawing.Size(103, 21);
            this.lblMedel.TabIndex = 8;
            this.lblMedel.Text = "Medelvärde";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(424, 292);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(69, 21);
            this.lblSumma.TabIndex = 7;
            this.lblSumma.Text = "Summa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 514);
            this.Controls.Add(this.lblMedel);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.txtBoxC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblMedel;
        private System.Windows.Forms.Label lblSumma;
    }
}

