using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class WarehouseItemsAdd : Form
    {
        public WarehouseItemsAdd()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Drugs, comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrugsEntity selectedDrug = (DrugsEntity)comboBox1.SelectedItem;
            WarehouseItemsEntity entity = new WarehouseItemsEntity
            {
                Quantity = Convert.ToInt32(textBox1.Text),
                DrugID = selectedDrug.ID
            };
            ApplicationLogic.Insert(ApplicationLogic.Tables.Warehouse, entity);
        }
    }
}
