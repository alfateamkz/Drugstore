using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class MeasuresAdd : Form
    {
        public MeasuresAdd()
        {
            InitializeComponent();
        }

        private void MeasuresAdd_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeasuresEntity entity = new MeasuresEntity { Title = textBox1.Text };
            ApplicationLogic.Insert(ApplicationLogic.Tables.Measures, entity);
        }
    }
}
