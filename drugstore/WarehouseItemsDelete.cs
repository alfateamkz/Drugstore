using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class WarehouseItemsDelete : Form
    {
        public WarehouseItemsDelete()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Warehouse, comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarehouseItemsEntity selectedItem = (WarehouseItemsEntity)comboBox1.SelectedItem;
            ApplicationLogic.Delete(ApplicationLogic.Tables.Warehouse, selectedItem.ID);
        }
    }
}
