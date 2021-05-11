using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Drugstore.DrugsFilters
{
    public partial class DrugsFilterByDate : Form
    {
        public DrugsFilterByDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); ApplicationLogic.dateStart = dateTimePicker1.Value.Date;
            Drugs f = new Drugs(ApplicationLogic.FilterDrugsCategory.ByDay); f.Show();
          
        }
    }
}
