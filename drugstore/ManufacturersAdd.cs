using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class ManufacturersAdd : Form
    {
        public ManufacturersAdd()
        {
            InitializeComponent();
        }
        ManufacturersEntity entity;
        private void button1_Click(object sender, EventArgs e)
        {
            entity = new ManufacturersEntity();
            entity.Address = textBoxAddress.Text;
            entity.CheckingAccount = textBoxCheckingAccount.Text;
            entity.Phone = textBoxPhone.Text;
            entity.Title = textBoxTitle.Text;
            ApplicationLogic.Insert(ApplicationLogic.Tables.Manufacturers, entity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
