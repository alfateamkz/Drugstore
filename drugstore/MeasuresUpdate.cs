using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class MeasuresUpdate : Form
    {
        public MeasuresUpdate()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Measures, comboBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeasuresEntity entity = (MeasuresEntity)comboBox3.SelectedItem;
            entity.Title = textBox1.Text;
            ApplicationLogic.Update(ApplicationLogic.Tables.Measures, entity);
        }
    }
}
