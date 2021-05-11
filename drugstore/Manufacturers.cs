using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class Manufacturers : Form
    {
        public Manufacturers()
        {
            InitializeComponent();
        }

        private void Manufacturers_Load(object sender, EventArgs e)
        {
         ApplicationLogic.LoadTable(ApplicationLogic.Tables.Manufacturers,dataGridView1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Добавить")
            {
                ManufacturersAdd f = new ManufacturersAdd(); f.ShowDialog();
            }
            else if (e.ClickedItem.Text == "Удалить")
            {
                ManufacturersDelete f = new ManufacturersDelete(); f.ShowDialog();
            }
            else if (e.ClickedItem.Text == "Изменить")
            {
                ManufacturersUpdate f = new ManufacturersUpdate(); f.ShowDialog();
            }
        }
    }
}
