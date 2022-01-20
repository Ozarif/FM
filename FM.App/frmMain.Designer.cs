namespace FM.App
{
    partial class frmMain
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
            this._ssMain = new System.Windows.Forms.StatusStrip();
            this._tssLblDescription = new System.Windows.Forms.ToolStripStatusLabel();
            this._msMain = new System.Windows.Forms.MenuStrip();
            this._tsmiSetup = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiSetupGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiSetupGeneralHomeTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiSetupGeneralEducationalLevels = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiSetupGeneralBusinessSectors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiSetupParty = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiSetupPartyDivisions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiSetupPartyPositions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiSetupPartyElectionRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiSetupServices = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiSetupServicesTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiSetupServicesResults = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiCitizens = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiCitizensMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiCitizensDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiCitizensServices = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this._ssMain.SuspendLayout();
            this._msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ssMain
            // 
            this._ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tssLblDescription});
            this._ssMain.Location = new System.Drawing.Point(0, 511);
            this._ssMain.Name = "_ssMain";
            this._ssMain.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
            this._ssMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._ssMain.Size = new System.Drawing.Size(1045, 24);
            this._ssMain.TabIndex = 1;
            // 
            // _tssLblDescription
            // 
            this._tssLblDescription.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this._tssLblDescription.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this._tssLblDescription.Name = "_tssLblDescription";
            this._tssLblDescription.Size = new System.Drawing.Size(1028, 19);
            this._tssLblDescription.Spring = true;
            this._tssLblDescription.Text = "Ready";
            this._tssLblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _msMain
            // 
            this._msMain.AutoSize = false;
            this._msMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this._msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiSetup,
            this._tsmiCitizens,
            this._tsmiExit});
            this._msMain.Location = new System.Drawing.Point(0, 0);
            this._msMain.Name = "_msMain";
            this._msMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this._msMain.Size = new System.Drawing.Size(1045, 30);
            this._msMain.TabIndex = 2;
            this._msMain.Text = "menuStrip1";
            // 
            // _tsmiSetup
            // 
            this._tsmiSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiSetupGeneral,
            this.toolStripSeparator1,
            this._tsmiSetupParty,
            this.toolStripSeparator2,
            this._tsmiSetupServices});
            this._tsmiSetup.Name = "_tsmiSetup";
            this._tsmiSetup.Size = new System.Drawing.Size(65, 26);
            this._tsmiSetup.Text = "ألأعدادات";
            // 
            // _tsmiSetupGeneral
            // 
            this._tsmiSetupGeneral.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiSetupGeneralHomeTypes,
            this.toolStripSeparator8,
            this._tsmiSetupGeneralEducationalLevels,
            this.toolStripSeparator9,
            this._tsmiSetupGeneralBusinessSectors});
            this._tsmiSetupGeneral.Name = "_tsmiSetupGeneral";
            this._tsmiSetupGeneral.Size = new System.Drawing.Size(180, 22);
            this._tsmiSetupGeneral.Text = "اعدادات عامة";
            // 
            // _tsmiSetupGeneralHomeTypes
            // 
            this._tsmiSetupGeneralHomeTypes.Name = "_tsmiSetupGeneralHomeTypes";
            this._tsmiSetupGeneralHomeTypes.Size = new System.Drawing.Size(180, 22);
            this._tsmiSetupGeneralHomeTypes.Text = "انواع السكن";
            this._tsmiSetupGeneralHomeTypes.Click += new System.EventHandler(this._tsmiSetupGeneralHomeTypes_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // _tsmiSetupGeneralEducationalLevels
            // 
            this._tsmiSetupGeneralEducationalLevels.Name = "_tsmiSetupGeneralEducationalLevels";
            this._tsmiSetupGeneralEducationalLevels.Size = new System.Drawing.Size(180, 22);
            this._tsmiSetupGeneralEducationalLevels.Text = "التحصيل العلمي";
            this._tsmiSetupGeneralEducationalLevels.Click += new System.EventHandler(this._tsmiSetupGeneralEducationalLevels_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(177, 6);
            // 
            // _tsmiSetupGeneralBusinessSectors
            // 
            this._tsmiSetupGeneralBusinessSectors.Name = "_tsmiSetupGeneralBusinessSectors";
            this._tsmiSetupGeneralBusinessSectors.Size = new System.Drawing.Size(180, 22);
            this._tsmiSetupGeneralBusinessSectors.Text = "قطاع العمل";
            this._tsmiSetupGeneralBusinessSectors.Click += new System.EventHandler(this._tsmiSetupGeneralBusinessSectors_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // _tsmiSetupParty
            // 
            this._tsmiSetupParty.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiSetupPartyDivisions,
            this.toolStripSeparator3,
            this._tsmiSetupPartyPositions,
            this.toolStripSeparator4,
            this._tsmiSetupPartyElectionRoles});
            this._tsmiSetupParty.Name = "_tsmiSetupParty";
            this._tsmiSetupParty.Size = new System.Drawing.Size(180, 22);
            this._tsmiSetupParty.Text = "اعدادات التيار";
            // 
            // _tsmiSetupPartyDivisions
            // 
            this._tsmiSetupPartyDivisions.Name = "_tsmiSetupPartyDivisions";
            this._tsmiSetupPartyDivisions.Size = new System.Drawing.Size(157, 22);
            this._tsmiSetupPartyDivisions.Text = "دوائر التيار";
            this._tsmiSetupPartyDivisions.Click += new System.EventHandler(this._tsmiSetupPartyDivisions_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // _tsmiSetupPartyPositions
            // 
            this._tsmiSetupPartyPositions.Name = "_tsmiSetupPartyPositions";
            this._tsmiSetupPartyPositions.Size = new System.Drawing.Size(157, 22);
            this._tsmiSetupPartyPositions.Text = "مناصب التيار";
            this._tsmiSetupPartyPositions.Click += new System.EventHandler(this._tsmiSetupPartyPositions_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(154, 6);
            // 
            // _tsmiSetupPartyElectionRoles
            // 
            this._tsmiSetupPartyElectionRoles.Name = "_tsmiSetupPartyElectionRoles";
            this._tsmiSetupPartyElectionRoles.Size = new System.Drawing.Size(157, 22);
            this._tsmiSetupPartyElectionRoles.Text = "مهمات الانتخابات";
            this._tsmiSetupPartyElectionRoles.Click += new System.EventHandler(this._tsmiSetupPartyElectionRoles_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // _tsmiSetupServices
            // 
            this._tsmiSetupServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiSetupServicesTypes,
            this.toolStripSeparator5,
            this._tsmiSetupServicesResults});
            this._tsmiSetupServices.Name = "_tsmiSetupServices";
            this._tsmiSetupServices.Size = new System.Drawing.Size(180, 22);
            this._tsmiSetupServices.Text = "اعدادات الخدمات";
            // 
            // _tsmiSetupServicesTypes
            // 
            this._tsmiSetupServicesTypes.Name = "_tsmiSetupServicesTypes";
            this._tsmiSetupServicesTypes.Size = new System.Drawing.Size(140, 22);
            this._tsmiSetupServicesTypes.Text = "انواع الخدمات";
            this._tsmiSetupServicesTypes.Click += new System.EventHandler(this._tsmiSetupServicesTypes_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
            // 
            // _tsmiSetupServicesResults
            // 
            this._tsmiSetupServicesResults.Name = "_tsmiSetupServicesResults";
            this._tsmiSetupServicesResults.Size = new System.Drawing.Size(140, 22);
            this._tsmiSetupServicesResults.Text = "نتائج الخدمات";
            this._tsmiSetupServicesResults.Click += new System.EventHandler(this._tsmiSetupServicesResults_Click);
            // 
            // _tsmiCitizens
            // 
            this._tsmiCitizens.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiCitizensMain,
            this.toolStripSeparator6,
            this._tsmiCitizensDetails,
            this.toolStripSeparator7,
            this._tsmiCitizensServices});
            this._tsmiCitizens.Name = "_tsmiCitizens";
            this._tsmiCitizens.Size = new System.Drawing.Size(102, 26);
            this._tsmiCitizens.Text = "ملفات المواطنين";
            // 
            // _tsmiCitizensMain
            // 
            this._tsmiCitizensMain.Name = "_tsmiCitizensMain";
            this._tsmiCitizensMain.Size = new System.Drawing.Size(186, 22);
            this._tsmiCitizensMain.Text = "ملف لوائح الشطب";
            this._tsmiCitizensMain.Click += new System.EventHandler(this._tsmiCitizensMain_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(183, 6);
            // 
            // _tsmiCitizensDetails
            // 
            this._tsmiCitizensDetails.Name = "_tsmiCitizensDetails";
            this._tsmiCitizensDetails.Size = new System.Drawing.Size(186, 22);
            this._tsmiCitizensDetails.Text = "ملف المواطن في التيار";
            this._tsmiCitizensDetails.Click += new System.EventHandler(this._tsmiCitizensDetails_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(183, 6);
            // 
            // _tsmiCitizensServices
            // 
            this._tsmiCitizensServices.Name = "_tsmiCitizensServices";
            this._tsmiCitizensServices.Size = new System.Drawing.Size(186, 22);
            this._tsmiCitizensServices.Text = "ملف الخدمات";
            this._tsmiCitizensServices.Click += new System.EventHandler(this._tsmiCitizensServices_Click);
            // 
            // _tsmiExit
            // 
            this._tsmiExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._tsmiExit.Name = "_tsmiExit";
            this._tsmiExit.Size = new System.Drawing.Size(44, 26);
            this._tsmiExit.Text = "خروج";
            this._tsmiExit.Click += new System.EventHandler(this._tsmiExit_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(186, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 535);
            this.Controls.Add(this._ssMain);
            this.Controls.Add(this._msMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this._msMain;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "السجلات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._frmMain_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this._frmMain_MdiChildActivate);
            this._ssMain.ResumeLayout(false);
            this._ssMain.PerformLayout();
            this._msMain.ResumeLayout(false);
            this._msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip _ssMain;
        private System.Windows.Forms.ToolStripStatusLabel _tssLblDescription;
        private System.Windows.Forms.MenuStrip _msMain;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetup;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupGeneral;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupGeneralHomeTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupGeneralEducationalLevels;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupGeneralBusinessSectors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupParty;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupPartyDivisions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupPartyPositions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupPartyElectionRoles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupServices;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupServicesTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSetupServicesResults;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCitizens;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCitizensMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCitizensDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCitizensServices;
        private System.Windows.Forms.ToolStripMenuItem _tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    }
}