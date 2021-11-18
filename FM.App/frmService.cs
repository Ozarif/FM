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
    public partial class frmService : Form
    {
        private SD.FormMethodE _MethodE;
        private Citizen _citizen;
        private ServiceInfo _serviceInfo;
        public frmService(SD.FormMethodE MethodE, Citizen citizen)
        {
            InitializeComponent();
            _MethodE = MethodE;
            _citizen = citizen;
            SetObjects();
        }
        private void SetObjects()
        {
            try
            {
                // check if form method is new to go to addnew
                _ssGeneral.Text = string.Empty;
                _txtBoxCitizenNumber.Text = _citizen.Id.ToString();
                _txtBoxCitizenName.Text = _citizen.FullName;

                SetServicesList();
                SetResultsList();
            }
            catch (Exception ex)
            {
                _ssGeneral.Text = ex.Message;
            }
        }
        private void SetServicesList()
        { }
        private void SetResultsList()
        { }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _ssGeneral.Text = string.Empty;

            }
            catch (Exception ex)
            {
                _ssGeneral.Text = ex.Message;
            }
        }
    }
}
