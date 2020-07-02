using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKor_Click(object sender, EventArgs e)
        {
            string engelska = tbxEngelska.Text;
            string svenska = tbxSvenska.Text;
            string svar = engelska + " betyder " + svenska + " på svenska.";
            lblSvar.Text = svar;
        }
    }
}
