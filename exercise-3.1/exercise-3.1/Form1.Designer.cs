namespace exercise_3._1
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
            this.btnBeräknaKvadraten = new System.Windows.Forms.Button();
            this.lblTal = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBeräknaKvadraten
            // 
            this.btnBeräknaKvadraten.Location = new System.Drawing.Point(353, 314);
            this.btnBeräknaKvadraten.Name = "btnBeräknaKvadraten";
            this.btnBeräknaKvadraten.Size = new System.Drawing.Size(75, 23);
            this.btnBeräknaKvadraten.TabIndex = 0;
            this.btnBeräknaKvadraten.Text = "Beräkna kvadraten";
            this.btnBeräknaKvadraten.UseVisualStyleBackColor = true;
            this.btnBeräknaKvadraten.Click += new System.EventHandler(this.btnBeräknaKvadraten_Click);
            // 
            // lblTal
            // 
            this.lblTal.AutoSize = true;
            this.lblTal.Location = new System.Drawing.Point(307, 127);
            this.lblTal.Name = "lblTal";
            this.lblTal.Size = new System.Drawing.Size(28, 17);
            this.lblTal.TabIndex = 1;
            this.lblTal.Text = "Tal";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(368, 233);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(60, 17);
            this.lblResultat.TabIndex = 2;
            this.lblResultat.Text = "Resultat";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(372, 124);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 22);
            this.txtBoxInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblTal);
            this.Controls.Add(this.btnBeräknaKvadraten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeräknaKvadraten;
        private System.Windows.Forms.Label lblTal;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox txtBoxInput;
    }
}

