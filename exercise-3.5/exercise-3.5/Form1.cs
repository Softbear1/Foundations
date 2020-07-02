using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKor_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            int födelseår = int.Parse(tbxYear.Text);
            int år = DateTime.Now.Year;
            int antalÅr = (födelseår - år) * -1 ;
            int birthYear = födelseår + 50;

            string svar = birthYear + " fyller " + namn +  " 50 år.";
            lblSvar.Text = svar;

        }
    }
}
