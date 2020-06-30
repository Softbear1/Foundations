using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtBox1.Text);
            double secoundNumber = double.Parse(txtBox2.Text);
            double result = firstNumber + secoundNumber;
            lblResult.Text = result.ToString();
        }
    }
}
