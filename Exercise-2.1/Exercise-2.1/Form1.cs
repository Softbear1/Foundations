using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Röd knappen
        private void button1_Click(object sender, EventArgs e)
        {

            BackColor = Color.Red;
        }
        //Blå knappen
        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
