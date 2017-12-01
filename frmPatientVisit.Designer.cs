namespace DoctorListInfo
{
    partial class frmPatientVisit
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientVisit));
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButtonBTMainPage = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabelDOA = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelDOV = new Infragistics.Win.Misc.UltraLabel();
            this.LabelName = new Infragistics.Win.Misc.UltraLabel();
            this.ultraButtonSearch = new Infragistics.Win.Misc.UltraButton();
            this.ultraDateTimeEditorDOA = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditorDOV = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraTextEditorName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButtonRefresh = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonDelete = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonEdit = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonNew = new Infragistics.Win.Misc.UltraButton();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridPatientVisit = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPatientVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.ultraGroupBox1.Appearance = appearance1;
            this.ultraGroupBox1.Controls.Add(this.ultraButtonBTMainPage);
            this.ultraGroupBox1.Controls.Add(this.ultraLabelDOA);
            this.ultraGroupBox1.Controls.Add(this.ultraLabelDOV);
            this.ultraGroupBox1.Controls.Add(this.LabelName);
            this.ultraGroupBox1.Controls.Add(this.ultraButtonSearch);
            this.ultraGroupBox1.Controls.Add(this.ultraDateTimeEditorDOA);
            this.ultraGroupBox1.Controls.Add(this.ultraDateTimeEditorDOV);
            this.ultraGroupBox1.Controls.Add(this.ultraTextEditorName);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(625, 110);
            this.ultraGroupBox1.TabIndex = 0;
            // 
            // ultraButtonBTMainPage
            // 
            this.ultraButtonBTMainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonBTMainPage.Location = new System.Drawing.Point(414, 39);
            this.ultraButtonBTMainPage.Name = "ultraButtonBTMainPage";
            this.ultraButtonBTMainPage.Size = new System.Drawing.Size(156, 23);
            this.ultraButtonBTMainPage.TabIndex = 7;
            this.ultraButtonBTMainPage.Text = "Back To MainPage";
            this.ultraButtonBTMainPage.Click += new System.EventHandler(this.ultraButtonBTMainPage_Click);
            // 
            // ultraLabelDOA
            // 
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabelDOA.Appearance = appearance4;
            this.ultraLabelDOA.Location = new System.Drawing.Point(26, 74);
            this.ultraLabelDOA.Name = "ultraLabelDOA";
            this.ultraLabelDOA.Size = new System.Drawing.Size(100, 23);
            this.ultraLabelDOA.TabIndex = 6;
            this.ultraLabelDOA.Text = "Date of Admission";
            // 
            // ultraLabelDOV
            // 
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabelDOV.Appearance = appearance3;
            this.ultraLabelDOV.Location = new System.Drawing.Point(23, 45);
            this.ultraLabelDOV.Name = "ultraLabelDOV";
            this.ultraLabelDOV.Size = new System.Drawing.Size(100, 23);
            this.ultraLabelDOV.TabIndex = 5;
            this.ultraLabelDOV.Text = "Date Of Visit";
            // 
            // LabelName
            // 
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Appearance = appearance5;
            this.LabelName.Location = new System.Drawing.Point(23, 8);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(100, 23);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Name";
            // 
            // ultraButtonSearch
            // 
            this.ultraButtonSearch.Location = new System.Drawing.Point(357, 70);
            this.ultraButtonSearch.Name = "ultraButtonSearch";
            this.ultraButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonSearch.TabIndex = 3;
            this.ultraButtonSearch.Text = "Search";
            this.ultraButtonSearch.Click += new System.EventHandler(this.ultraButtonSearch_Click);
            // 
            // ultraDateTimeEditorDOA
            // 
            this.ultraDateTimeEditorDOA.Location = new System.Drawing.Point(163, 69);
            this.ultraDateTimeEditorDOA.Name = "ultraDateTimeEditorDOA";
            this.ultraDateTimeEditorDOA.Size = new System.Drawing.Size(144, 21);
            this.ultraDateTimeEditorDOA.TabIndex = 2;
            // 
            // ultraDateTimeEditorDOV
            // 
            this.ultraDateTimeEditorDOV.Location = new System.Drawing.Point(162, 41);
            this.ultraDateTimeEditorDOV.Name = "ultraDateTimeEditorDOV";
            this.ultraDateTimeEditorDOV.Size = new System.Drawing.Size(145, 21);
            this.ultraDateTimeEditorDOV.TabIndex = 1;
            // 
            // ultraTextEditorName
            // 
            this.ultraTextEditorName.Location = new System.Drawing.Point(163, 11);
            this.ultraTextEditorName.Name = "ultraTextEditorName";
            this.ultraTextEditorName.Size = new System.Drawing.Size(143, 21);
            this.ultraTextEditorName.TabIndex = 0;
            // 
            // ultraGroupBox2
            // 
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.ultraGroupBox2.Appearance = appearance2;
            this.ultraGroupBox2.Controls.Add(this.ultraButtonRefresh);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonDelete);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonEdit);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonNew);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox2.Location = new System.Drawing.Point(0, 295);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(625, 110);
            this.ultraGroupBox2.TabIndex = 1;
            // 
            // ultraButtonRefresh
            // 
            this.ultraButtonRefresh.Location = new System.Drawing.Point(48, 47);
            this.ultraButtonRefresh.Name = "ultraButtonRefresh";
            this.ultraButtonRefresh.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonRefresh.TabIndex = 3;
            this.ultraButtonRefresh.Text = "Refresh";
            this.ultraButtonRefresh.Click += new System.EventHandler(this.ultraButtonRefresh_Click);
            // 
            // ultraButtonDelete
            // 
            this.ultraButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonDelete.Location = new System.Drawing.Point(333, 47);
            this.ultraButtonDelete.Name = "ultraButtonDelete";
            this.ultraButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonDelete.TabIndex = 2;
            this.ultraButtonDelete.Text = "Delete";
            this.ultraButtonDelete.Click += new System.EventHandler(this.ultraButtonDelete_Click);
            // 
            // ultraButtonEdit
            // 
            this.ultraButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonEdit.Location = new System.Drawing.Point(414, 47);
            this.ultraButtonEdit.Name = "ultraButtonEdit";
            this.ultraButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonEdit.TabIndex = 1;
            this.ultraButtonEdit.Text = "Edit";
            this.ultraButtonEdit.Click += new System.EventHandler(this.ultraButtonEdit_Click);
            // 
            // ultraButtonNew
            // 
            this.ultraButtonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonNew.Location = new System.Drawing.Point(495, 47);
            this.ultraButtonNew.Name = "ultraButtonNew";
            this.ultraButtonNew.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonNew.TabIndex = 0;
            this.ultraButtonNew.Text = "New";
            this.ultraButtonNew.Click += new System.EventHandler(this.ultraButtonNew_Click);
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Controls.Add(this.ultraGridPatientVisit);
            this.ultraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox3.Location = new System.Drawing.Point(0, 110);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(625, 185);
            this.ultraGroupBox3.TabIndex = 2;
            // 
            // ultraGridPatientVisit
            // 
            appearance6.BackColor = System.Drawing.Color.White;
            this.ultraGridPatientVisit.DisplayLayout.Appearance = appearance6;
            this.ultraGridPatientVisit.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridPatientVisit.DisplayLayout.MaxRowScrollRegions = 1;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridPatientVisit.DisplayLayout.Override.CardAreaAppearance = appearance7;
            this.ultraGridPatientVisit.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.FontData.BoldAsString = "True";
            appearance8.FontData.Name = "Arial";
            appearance8.FontData.SizeInPoints = 10F;
            appearance8.ForeColor = System.Drawing.Color.White;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridPatientVisit.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.ultraGridPatientVisit.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridPatientVisit.DisplayLayout.Override.RowSelectorAppearance = appearance9;
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridPatientVisit.DisplayLayout.Override.SelectedRowAppearance = appearance10;
            this.ultraGridPatientVisit.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridPatientVisit.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridPatientVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGridPatientVisit.Location = new System.Drawing.Point(3, 0);
            this.ultraGridPatientVisit.Name = "ultraGridPatientVisit";
            this.ultraGridPatientVisit.Size = new System.Drawing.Size(619, 182);
            this.ultraGridPatientVisit.TabIndex = 0;
            this.ultraGridPatientVisit.AfterRowActivate += new System.EventHandler(this.ultraGridPatientVisit_AfterRowActivate);
            // 
            // frmPatientVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 405);
            this.Controls.Add(this.ultraGroupBox3);
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmPatientVisit";
            this.Text = "PatientVisit";
            this.Load += new System.EventHandler(this.frmPatientVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorDOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPatientVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDOA;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDOV;
        private Infragistics.Win.Misc.UltraLabel LabelName;
        private Infragistics.Win.Misc.UltraButton ultraButtonSearch;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorDOA;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorDOV;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorName;
        private Infragistics.Win.Misc.UltraButton ultraButtonRefresh;
        private Infragistics.Win.Misc.UltraButton ultraButtonDelete;
        private Infragistics.Win.Misc.UltraButton ultraButtonEdit;
        private Infragistics.Win.Misc.UltraButton ultraButtonNew;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridPatientVisit;
        private Infragistics.Win.Misc.UltraButton ultraButtonBTMainPage;
    }
}