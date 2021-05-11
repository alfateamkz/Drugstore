using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class DrugsUpdate : Form
    {
        public DrugsUpdate()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Measures, measuresCB);
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Manufacturers, ManufacturersCB);
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Drugs, drugsCB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManufacturersEntity selectedManufacturer = (ManufacturersEntity)ManufacturersCB.SelectedItem;
            MeasuresEntity selectedMeasure = (MeasuresEntity)measuresCB.SelectedItem;
            DrugsEntity selectedDrug = (DrugsEntity)drugsCB.SelectedItem;
            DrugsEntity entity = new DrugsEntity
            {
                ID = selectedDrug.ID,
                ManufacturerID = selectedManufacturer.ID,
                MeasureID = selectedMeasure.ID,
                ExpTerm = textBoxExpTerm.Text,
                Purpose = textBoxPurpose.Text,
                Quantity = Convert.ToInt32(textBoxQuantity.Text),
                Price = Convert.ToInt32(textBoxPrice.Text),
                Indications = textBoxIndications.Text,
                Title = textBoxTitle.Text
            };
            ApplicationLogic.Update(ApplicationLogic.Tables.Drugs, entity);
        }
    }
}
