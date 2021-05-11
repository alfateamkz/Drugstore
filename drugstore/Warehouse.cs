using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            ApplicationLogic.LoadTable(ApplicationLogic.Tables.Warehouse, dataGridView1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Добавить")
            {
                WarehouseItemsAdd f = new WarehouseItemsAdd(); f.ShowDialog();
            }
            else if (e.ClickedItem.Text == "Удалить")
            {
                WarehouseItemsDelete f = new WarehouseItemsDelete(); f.ShowDialog();
            }
            else if (e.ClickedItem.Text == "Изменить")
            {
                WarehouseItemsUpdate f = new WarehouseItemsUpdate(); f.ShowDialog();
            }
        }
    }
}
