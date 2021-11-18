namespace FM.App
{
    partial class frmSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._gbSearch = new System.Windows.Forms.GroupBox();
            this._btnClear = new System.Windows.Forms.Button();
            this._btnSearch = new System.Windows.Forms.Button();
            this._lblLastName = new System.Windows.Forms.Label();
            this._lblFatherName = new System.Windows.Forms.Label();
            this._lblFirstName = new System.Windows.Forms.Label();
            this._txtBoxLastName = new System.Windows.Forms.TextBox();
            this._txtBoxFatherName = new System.Windows.Forms.TextBox();
            this._txtBoxFirstName = new System.Windows.Forms.TextBox();
            this._gbSearchResult = new System.Windows.Forms.GroupBox();
            this._dgSearchResult = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionSectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._gbSearch.SuspendLayout();
            this._gbSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _gbSearch
            // 
            this._gbSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._gbSearch.Controls.Add(this._btnClear);
            this._gbSearch.Controls.Add(this._btnSearch);
            this._gbSearch.Controls.Add(this._lblLastName);
            this._gbSearch.Controls.Add(this._lblFatherName);
            this._gbSearch.Controls.Add(this._lblFirstName);
            this._gbSearch.Controls.Add(this._txtBoxLastName);
            this._gbSearch.Controls.Add(this._txtBoxFatherName);
            this._gbSearch.Controls.Add(this._txtBoxFirstName);
            this._gbSearch.Location = new System.Drawing.Point(12, 12);
            this._gbSearch.Name = "_gbSearch";
            this._gbSearch.Size = new System.Drawing.Size(776, 83);
            this._gbSearch.TabIndex = 0;
            this._gbSearch.TabStop = false;
            // 
            // _btnClear
            // 
            this._btnClear.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._btnClear.Location = new System.Drawing.Point(6, 46);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(75, 23);
            this._btnClear.TabIndex = 7;
            this._btnClear.Text = "مسح";
            this._btnClear.UseVisualStyleBackColor = true;
            // 
            // _btnSearch
            // 
            this._btnSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this._btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._btnSearch.Location = new System.Drawing.Point(83, 46);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(75, 23);
            this._btnSearch.TabIndex = 6;
            this._btnSearch.Text = "بحث";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _lblLastName
            // 
            this._lblLastName.AutoSize = true;
            this._lblLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblLastName.Location = new System.Drawing.Point(308, 27);
            this._lblLastName.Name = "_lblLastName";
            this._lblLastName.Size = new System.Drawing.Size(57, 14);
            this._lblLastName.TabIndex = 5;
            this._lblLastName.Text = "الشهرة :";
            // 
            // _lblFatherName
            // 
            this._lblFatherName.AutoSize = true;
            this._lblFatherName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._lblFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblFatherName.Location = new System.Drawing.Point(501, 27);
            this._lblFatherName.Name = "_lblFatherName";
            this._lblFatherName.Size = new System.Drawing.Size(68, 14);
            this._lblFatherName.TabIndex = 4;
            this._lblFatherName.Text = "اسم الاب :";
            // 
            // _lblFirstName
            // 
            this._lblFirstName.AutoSize = true;
            this._lblFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this._lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lblFirstName.Location = new System.Drawing.Point(721, 27);
            this._lblFirstName.Name = "_lblFirstName";
            this._lblFirstName.Size = new System.Drawing.Size(49, 14);
            this._lblFirstName.TabIndex = 3;
            this._lblFirstName.Text = "الاسم :";
            // 
            // _txtBoxLastName
            // 
            this._txtBoxLastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._txtBoxLastName.Location = new System.Drawing.Point(164, 48);
            this._txtBoxLastName.Name = "_txtBoxLastName";
            this._txtBoxLastName.Size = new System.Drawing.Size(198, 20);
            this._txtBoxLastName.TabIndex = 2;
            // 
            // _txtBoxFatherName
            // 
            this._txtBoxFatherName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._txtBoxFatherName.Location = new System.Drawing.Point(368, 48);
            this._txtBoxFatherName.Name = "_txtBoxFatherName";
            this._txtBoxFatherName.Size = new System.Drawing.Size(198, 20);
            this._txtBoxFatherName.TabIndex = 1;
            // 
            // _txtBoxFirstName
            // 
            this._txtBoxFirstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._txtBoxFirstName.Location = new System.Drawing.Point(572, 48);
            this._txtBoxFirstName.Name = "_txtBoxFirstName";
            this._txtBoxFirstName.Size = new System.Drawing.Size(198, 20);
            this._txtBoxFirstName.TabIndex = 0;
            // 
            // _gbSearchResult
            // 
            this._gbSearchResult.Controls.Add(this._dgSearchResult);
            this._gbSearchResult.Location = new System.Drawing.Point(12, 101);
            this._gbSearchResult.Name = "_gbSearchResult";
            this._gbSearchResult.Size = new System.Drawing.Size(776, 337);
            this._gbSearchResult.TabIndex = 1;
            this._gbSearchResult.TabStop = false;
            // 
            // _dgSearchResult
            // 
            this._dgSearchResult.AllowUserToAddRows = false;
            this._dgSearchResult.AllowUserToDeleteRows = false;
            this._dgSearchResult.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._dgSearchResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgSearchResult.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.motherFullNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.registerPlaceDataGridViewTextBoxColumn,
            this.registerNumberDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn,
            this.religionSectDataGridViewTextBoxColumn});
            this._dgSearchResult.DataSource = this.citizenBindingSource;
            this._dgSearchResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dgSearchResult.GridColor = System.Drawing.SystemColors.ControlLight;
            this._dgSearchResult.Location = new System.Drawing.Point(6, 19);
            this._dgSearchResult.MultiSelect = false;
            this._dgSearchResult.Name = "_dgSearchResult";
            this._dgSearchResult.ReadOnly = true;
            this._dgSearchResult.RowHeadersWidth = 20;
            this._dgSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgSearchResult.Size = new System.Drawing.Size(764, 306);
            this._dgSearchResult.TabIndex = 0;
            this._dgSearchResult.DoubleClick += new System.EventHandler(this._dgSearchResult_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "رقم";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 106;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 106;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "اسم الأب";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatherNameDataGridViewTextBoxColumn.Width = 106;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "الشهرة";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 106;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 106;
            // 
            // motherFullNameDataGridViewTextBoxColumn
            // 
            this.motherFullNameDataGridViewTextBoxColumn.DataPropertyName = "MotherFullName";
            this.motherFullNameDataGridViewTextBoxColumn.HeaderText = "MotherFullName";
            this.motherFullNameDataGridViewTextBoxColumn.Name = "motherFullNameDataGridViewTextBoxColumn";
            this.motherFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.motherFullNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Visible = false;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.ReadOnly = true;
            this.provinceDataGridViewTextBoxColumn.Visible = false;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            this.districtDataGridViewTextBoxColumn.Visible = false;
            // 
            // registerPlaceDataGridViewTextBoxColumn
            // 
            this.registerPlaceDataGridViewTextBoxColumn.DataPropertyName = "RegisterPlace";
            this.registerPlaceDataGridViewTextBoxColumn.HeaderText = "مكان الولادة";
            this.registerPlaceDataGridViewTextBoxColumn.Name = "registerPlaceDataGridViewTextBoxColumn";
            this.registerPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.registerPlaceDataGridViewTextBoxColumn.Width = 106;
            // 
            // registerNumberDataGridViewTextBoxColumn
            // 
            this.registerNumberDataGridViewTextBoxColumn.DataPropertyName = "RegisterNumber";
            this.registerNumberDataGridViewTextBoxColumn.HeaderText = "رقم السجل";
            this.registerNumberDataGridViewTextBoxColumn.Name = "registerNumberDataGridViewTextBoxColumn";
            this.registerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.registerNumberDataGridViewTextBoxColumn.Width = 106;
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            this.religionDataGridViewTextBoxColumn.ReadOnly = true;
            this.religionDataGridViewTextBoxColumn.Visible = false;
            // 
            // religionSectDataGridViewTextBoxColumn
            // 
            this.religionSectDataGridViewTextBoxColumn.DataPropertyName = "ReligionSect";
            this.religionSectDataGridViewTextBoxColumn.HeaderText = "ReligionSect";
            this.religionSectDataGridViewTextBoxColumn.Name = "religionSectDataGridViewTextBoxColumn";
            this.religionSectDataGridViewTextBoxColumn.ReadOnly = true;
            this.religionSectDataGridViewTextBoxColumn.Visible = false;
            // 
            // citizenBindingSource
            // 
            this.citizenBindingSource.DataSource = typeof(FM.Models.Citizen);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this._gbSearchResult);
            this.Controls.Add(this._gbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this._gbSearch.ResumeLayout(false);
            this._gbSearch.PerformLayout();
            this._gbSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbSearch;
        private System.Windows.Forms.Label _lblLastName;
        private System.Windows.Forms.Label _lblFatherName;
        private System.Windows.Forms.Label _lblFirstName;
        private System.Windows.Forms.TextBox _txtBoxLastName;
        private System.Windows.Forms.TextBox _txtBoxFatherName;
        private System.Windows.Forms.TextBox _txtBoxFirstName;
        private System.Windows.Forms.GroupBox _gbSearchResult;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.DataGridView _dgSearchResult;
        private System.Windows.Forms.BindingSource citizenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionSectDataGridViewTextBoxColumn;
    }
}