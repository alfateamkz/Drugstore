using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore.DrugsFilters
{
    public partial class DrugsFilterBySum : Form
    {
        public DrugsFilterBySum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ApplicationLogic.intParameter = Convert.ToInt32(textBox1.Text);
            Drugs f = new Drugs(ApplicationLogic.FilterDrugsCategory.BySum); f.Show();
        }
    }
}
