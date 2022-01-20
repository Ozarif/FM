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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        #region MenuItems

        private void _tsmiExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void _tsmiCitizensDetails_Click(object sender, EventArgs e)
        {
            OpenForm(new frmCitizenDetailsInfo(), this);
        }

        private void _tsmiSetupGeneralHomeTypes_Click(object sender, EventArgs e)
        {
            OpenForm(new frmHomeType(), this);
        }

        private void _tsmiSetupGeneralEducationalLevels_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEducationalLevel(), this);
        }

        private void _tsmiSetupGeneralBusinessSectors_Click(object sender, EventArgs e)
        {
            OpenForm(new frmBusinessSector(), this);
        }

        private void _tsmiSetupPartyDivisions_Click(object sender, EventArgs e)
        {
            OpenForm(new frmPartyDivision(), this);
        }

        private void _tsmiSetupPartyPositions_Click(object sender, EventArgs e)
        {
            OpenForm(new frmPartyPosition(), this);
        }

        private void _tsmiSetupPartyElectionRoles_Click(object sender, EventArgs e)
        {
            OpenForm(new frmElectionRole(), this);
        }

        private void _tsmiSetupServicesTypes_Click(object sender, EventArgs e)
        {
            OpenForm(new frmServiceType(), this);
        }

        private void _tsmiSetupServicesResults_Click(object sender, EventArgs e)
        {
            OpenForm(new frmResultType(), this);
        }

        private void _tsmiCitizensMain_Click(object sender, EventArgs e)
        {
            OpenForm(new frmSearch(), this);
        }

        private void _tsmiCitizensServices_Click(object sender, EventArgs e)
        {
            OpenForm(new frmService(SD.FormMethodE.NEW, null), this);
        }

        #endregion

        #region Form Actions

        private void _frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                _tssLblDescription.Text = ActiveMdiChild.Text;
            else
                _tssLblDescription.Text = "";
        }
        private static bool IsFormOpen(Form oForm, Form frmParent)
        {
            bool bReturnValue = false;
            foreach (Form oOpenForm in frmParent.MdiChildren)
            {
                if (oForm.Name == oOpenForm.Name)
                {
                    bReturnValue = true;
                    oOpenForm.Focus();
                }
            }
            return bReturnValue;
        }
        public static void OpenForm(Form oForm, Form frmParent)
        {
            //  FM.Program.SetDefaultLanguage();
            if (!IsFormOpen(oForm, frmParent))
            {
                oForm.MdiParent = frmParent;
                oForm.Show();
            }
        }

        private void _frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج من البرنامج",
            "الخروج من البرنامج",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Stop,
            MessageBoxDefaultButton.Button2,
            MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                if (this.ActiveMdiChild != null)
                {
                    MessageBox.Show("يجب إقفال الشاشات المفتوحة قبل الخروج",
                                "تحذير",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign);
                    e.Cancel = true;
                }
                InputLanguage.CurrentInputLanguage = Program.OriginalInputLanguage;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
