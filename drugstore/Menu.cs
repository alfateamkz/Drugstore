using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drugs f = new Drugs(); f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Warehouse f = new Warehouse(); f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Manufacturers f = new Manufacturers(); f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Documents f = new Documents(); f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Measures f = new Measures(); f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Logs f = new Logs(); f.Show();
        }
    }
}
