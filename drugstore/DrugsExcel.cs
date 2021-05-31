using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class DrugsExcel : Form
    {
        public DrugsExcel(DataGridView data)
        {
            InitializeComponent();
            dataGridView = data;
        }
        DataGridView dataGridView;
        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationLogic.ExcelOutput(ApplicationLogic.ExcelOperation.DrugsRowsAmount,dataGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationLogic.ExcelOutput(ApplicationLogic.ExcelOperation.Union, dataGridView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplicationLogic.ExcelOutput(ApplicationLogic.ExcelOperation.GroupBy, dataGridView);
        }
    }
}
