using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class Measures : Form
    {
        public Measures()
        {
            InitializeComponent();
        }

        private void Measures_Load(object sender, EventArgs e)
        {
            ApplicationLogic.LoadTable(ApplicationLogic.Tables.Measures, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Добавить")
            {
                MeasuresAdd f = new MeasuresAdd(); f.ShowDialog();
            }
            else if (e.ClickedItem.Text == "Удалить")
            {
                MeasuresDelete f = new MeasuresDelete(); f.ShowDialog();
            }
            else if (e.ClickedItem.Text == "Изменить")
            {
                MeasuresUpdate f = new MeasuresUpdate(); f.ShowDialog();
            }
        }
    }
}
