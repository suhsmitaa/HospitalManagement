namespace DoctorListInfo
{
    partial class frmPatientList
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
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientList));
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridPatientList = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ulName = new Infragistics.Win.Misc.UltraLabel();
            this.ultraButtonBTMainPage = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditorPatientName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraButtonSearch = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabelDOR = new Infragistics.Win.Misc.UltraLabel();
            this.uDTEDOR = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButtonRefresh = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonNew = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonEdit = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonDelete = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPatientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPatientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDTEDOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraGridPatientList);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox3);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(590, 367);
            this.ultraGroupBox1.TabIndex = 0;
            // 
            // ultraGridPatientList
            // 
            appearance17.BackColor = System.Drawing.Color.White;
            this.ultraGridPatientList.DisplayLayout.Appearance = appearance17;
            this.ultraGridPatientList.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridPatientList.DisplayLayout.MaxRowScrollRegions = 1;
            appearance18.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridPatientList.DisplayLayout.Override.CardAreaAppearance = appearance18;
            this.ultraGridPatientList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance19.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance19.FontData.BoldAsString = "True";
            appearance19.FontData.Name = "Arial";
            appearance19.FontData.SizeInPoints = 10F;
            appearance19.ForeColor = System.Drawing.Color.White;
            appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridPatientList.DisplayLayout.Override.HeaderAppearance = appearance19;
            this.ultraGridPatientList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance20.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridPatientList.DisplayLayout.Override.RowSelectorAppearance = appearance20;
            appearance21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance21.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridPatientList.DisplayLayout.Override.SelectedRowAppearance = appearance21;
            this.ultraGridPatientList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridPatientList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGridPatientList.Location = new System.Drawing.Point(3, 110);
            this.ultraGridPatientList.Name = "ultraGridPatientList";
            this.ultraGridPatientList.Size = new System.Drawing.Size(584, 254);
            this.ultraGridPatientList.TabIndex = 2;
            this.ultraGridPatientList.AfterCellActivate += new System.EventHandler(this.ultraGridPatientList_AfterCellActivate);
            this.ultraGridPatientList.AfterRowActivate += new System.EventHandler(this.ultraGridPatientList_AfterRowActivate);
            // 
            // ultraGroupBox3
            // 
            appearance13.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance13.ImageBackground")));
            this.ultraGroupBox3.Appearance = appearance13;
            this.ultraGroupBox3.Controls.Add(this.ulName);
            this.ultraGroupBox3.Controls.Add(this.ultraButtonBTMainPage);
            this.ultraGroupBox3.Controls.Add(this.ultraTextEditorPatientName);
            this.ultraGroupBox3.Controls.Add(this.ultraButtonSearch);
            this.ultraGroupBox3.Controls.Add(this.ultraLabelDOR);
            this.ultraGroupBox3.Controls.Add(this.uDTEDOR);
            this.ultraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox3.Location = new System.Drawing.Point(3, 0);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(584, 110);
            this.ultraGroupBox3.TabIndex = 1;
            // 
            // ulName
            // 
            appearance16.BackColor = System.Drawing.Color.Transparent;
            this.ulName.Appearance = appearance16;
            this.ulName.Location = new System.Drawing.Point(21, 22);
            this.ulName.Name = "ulName";
            this.ulName.Size = new System.Drawing.Size(100, 14);
            this.ulName.TabIndex = 5;
            this.ulName.Text = "Name";
            // 
            // ultraButtonBTMainPage
            // 
            this.ultraButtonBTMainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonBTMainPage.Location = new System.Drawing.Point(390, 33);
            this.ultraButtonBTMainPage.Name = "ultraButtonBTMainPage";
            this.ultraButtonBTMainPage.Size = new System.Drawing.Size(156, 23);
            this.ultraButtonBTMainPage.TabIndex = 4;
            this.ultraButtonBTMainPage.Text = "Back To MainPage";
            this.ultraButtonBTMainPage.Click += new System.EventHandler(this.ultraButtonBTMainPage_Click);
            // 
            // ultraTextEditorPatientName
            // 
            this.ultraTextEditorPatientName.Location = new System.Drawing.Point(137, 18);
            this.ultraTextEditorPatientName.Name = "ultraTextEditorPatientName";
            this.ultraTextEditorPatientName.Size = new System.Drawing.Size(144, 21);
            this.ultraTextEditorPatientName.TabIndex = 3;
            // 
            // ultraButtonSearch
            // 
            this.ultraButtonSearch.Location = new System.Drawing.Point(300, 49);
            this.ultraButtonSearch.Name = "ultraButtonSearch";
            this.ultraButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonSearch.TabIndex = 2;
            this.ultraButtonSearch.Text = "Search";
            this.ultraButtonSearch.Click += new System.EventHandler(this.ultraButtonSearch_Click);
            // 
            // ultraLabelDOR
            // 
            appearance15.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabelDOR.Appearance = appearance15;
            this.ultraLabelDOR.Location = new System.Drawing.Point(21, 55);
            this.ultraLabelDOR.Name = "ultraLabelDOR";
            this.ultraLabelDOR.Size = new System.Drawing.Size(100, 23);
            this.ultraLabelDOR.TabIndex = 1;
            this.ultraLabelDOR.Text = "Date Of Rgistration";
            // 
            // uDTEDOR
            // 
            this.uDTEDOR.Location = new System.Drawing.Point(137, 51);
            this.uDTEDOR.Name = "uDTEDOR";
            this.uDTEDOR.Size = new System.Drawing.Size(144, 21);
            this.uDTEDOR.TabIndex = 0;
            // 
            // ultraGroupBox2
            // 
            appearance14.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance14.ImageBackground")));
            this.ultraGroupBox2.Appearance = appearance14;
            this.ultraGroupBox2.Controls.Add(this.ultraButtonRefresh);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonNew);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonEdit);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonDelete);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox2.Location = new System.Drawing.Point(0, 257);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(590, 110);
            this.ultraGroupBox2.TabIndex = 1;
            this.ultraGroupBox2.Click += new System.EventHandler(this.ultraGroupBox2_Click);
            // 
            // ultraButtonRefresh
            // 
            this.ultraButtonRefresh.Location = new System.Drawing.Point(24, 45);
            this.ultraButtonRefresh.Name = "ultraButtonRefresh";
            this.ultraButtonRefresh.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonRefresh.TabIndex = 3;
            this.ultraButtonRefresh.Text = "Refresh";
            this.ultraButtonRefresh.Click += new System.EventHandler(this.ultraButtonRefresh_Click);
            // 
            // ultraButtonNew
            // 
            this.ultraButtonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonNew.Location = new System.Drawing.Point(474, 39);
            this.ultraButtonNew.Name = "ultraButtonNew";
            this.ultraButtonNew.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonNew.TabIndex = 2;
            this.ultraButtonNew.Text = "New";
            this.ultraButtonNew.Click += new System.EventHandler(this.ultraButtonNew_Click);
            // 
            // ultraButtonEdit
            // 
            this.ultraButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonEdit.Location = new System.Drawing.Point(393, 39);
            this.ultraButtonEdit.Name = "ultraButtonEdit";
            this.ultraButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonEdit.TabIndex = 1;
            this.ultraButtonEdit.Text = "Edit";
            this.ultraButtonEdit.Click += new System.EventHandler(this.ultraButtonEdit_Click);
            // 
            // ultraButtonDelete
            // 
            this.ultraButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonDelete.Location = new System.Drawing.Point(312, 39);
            this.ultraButtonDelete.Name = "ultraButtonDelete";
            this.ultraButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonDelete.TabIndex = 0;
            this.ultraButtonDelete.Text = "Delete";
            this.ultraButtonDelete.Click += new System.EventHandler(this.ultraButtonDelete_Click);
            // 
            // frmPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 367);
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmPatientList";
            this.Text = "PatientList";
            this.Load += new System.EventHandler(this.frmPatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPatientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            this.ultraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPatientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDTEDOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraButton ultraButtonRefresh;
        private Infragistics.Win.Misc.UltraButton ultraButtonNew;
        private Infragistics.Win.Misc.UltraButton ultraButtonEdit;
        private Infragistics.Win.Misc.UltraButton ultraButtonDelete;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridPatientList;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDOR;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor uDTEDOR;
        private Infragistics.Win.Misc.UltraButton ultraButtonSearch;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorPatientName;
        private Infragistics.Win.Misc.UltraButton ultraButtonBTMainPage;
        private Infragistics.Win.Misc.UltraLabel ulName;
    }
}