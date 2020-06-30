using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräknaKvadraten_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(txtBoxInput.Text);
            int kvadrat = tal * tal;
            string result = kvadrat.ToString();
            btnBeräknaKvadraten.Text = result;

        }
    }
}
