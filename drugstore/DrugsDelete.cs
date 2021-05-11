using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class DrugsDelete : Form
    {
        public DrugsDelete()
        {
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Drugs, drugsCB);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrugsEntity selectedDrug = (DrugsEntity)drugsCB.SelectedItem;
            ApplicationLogic.Delete(ApplicationLogic.Tables.Drugs, selectedDrug.ID);
        }
    }
}
