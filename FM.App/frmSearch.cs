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
    public partial class frmSearch : Form
    {
        CitizenBL _Adapter = null;
        public frmSearch()
        {
            InitializeComponent();
            Program.SetDefaultLanguage();
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            _Adapter = new CitizenBL();
            var CitizenList = _Adapter.Search(_txtBoxFirstName.Text, _txtBoxFatherName.Text, _txtBoxLastName.Text);
            this.citizenBindingSource.DataSource = CitizenList;
        }

        private void _dgSearchResult_DoubleClick(object sender, EventArgs e)
        {
            if (_dgSearchResult.Rows.Count > 0)
            {
                Citizen p = citizenBindingSource.Current as Citizen;
                MessageBox.Show(p.FullName);
            }
        }
    }
}
