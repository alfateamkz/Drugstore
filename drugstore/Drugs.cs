using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class Drugs : Form
    {
        public Drugs()
        {
            InitializeComponent();
            ApplicationLogic.LoadTable(ApplicationLogic.Tables.Drugs, dataGridView1);
        }
        public Drugs(ApplicationLogic.FilterDrugsCategory category)
        {
            InitializeComponent();
            switch (category)
            {
                case ApplicationLogic.FilterDrugsCategory.ByDateRange:
                    ApplicationLogic.FilterDrugs(category, dataGridView1, ApplicationLogic.dateStart,ApplicationLogic.dateEnd);
                    break;
                case ApplicationLogic.FilterDrugsCategory.ByDay:
                    ApplicationLogic.FilterDrugs(category, dataGridView1, ApplicationLogic.dateStart);
                    break;
                case ApplicationLogic.FilterDrugsCategory.ByManufacturer:
                    ApplicationLogic.FilterDrugs(category, dataGridView1, ApplicationLogic.intParameter);
                    break;
                case ApplicationLogic.FilterDrugsCategory.BySum:
                    ApplicationLogic.FilterDrugs(category, dataGridView1, ApplicationLogic.intParameter);
                    break;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           Form f = null;
            switch (e.ClickedItem.Text)
            {
                
                case "Добавить":
                    f = new DrugsAdd(); 
                    break;
                case "Удалить":
                    f= new DrugsDelete(); 
                    break;
                case "Изменить":
                    f = new DrugsUpdate(); 
                    break;
                case "По дате":
                    f = new DrugsFilters.DrugsFilterByDate(); 
                    break;
                case "За период":
                    f = new DrugsFilters.DrugsFilterByDateRange();
                    break;
                case "По производителю":
                    f = new DrugsFilters.DrugsFilterByManufacturer();
                    break;
                case "По сумме свыше":
                    f = new DrugsFilters.DrugsFilterBySum();
                    break;
                case "Кол-во упаковок":
                    f = new DrugsFilters.DrugsFilterQuantity();
                    break;
                case "Отчёт Excel":
                    f = new DrugsExcel();
                    break;
            }
            f.ShowDialog();
            this.Close();
        }
    }
}
