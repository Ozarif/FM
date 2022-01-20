using FM.BusinessLogic;
using FM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM.App
{
    public partial class Form1 : Form
    {
        ProvinceBL t = new ProvinceBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var tm = t.GetAll();

            this.provinceBindingSource.DataSource = tm;

        }

        private void provinceBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            provinceBindingSource.EndEdit();
            Province p = provinceBindingSource.Current as Province;
            t.Save(p);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {

                Province p = provinceBindingSource.Current as Province;

                MessageBox.Show(p.Id.ToString());
            }
        }
    }
}
