using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM.App
{
   public  class BaseForm : Form
    {

        public BaseForm()
        {
            SetApplicationLanguage();
        }

        protected virtual void ShowError(string strMessage)
        {
            MessageBox.Show(strMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected virtual void ShowInfo(string strInfoMessage)
        {
            MessageBox.Show(strInfoMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected virtual void BindingFields() { }

        protected void SetApplicationLanguage()
        {
            Program.SetDefaultLanguage();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ResumeLayout(false);

        }
    }
}
