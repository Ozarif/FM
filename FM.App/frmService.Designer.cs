namespace FM.App
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            this._gbBasicInfo = new System.Windows.Forms.GroupBox();
            this._txtBoxServiceID = new System.Windows.Forms.TextBox();
            this._txtBoxCitizenName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtBoxCitizenNumber = new System.Windows.Forms.TextBox();
            this._lblCitizenNumber = new System.Windows.Forms.Label();
            this._gbService = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._lblResult = new System.Windows.Forms.Label();
            this._txtBoxContactNumber = new System.Windows.Forms.TextBox();
            this._lblContactNumber = new System.Windows.Forms.Label();
            this._txtBoxContactName = new System.Windows.Forms.TextBox();
            this._lblContactName = new System.Windows.Forms.Label();
            this._cmbServiceType = new System.Windows.Forms.ComboBox();
            this._lblServiceType = new System.Windows.Forms.Label();
            this._gbButtons = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._ssGeneral = new System.Windows.Forms.StatusStrip();
            this._tssLblGeneral = new System.Windows.Forms.ToolStripStatusLabel();
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
            this._gbBasicInfo.SuspendLayout();
            this._gbService.SuspendLayout();
            this._gbButtons.SuspendLayout();
            this._ssGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bnGeneral)).BeginInit();
            this._bnGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gbBasicInfo
            // 
            this._gbBasicInfo.Controls.Add(this._txtBoxServiceID);
            this._gbBasicInfo.Controls.Add(this._txtBoxCitizenName);
            this._gbBasicInfo.Controls.Add(this.label3);
            this._gbBasicInfo.Controls.Add(this._txtBoxCitizenNumber);
            this._gbBasicInfo.Controls.Add(this._lblCitizenNumber);
            this._gbBasicInfo.Location = new System.Drawing.Point(12, 28);
            this._gbBasicInfo.Name = "_gbBasicInfo";
            this._gbBasicInfo.Size = new System.Drawing.Size(400, 69);
            this._gbBasicInfo.TabIndex = 1;
            this._gbBasicInfo.TabStop = false;
            // 
            // _txtBoxServiceID
            // 
            this._txtBoxServiceID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxServiceID.Location = new System.Drawing.Point(6, 13);
            this._txtBoxServiceID.Name = "_txtBoxServiceID";
            this._txtBoxServiceID.ReadOnly = true;
            this._txtBoxServiceID.Size = new System.Drawing.Size(106, 20);
            this._txtBoxServiceID.TabIndex = 8;
            this._txtBoxServiceID.Visible = false;
            // 
            // _txtBoxCitizenName
            // 
            this._txtBoxCitizenName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxCitizenName.Location = new System.Drawing.Point(6, 39);
            this._txtBoxCitizenName.Name = "_txtBoxCitizenName";
            this._txtBoxCitizenName.ReadOnly = true;
            this._txtBoxCitizenName.Size = new System.Drawing.Size(290, 20);
            this._txtBoxCitizenName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(317, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المواطن";
            // 
            // _txtBoxCitizenNumber
            // 
            this._txtBoxCitizenNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxCitizenNumber.Location = new System.Drawing.Point(190, 13);
            this._txtBoxCitizenNumber.Name = "_txtBoxCitizenNumber";
            this._txtBoxCitizenNumber.ReadOnly = true;
            this._txtBoxCitizenNumber.Size = new System.Drawing.Size(106, 20);
            this._txtBoxCitizenNumber.TabIndex = 3;
            // 
            // _lblCitizenNumber
            // 
            this._lblCitizenNumber.AutoSize = true;
            this._lblCitizenNumber.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._lblCitizenNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblCitizenNumber.Location = new System.Drawing.Point(322, 16);
            this._lblCitizenNumber.Name = "_lblCitizenNumber";
            this._lblCitizenNumber.Size = new System.Drawing.Size(72, 13);
            this._lblCitizenNumber.TabIndex = 2;
            this._lblCitizenNumber.Text = "رقم المواطن";
            // 
            // _gbService
            // 
            this._gbService.Controls.Add(this.comboBox1);
            this._gbService.Controls.Add(this._lblResult);
            this._gbService.Controls.Add(this._txtBoxContactNumber);
            this._gbService.Controls.Add(this._lblContactNumber);
            this._gbService.Controls.Add(this._txtBoxContactName);
            this._gbService.Controls.Add(this._lblContactName);
            this._gbService.Controls.Add(this._cmbServiceType);
            this._gbService.Controls.Add(this._lblServiceType);
            this._gbService.Location = new System.Drawing.Point(12, 103);
            this._gbService.Name = "_gbService";
            this._gbService.Size = new System.Drawing.Size(402, 134);
            this._gbService.TabIndex = 2;
            this._gbService.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // _lblResult
            // 
            this._lblResult.AutoSize = true;
            this._lblResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblResult.Location = new System.Drawing.Point(354, 97);
            this._lblResult.Name = "_lblResult";
            this._lblResult.Size = new System.Drawing.Size(42, 13);
            this._lblResult.TabIndex = 20;
            this._lblResult.Text = "النتيجة";
            // 
            // _txtBoxContactNumber
            // 
            this._txtBoxContactNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxContactNumber.Location = new System.Drawing.Point(138, 68);
            this._txtBoxContactNumber.Name = "_txtBoxContactNumber";
            this._txtBoxContactNumber.Size = new System.Drawing.Size(160, 20);
            this._txtBoxContactNumber.TabIndex = 19;
            // 
            // _lblContactNumber
            // 
            this._lblContactNumber.AutoSize = true;
            this._lblContactNumber.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._lblContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblContactNumber.Location = new System.Drawing.Point(328, 71);
            this._lblContactNumber.Name = "_lblContactNumber";
            this._lblContactNumber.Size = new System.Drawing.Size(68, 13);
            this._lblContactNumber.TabIndex = 18;
            this._lblContactNumber.Text = "رقم للاتصال";
            // 
            // _txtBoxContactName
            // 
            this._txtBoxContactName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxContactName.Location = new System.Drawing.Point(8, 42);
            this._txtBoxContactName.Name = "_txtBoxContactName";
            this._txtBoxContactName.Size = new System.Drawing.Size(290, 20);
            this._txtBoxContactName.TabIndex = 13;
            // 
            // _lblContactName
            // 
            this._lblContactName.AutoSize = true;
            this._lblContactName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._lblContactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblContactName.Location = new System.Drawing.Point(333, 45);
            this._lblContactName.Name = "_lblContactName";
            this._lblContactName.Size = new System.Drawing.Size(63, 13);
            this._lblContactName.TabIndex = 12;
            this._lblContactName.Text = "اسم الجهة";
            // 
            // _cmbServiceType
            // 
            this._cmbServiceType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._cmbServiceType.FormattingEnabled = true;
            this._cmbServiceType.Location = new System.Drawing.Point(8, 15);
            this._cmbServiceType.Name = "_cmbServiceType";
            this._cmbServiceType.Size = new System.Drawing.Size(290, 21);
            this._cmbServiceType.TabIndex = 11;
            // 
            // _lblServiceType
            // 
            this._lblServiceType.AutoSize = true;
            this._lblServiceType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._lblServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblServiceType.Location = new System.Drawing.Point(332, 18);
            this._lblServiceType.Name = "_lblServiceType";
            this._lblServiceType.Size = new System.Drawing.Size(64, 13);
            this._lblServiceType.TabIndex = 10;
            this._lblServiceType.Text = "نوع الخدمة";
            // 
            // _gbButtons
            // 
            this._gbButtons.Controls.Add(this._btnClose);
            this._gbButtons.Controls.Add(this._btnSave);
            this._gbButtons.Location = new System.Drawing.Point(12, 243);
            this._gbButtons.Name = "_gbButtons";
            this._gbButtons.Size = new System.Drawing.Size(402, 56);
            this._gbButtons.TabIndex = 3;
            this._gbButtons.TabStop = false;
            // 
            // _btnClose
            // 
            this._btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._btnClose.Location = new System.Drawing.Point(85, 19);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 1;
            this._btnClose.Text = "الغاء";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._btnSave.Location = new System.Drawing.Point(223, 19);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 0;
            this._btnSave.Text = "حفظ";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _ssGeneral
            // 
            this._ssGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tssLblGeneral});
            this._ssGeneral.Location = new System.Drawing.Point(0, 309);
            this._ssGeneral.Name = "_ssGeneral";
            this._ssGeneral.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._ssGeneral.Size = new System.Drawing.Size(425, 22);
            this._ssGeneral.TabIndex = 9;
            // 
            // _tssLblGeneral
            // 
            this._tssLblGeneral.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this._tssLblGeneral.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this._tssLblGeneral.Name = "_tssLblGeneral";
            this._tssLblGeneral.Size = new System.Drawing.Size(410, 17);
            this._tssLblGeneral.Spring = true;
            this._tssLblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this._bnGeneral.Size = new System.Drawing.Size(425, 25);
            this._bnGeneral.TabIndex = 10;
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
            this._tscmbSearch.Size = new System.Drawing.Size(130, 21);
            // 
            // _tcbtnSearch
            // 
            this._tcbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tcbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("_tcbtnSearch.Image")));
            this._tcbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tcbtnSearch.Name = "_tcbtnSearch";
            this._tcbtnSearch.Size = new System.Drawing.Size(23, 20);
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
            this._tsbtnExit.Size = new System.Drawing.Size(23, 20);
            this._tsbtnExit.Text = "toolStripButton1";
            this._tsbtnExit.ToolTipText = "اغلاق";
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 331);
            this.Controls.Add(this._bnGeneral);
            this.Controls.Add(this._ssGeneral);
            this.Controls.Add(this._gbButtons);
            this.Controls.Add(this._gbService);
            this.Controls.Add(this._gbBasicInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmService";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الخدمات";
            this._gbBasicInfo.ResumeLayout(false);
            this._gbBasicInfo.PerformLayout();
            this._gbService.ResumeLayout(false);
            this._gbService.PerformLayout();
            this._gbButtons.ResumeLayout(false);
            this._ssGeneral.ResumeLayout(false);
            this._ssGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bnGeneral)).EndInit();
            this._bnGeneral.ResumeLayout(false);
            this._bnGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbBasicInfo;
        private System.Windows.Forms.TextBox _txtBoxCitizenName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtBoxCitizenNumber;
        private System.Windows.Forms.Label _lblCitizenNumber;
        private System.Windows.Forms.GroupBox _gbService;
        private System.Windows.Forms.ComboBox _cmbServiceType;
        private System.Windows.Forms.Label _lblServiceType;
        private System.Windows.Forms.TextBox _txtBoxContactName;
        private System.Windows.Forms.Label _lblContactName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label _lblResult;
        private System.Windows.Forms.TextBox _txtBoxContactNumber;
        private System.Windows.Forms.Label _lblContactNumber;
        private System.Windows.Forms.GroupBox _gbButtons;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.StatusStrip _ssGeneral;
        private System.Windows.Forms.ToolStripStatusLabel _tssLblGeneral;
        private System.Windows.Forms.TextBox _txtBoxServiceID;
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