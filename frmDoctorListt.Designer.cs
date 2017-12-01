namespace DoctorListInfo
{
    partial class frmDoctorList
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
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorList));
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridDoctorList = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButtonBTMainPage = new Infragistics.Win.Misc.UltraButton();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButtonNew = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonEdit = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonDelete = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonRefresh = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDoctorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraGridDoctorList);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox3);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(573, 419);
            this.ultraGroupBox1.TabIndex = 0;
            // 
            // ultraGridDoctorList
            // 
            appearance15.BackColor = System.Drawing.Color.White;
            this.ultraGridDoctorList.DisplayLayout.Appearance = appearance15;
            this.ultraGridDoctorList.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridDoctorList.DisplayLayout.MaxRowScrollRegions = 1;
            appearance16.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridDoctorList.DisplayLayout.Override.CardAreaAppearance = appearance16;
            this.ultraGridDoctorList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance17.FontData.BoldAsString = "True";
            appearance17.FontData.Name = "Arial";
            appearance17.FontData.SizeInPoints = 10F;
            appearance17.ForeColor = System.Drawing.Color.White;
            appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridDoctorList.DisplayLayout.Override.HeaderAppearance = appearance17;
            this.ultraGridDoctorList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridDoctorList.DisplayLayout.Override.RowSelectorAppearance = appearance18;
            appearance19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance19.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridDoctorList.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            this.ultraGridDoctorList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridDoctorList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridDoctorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGridDoctorList.Location = new System.Drawing.Point(3, 110);
            this.ultraGridDoctorList.Name = "ultraGridDoctorList";
            this.ultraGridDoctorList.Size = new System.Drawing.Size(567, 306);
            this.ultraGridDoctorList.TabIndex = 2;
            this.ultraGridDoctorList.AfterRowActivate += new System.EventHandler(this.ultraGridDoctorList_AfterRowActivate);
            this.ultraGridDoctorList.BeforeRowActivate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.ultraGridDoctorList_BeforeRowActivate);
            // 
            // ultraGroupBox3
            // 
            appearance13.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance13.ImageBackground")));
            this.ultraGroupBox3.Appearance = appearance13;
            this.ultraGroupBox3.Controls.Add(this.ultraButtonBTMainPage);
            this.ultraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox3.Location = new System.Drawing.Point(3, 0);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(567, 110);
            this.ultraGroupBox3.TabIndex = 1;
            // 
            // ultraButtonBTMainPage
            // 
            this.ultraButtonBTMainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonBTMainPage.Location = new System.Drawing.Point(390, 33);
            this.ultraButtonBTMainPage.Name = "ultraButtonBTMainPage";
            this.ultraButtonBTMainPage.Size = new System.Drawing.Size(156, 23);
            this.ultraButtonBTMainPage.TabIndex = 0;
            this.ultraButtonBTMainPage.Text = "Back To MainPage";
            this.ultraButtonBTMainPage.Click += new System.EventHandler(this.ultraButtonBTMainPage_Click);
            // 
            // ultraGroupBox2
            // 
            appearance14.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance14.ImageBackground")));
            this.ultraGroupBox2.Appearance = appearance14;
            this.ultraGroupBox2.Controls.Add(this.ultraButtonNew);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonEdit);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonDelete);
            this.ultraGroupBox2.Controls.Add(this.ultraButtonRefresh);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox2.Location = new System.Drawing.Point(0, 314);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(573, 105);
            this.ultraGroupBox2.TabIndex = 1;
            // 
            // ultraButtonNew
            // 
            this.ultraButtonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonNew.Location = new System.Drawing.Point(474, 39);
            this.ultraButtonNew.Name = "ultraButtonNew";
            this.ultraButtonNew.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonNew.TabIndex = 3;
            this.ultraButtonNew.Text = "New";
            this.ultraButtonNew.Click += new System.EventHandler(this.ultraButtonNew_Click);
            // 
            // ultraButtonEdit
            // 
            this.ultraButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonEdit.Location = new System.Drawing.Point(393, 39);
            this.ultraButtonEdit.Name = "ultraButtonEdit";
            this.ultraButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonEdit.TabIndex = 2;
            this.ultraButtonEdit.Text = "Edit";
            this.ultraButtonEdit.Click += new System.EventHandler(this.ultraButtonEdit_Click);
            // 
            // ultraButtonDelete
            // 
            this.ultraButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonDelete.Location = new System.Drawing.Point(312, 39);
            this.ultraButtonDelete.Name = "ultraButtonDelete";
            this.ultraButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonDelete.TabIndex = 1;
            this.ultraButtonDelete.Text = "Delete";
            this.ultraButtonDelete.Click += new System.EventHandler(this.ultraButtonDelete_Click);
            // 
            // ultraButtonRefresh
            // 
            this.ultraButtonRefresh.Location = new System.Drawing.Point(26, 39);
            this.ultraButtonRefresh.Name = "ultraButtonRefresh";
            this.ultraButtonRefresh.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonRefresh.TabIndex = 0;
            this.ultraButtonRefresh.Text = "Refresh";
            this.ultraButtonRefresh.Click += new System.EventHandler(this.ultraButtonRefresh_Click);
            // 
            // frmDoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 419);
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmDoctorList";
            this.Text = "DoctorList";
            this.Load += new System.EventHandler(this.frmDoctorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridDoctorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraButton ultraButtonNew;
        private Infragistics.Win.Misc.UltraButton ultraButtonEdit;
        private Infragistics.Win.Misc.UltraButton ultraButtonDelete;
        private Infragistics.Win.Misc.UltraButton ultraButtonRefresh;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridDoctorList;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.Misc.UltraButton ultraButtonBTMainPage;
    }
}

