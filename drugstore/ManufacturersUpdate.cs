using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ManufacturersUpdate : Form
    {
        public ManufacturersUpdate()
        {
            InitializeComponent();
        }

        private void ManufacturersUpdate_Load(object sender, EventArgs e)
        {
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Manufacturers, comboBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManufacturersEntity selected = (ManufacturersEntity)comboBox3.SelectedItem;
            ManufacturersEntity entity = new ManufacturersEntity();
            entity.ID = selected.ID;
            entity.Address = textBoxAddress.Text;
            entity.CheckingAccount = textBoxCheckingAccount.Text;
            entity.Phone = textBoxPhone.Text;
            entity.Title = textBoxTitle.Text;
            ApplicationLogic.Update(ApplicationLogic.Tables.Manufacturers, entity);
        
        }
    } 
}
