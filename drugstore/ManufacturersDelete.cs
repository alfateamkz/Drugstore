using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ManufacturersDelete : Form
    {
        public ManufacturersDelete()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Manufacturers, comboBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManufacturersEntity entity = (ManufacturersEntity)comboBox3.SelectedItem;
            ApplicationLogic.Delete(ApplicationLogic.Tables.Manufacturers, entity.ID);
        }
    }
}
