using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore.DrugsFilters
{
    public partial class DrugsFilterQuantity : Form
    {
        public DrugsFilterQuantity()
        {
            InitializeComponent();
            ApplicationLogic.ShowComboBoxItems(ApplicationLogic.Tables.Drugs, drugsCB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrugsEntity selected = (DrugsEntity)drugsCB.SelectedItem;
            if (selected != null)
            {
                ApplicationLogic.FilterDrugs(ApplicationLogic.FilterDrugsCategory.DrugQuantity, selected.ID);
            }
        }
    }
}
