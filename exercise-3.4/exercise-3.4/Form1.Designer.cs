namespace exercise_3._4
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
            this.lblEngelska = new System.Windows.Forms.Label();
            this.lblSvenska = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxSvenska = new System.Windows.Forms.TextBox();
            this.tbxEngelska = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKor
            // 
            this.btnKor.Location = new System.Drawing.Point(435, 266);
            this.btnKor.Name = "btnKor";
            this.btnKor.Size = new System.Drawing.Size(75, 23);
            this.btnKor.TabIndex = 0;
            this.btnKor.Text = "Kör";
            this.btnKor.UseVisualStyleBackColor = true;
            this.btnKor.Click += new System.EventHandler(this.btnKor_Click);
            // 
            // lblEngelska
            // 
            this.lblEngelska.AutoSize = true;
            this.lblEngelska.Location = new System.Drawing.Point(348, 100);
            this.lblEngelska.Name = "lblEngelska";
            this.lblEngelska.Size = new System.Drawing.Size(58, 15);
            this.lblEngelska.TabIndex = 1;
            this.lblEngelska.Text = "Engelska";
            // 
            // lblSvenska
            // 
            this.lblSvenska.AutoSize = true;
            this.lblSvenska.Location = new System.Drawing.Point(348, 136);
            this.lblSvenska.Name = "lblSvenska";
            this.lblSvenska.Size = new System.Drawing.Size(53, 15);
            this.lblSvenska.TabIndex = 2;
            this.lblSvenska.Text = "Svenska";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(432, 212);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 15);
            this.lblSvar.TabIndex = 3;
            // 
            // tbxSvenska
            // 
            this.tbxSvenska.Location = new System.Drawing.Point(435, 136);
            this.tbxSvenska.Name = "tbxSvenska";
            this.tbxSvenska.Size = new System.Drawing.Size(100, 20);
            this.tbxSvenska.TabIndex = 4;
            // 
            // tbxEngelska
            // 
            this.tbxEngelska.Location = new System.Drawing.Point(435, 100);
            this.tbxEngelska.Name = "tbxEngelska";
            this.tbxEngelska.Size = new System.Drawing.Size(100, 20);
            this.tbxEngelska.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxEngelska);
            this.Controls.Add(this.tbxSvenska);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblSvenska);
            this.Controls.Add(this.lblEngelska);
            this.Controls.Add(this.btnKor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKor;
        private System.Windows.Forms.Label lblEngelska;
        private System.Windows.Forms.Label lblSvenska;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxSvenska;
        private System.Windows.Forms.TextBox tbxEngelska;
    }
}

