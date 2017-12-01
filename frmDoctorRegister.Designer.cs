namespace DoctorListInfo
{
    partial class frmDoctorRegister
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorRegister));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraButtonCancel = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonRegister = new Infragistics.Win.Misc.UltraButton();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.classtextEditorID = new ClassLibrary1.Class4();
            this.classtePhone = new ClassLibrary1.Class4();
            this.ultraLabelID = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorAddress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditorName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox)).BeginInit();
            this.ultraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorName)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(581, 369);
            this.ultraGroupBox1.TabIndex = 0;
            // 
            // ultraGroupBox
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.ultraGroupBox.Appearance = appearance2;
            this.ultraGroupBox.Controls.Add(this.ultraButtonCancel);
            this.ultraGroupBox.Controls.Add(this.ultraButtonRegister);
            this.ultraGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox.Location = new System.Drawing.Point(3, 256);
            this.ultraGroupBox.Name = "ultraGroupBox";
            this.ultraGroupBox.Size = new System.Drawing.Size(575, 110);
            this.ultraGroupBox.TabIndex = 1;
            this.ultraGroupBox.Click += new System.EventHandler(this.ultraGroupBox_Click);
            // 
            // ultraButtonCancel
            // 
            this.ultraButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonCancel.Location = new System.Drawing.Point(476, 45);
            this.ultraButtonCancel.Name = "ultraButtonCancel";
            this.ultraButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonCancel.TabIndex = 18;
            this.ultraButtonCancel.Text = "Cancel";
            this.ultraButtonCancel.Click += new System.EventHandler(this.ultraButtonCancel_Click_1);
            // 
            // ultraButtonRegister
            // 
            this.ultraButtonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraButtonRegister.Location = new System.Drawing.Point(395, 45);
            this.ultraButtonRegister.Name = "ultraButtonRegister";
            this.ultraButtonRegister.Size = new System.Drawing.Size(75, 23);
            this.ultraButtonRegister.TabIndex = 16;
            this.ultraButtonRegister.Text = "Register";
            this.ultraButtonRegister.Click += new System.EventHandler(this.ultraButtonRegister_Click_1);
            // 
            // ultraGroupBox2
            // 
            appearance1.BackColor = System.Drawing.Color.Transparent;
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.ultraGroupBox2.Appearance = appearance1;
            this.ultraGroupBox2.Controls.Add(this.classtextEditorID);
            this.ultraGroupBox2.Controls.Add(this.classtePhone);
            this.ultraGroupBox2.Controls.Add(this.ultraLabelID);
            this.ultraGroupBox2.Controls.Add(this.ultraLabel3);
            this.ultraGroupBox2.Controls.Add(this.ultraLabel2);
            this.ultraGroupBox2.Controls.Add(this.ultraLabel1);
            this.ultraGroupBox2.Controls.Add(this.ultraTextEditorAddress);
            this.ultraGroupBox2.Controls.Add(this.ultraTextEditorName);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox2.Location = new System.Drawing.Point(3, 0);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(575, 366);
            this.ultraGroupBox2.TabIndex = 0;
            this.ultraGroupBox2.Click += new System.EventHandler(this.ultraGroupBox2_Click);
            // 
            // classtextEditorID
            // 
            this.classtextEditorID.Location = new System.Drawing.Point(78, 39);
            this.classtextEditorID.Name = "classtextEditorID";
            this.classtextEditorID.Size = new System.Drawing.Size(148, 20);
            this.classtextEditorID.TabIndex = 17;
            // 
            // classtePhone
            // 
            this.classtePhone.Location = new System.Drawing.Point(78, 121);
            this.classtePhone.Name = "classtePhone";
            this.classtePhone.Size = new System.Drawing.Size(148, 20);
            this.classtePhone.TabIndex = 16;
            // 
            // ultraLabelID
            // 
            this.ultraLabelID.Location = new System.Drawing.Point(3, 45);
            this.ultraLabelID.Name = "ultraLabelID";
            this.ultraLabelID.Size = new System.Drawing.Size(33, 23);
            this.ultraLabelID.TabIndex = 11;
            this.ultraLabelID.Text = "ID";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(3, 127);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(69, 23);
            this.ultraLabel3.TabIndex = 8;
            this.ultraLabel3.Text = "Phone";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(3, 98);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(69, 23);
            this.ultraLabel2.TabIndex = 7;
            this.ultraLabel2.Text = "Address";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(3, 71);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(69, 21);
            this.ultraLabel1.TabIndex = 6;
            this.ultraLabel1.Text = "Name";
            // 
            // ultraTextEditorAddress
            // 
            this.ultraTextEditorAddress.Location = new System.Drawing.Point(78, 94);
            this.ultraTextEditorAddress.Name = "ultraTextEditorAddress";
            this.ultraTextEditorAddress.Size = new System.Drawing.Size(148, 21);
            this.ultraTextEditorAddress.TabIndex = 4;
            // 
            // ultraTextEditorName
            // 
            this.ultraTextEditorName.Location = new System.Drawing.Point(78, 65);
            this.ultraTextEditorName.Name = "ultraTextEditorName";
            this.ultraTextEditorName.Size = new System.Drawing.Size(148, 21);
            this.ultraTextEditorName.TabIndex = 3;
            // 
            // frmDoctorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 369);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "frmDoctorRegister";
            this.Text = "frmDoctorRegister";
            this.Load += new System.EventHandler(this.frmDoctorRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox)).EndInit();
            this.ultraGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorAddress;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorName;
        private Infragistics.Win.Misc.UltraLabel ultraLabelID;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox;
        private Infragistics.Win.Misc.UltraButton ultraButtonCancel;
        private Infragistics.Win.Misc.UltraButton ultraButtonRegister;
        private ClassLibrary1.Class4 classtePhone;
        private ClassLibrary1.Class4 classtextEditorID;
    }
}