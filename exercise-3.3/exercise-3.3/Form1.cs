using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtBoxA.Text);
            int B =int.Parse(txtBoxB.Text);
            int C = int.Parse(txtBoxC.Text);
            int medel = (A + B + C) / 3;
            int sum = A + B + C;
            lblMedel.Text = medel.ToString();
            lblSumma.Text = sum.ToString();
        }
    }
}
