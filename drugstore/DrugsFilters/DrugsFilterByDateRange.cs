using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore.DrugsFilters
{
    public partial class DrugsFilterByDateRange : Form
    {
        public DrugsFilterByDateRange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
            ApplicationLogic.dateStart = dateTimePicker1.Value;
            ApplicationLogic.dateEnd = dateTimePicker2.Value;
            Drugs f = new Drugs(ApplicationLogic.FilterDrugsCategory.ByDateRange); f.Show();
        }
    }
}
