using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore.DrugsFilters
{
    public partial class DrugsFilterByManufacturer : Form
    {
        public DrugsFilterByManufacturer()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Manufacturers, ManufacturersCB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManufacturersEntity selected = (ManufacturersEntity)ManufacturersCB.SelectedItem;
            ApplicationLogic.intParameter = selected.ID;
            Drugs f = new Drugs(ApplicationLogic.FilterDrugsCategory.ByManufacturer);
        }
    }
}
