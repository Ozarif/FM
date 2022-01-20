namespace FM.App
{
    partial class frmBusinessSector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusinessSector));
            this._tssLblGeneral = new System.Windows.Forms.ToolStripStatusLabel();
            this._gbProvince = new System.Windows.Forms.GroupBox();
            this._txtBoxDescription = new System.Windows.Forms.TextBox();
            this._lblDescription = new System.Windows.Forms.Label();
            this._txtBoxId = new System.Windows.Forms.TextBox();
            this._lblId = new System.Windows.Forms.Label();
            this._ssGeneral = new System.Windows.Forms.StatusStrip();
            this._bnGeneral = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._tscmbSearch = new System.Windows.Forms.ToolStripComboBox();
            this._tcbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this._gbProvince.SuspendLayout();
            this._ssGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bnGeneral)).BeginInit();
            this._bnGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tssLblGeneral
            // 
            this._tssLblGeneral.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this._tssLblGeneral.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this._tssLblGeneral.Name = "_tssLblGeneral";
            this._tssLblGeneral.Size = new System.Drawing.Size(465, 17);
            this._tssLblGeneral.Spring = true;
            this._tssLblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _gbProvince
            // 
            this._gbProvince.Controls.Add(this._txtBoxDescription);
            this._gbProvince.Controls.Add(this._lblDescription);
            this._gbProvince.Controls.Add(this._txtBoxId);
            this._gbProvince.Controls.Add(this._lblId);
            this._gbProvince.Location = new System.Drawing.Point(12, 28);
            this._gbProvince.Name = "_gbProvince";
            this._gbProvince.Size = new System.Drawing.Size(455, 81);
            this._gbProvince.TabIndex = 7;
            this._gbProvince.TabStop = false;
            // 
            // _txtBoxDescription
            // 
            this._txtBoxDescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxDescription.Location = new System.Drawing.Point(6, 46);
            this._txtBoxDescription.Name = "_txtBoxDescription";
            this._txtBoxDescription.Size = new System.Drawing.Size(354, 20);
            this._txtBoxDescription.TabIndex = 3;
            // 
            // _lblDescription
            // 
            this._lblDescription.AutoSize = true;
            this._lblDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblDescription.Location = new System.Drawing.Point(380, 49);
            this._lblDescription.Name = "_lblDescription";
            this._lblDescription.Size = new System.Drawing.Size(69, 13);
            this._lblDescription.TabIndex = 2;
            this._lblDescription.Text = "اسم القطاع";
            // 
            // _txtBoxId
            // 
            this._txtBoxId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxId.Location = new System.Drawing.Point(252, 13);
            this._txtBoxId.Name = "_txtBoxId";
            this._txtBoxId.ReadOnly = true;
            this._txtBoxId.Size = new System.Drawing.Size(108, 20);
            this._txtBoxId.TabIndex = 1;
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblId.Location = new System.Drawing.Point(411, 16);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(38, 13);
            this._lblId.TabIndex = 0;
            this._lblId.Text = "الرقم ";
            // 
            // _ssGeneral
            // 
            this._ssGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tssLblGeneral});
            this._ssGeneral.Location = new System.Drawing.Point(0, 114);
            this._ssGeneral.Name = "_ssGeneral";
            this._ssGeneral.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._ssGeneral.Size = new System.Drawing.Size(480, 22);
            this._ssGeneral.TabIndex = 8;
            // 
            // _bnGeneral
            // 
            this._bnGeneral.AddNewItem = this.bindingNavigatorAddNewItem;
            this._bnGeneral.CountItem = this.bindingNavigatorCountItem;
            this._bnGeneral.DeleteItem = this.bindingNavigatorDeleteItem;
            this._bnGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this._tscmbSearch,
            this._tcbtnSearch,
            this.toolStripSeparator2,
            this._tsbtnExit});
            this._bnGeneral.Location = new System.Drawing.Point(0, 0);
            this._bnGeneral.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._bnGeneral.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._bnGeneral.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._bnGeneral.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._bnGeneral.Name = "_bnGeneral";
            this._bnGeneral.PositionItem = this.bindingNavigatorPositionItem;
            this._bnGeneral.Size = new System.Drawing.Size(480, 25);
            this._bnGeneral.TabIndex = 9;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "اضافة";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.ToolTipText = "حذف";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "الاول";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "السابق";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.ToolTipText = "التالي";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.ToolTipText = "الاخير";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveItem.Text = "&Save";
            this.bindingNavigatorSaveItem.ToolTipText = "حفظ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _tscmbSearch
            // 
            this._tscmbSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._tscmbSearch.DropDownWidth = 140;
            this._tscmbSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._tscmbSearch.Name = "_tscmbSearch";
            this._tscmbSearch.Size = new System.Drawing.Size(130, 25);
            // 
            // _tcbtnSearch
            // 
            this._tcbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tcbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("_tcbtnSearch.Image")));
            this._tcbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tcbtnSearch.Name = "_tcbtnSearch";
            this._tcbtnSearch.Size = new System.Drawing.Size(23, 22);
            this._tcbtnSearch.Text = "&Search";
            this._tcbtnSearch.ToolTipText = "بحث";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _tsbtnExit
            // 
            this._tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("_tsbtnExit.Image")));
            this._tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbtnExit.Name = "_tsbtnExit";
            this._tsbtnExit.Size = new System.Drawing.Size(23, 22);
            this._tsbtnExit.Text = "toolStripButton1";
            this._tsbtnExit.ToolTipText = "اغلاق";
            // 
            // frmBusinessSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 136);
            this.Controls.Add(this._bnGeneral);
            this.Controls.Add(this._gbProvince);
            this.Controls.Add(this._ssGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusinessSector";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قطاع العمل";
            this._gbProvince.ResumeLayout(false);
            this._gbProvince.PerformLayout();
            this._ssGeneral.ResumeLayout(false);
            this._ssGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bnGeneral)).EndInit();
            this._bnGeneral.ResumeLayout(false);
            this._bnGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel _tssLblGeneral;
        private System.Windows.Forms.GroupBox _gbProvince;
        private System.Windows.Forms.TextBox _txtBoxDescription;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.TextBox _txtBoxId;
        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.StatusStrip _ssGeneral;
        private System.Windows.Forms.BindingNavigator _bnGeneral;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox _tscmbSearch;
        private System.Windows.Forms.ToolStripButton _tcbtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _tsbtnExit;
    }
}