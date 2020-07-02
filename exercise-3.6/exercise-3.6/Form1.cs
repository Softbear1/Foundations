using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKor_Click(object sender, EventArgs e)
        {
            string förnamn = tbxFörnamn.Text;
            string efternamn = tbxEfternamn.Text;
            char första = förnamn[0];
            char andra = efternamn[0];
            string svar = förnamn + " " + efternamn + " har initialerna " + första + ". " + andra + ".";
            lblSvar.Text = svar;
        }
    }
}
