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
    public partial class frmHomeType : BaseForm
    {
        private bool _bHasChanges = false;
        private HomeTypeBL _homeTypeBL;
       // private BindingSource _bindingSource = new BindingSource();
        public frmHomeType() :base()
        {
            InitializeComponent();
            homeTypeBindingSource.RaiseListChangedEvents = true;
            LoadData();
        }

        private void BindingFields()
        {
            _txtBoxId.DataBindings.Add("Text", homeTypeBindingSource, "Id");
        }

        private void LoadData()
        {
            

            _homeTypeBL = new HomeTypeBL();
            var homeTypes = _homeTypeBL.GetAll();
            homeTypeBindingSource.DataSource = homeTypes;
            this._bnGeneral.BindingSource = homeTypeBindingSource;
 //           BindingFields();
            if (homeTypeBindingSource.Count == 0)
                homeTypeBindingSource.AddNew();
        }


        private bool HasChanges()
        {

            return _bHasChanges;

            //bool Result,IsNew,IsModified = false;

            //homeTypeBindingSource.EndEdit();

            //IsNew = ((DataRowView)homeTypeBindingSource.Current).IsNew;
            //IsModified = ((DataRowView)homeTypeBindingSource.CurrencyManager.Current).Row.HasVersion(DataRowVersion.Proposed);
          


            //Result = IsNew || IsModified;


            //return Result;
        }


        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("هل تريد حفظ التغيرات؟", "حفظ التغيرات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SaveChanges();
                }
         
        }
        private bool SaveChanges()
        {
            bool bReturnValue = false;

            try
            {
                    homeTypeBindingSource.EndEdit();
                    HomeType homeType = homeTypeBindingSource.Current as HomeType;
                    bReturnValue = _homeTypeBL.Save(homeType);
            }
            catch (Exception ex)
            {

                ShowError(ex.Message);
            }

            return bReturnValue;
        }
        private void _tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeTypeBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
                _bHasChanges = true;
        }
    }
}
