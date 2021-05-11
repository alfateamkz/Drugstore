using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class WarehouseItemsUpdate : Form
    {
        public WarehouseItemsUpdate()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Drugs, DrugCB);
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Warehouse, ItemCB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrugsEntity selectedDrug = (DrugsEntity)DrugCB.SelectedItem;
            WarehouseItemsEntity selectedItem = (WarehouseItemsEntity)ItemCB.SelectedItem;
            WarehouseItemsEntity entity = new WarehouseItemsEntity
            {
                Quantity = Convert.ToInt32(textBox1.Text),
                DrugID = selectedDrug.ID,
                ID = selectedItem.ID
            };
            ApplicationLogic.Update(ApplicationLogic.Tables.Warehouse, entity);
        }
    }
}
