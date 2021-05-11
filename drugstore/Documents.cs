using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class Documents : Form
    {
        public Documents()
        {
            InitializeComponent();
            ApplicationLogic.LoadTable(ApplicationLogic.Tables.Documents,  dataGridView1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }
    }
}
