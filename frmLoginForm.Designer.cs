namespace DoctorListInfo
{
    partial class frmLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginForm));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.class31 = new ClassLibrary1.Class3();
            this.ultraTextEditorPW = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditorUN = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.classLogin = new ClassLibrary1.Class1();
            this.classPW = new ClassLibrary1.Class5();
            this.classUN = new ClassLibrary1.Class5();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.class31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorUN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // class31
            // 
            this.class31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("class31.BackgroundImage")));
            this.class31.Controls.Add(this.ultraTextEditorPW);
            this.class31.Controls.Add(this.ultraTextEditorUN);
            this.class31.Controls.Add(this.classLogin);
            this.class31.Controls.Add(this.classPW);
            this.class31.Controls.Add(this.classUN);
            this.class31.Dock = System.Windows.Forms.DockStyle.Top;
            this.class31.Location = new System.Drawing.Point(0, 0);
            this.class31.Name = "class31";
            this.class31.Size = new System.Drawing.Size(540, 81);
            this.class31.TabIndex = 0;
            this.class31.TabStop = false;
            // 
            // ultraTextEditorPW
            // 
            this.ultraTextEditorPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditorPW.Location = new System.Drawing.Point(337, 25);
            this.ultraTextEditorPW.Name = "ultraTextEditorPW";
            this.ultraTextEditorPW.Size = new System.Drawing.Size(116, 21);
            this.ultraTextEditorPW.TabIndex = 11;
            // 
            // ultraTextEditorUN
            // 
            this.ultraTextEditorUN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditorUN.Location = new System.Drawing.Point(156, 25);
            this.ultraTextEditorUN.Name = "ultraTextEditorUN";
            this.ultraTextEditorUN.Size = new System.Drawing.Size(116, 21);
            this.ultraTextEditorUN.TabIndex = 10;
            // 
            // classLogin
            // 
            this.classLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classLogin.Location = new System.Drawing.Point(459, 25);
            this.classLogin.Name = "classLogin";
            this.classLogin.Size = new System.Drawing.Size(75, 23);
            this.classLogin.TabIndex = 9;
            this.classLogin.Text = "Login";
            this.classLogin.UseVisualStyleBackColor = true;
            this.classLogin.Click += new System.EventHandler(this.classLogin_Click_1);
            // 
            // classPW
            // 
            this.classPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classPW.AutoSize = true;
            this.classPW.BackColor = System.Drawing.Color.Transparent;
            this.classPW.Location = new System.Drawing.Point(278, 31);
            this.classPW.Name = "classPW";
            this.classPW.Size = new System.Drawing.Size(53, 13);
            this.classPW.TabIndex = 8;
            this.classPW.Text = "Password";
            // 
            // classUN
            // 
            this.classUN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classUN.AutoSize = true;
            this.classUN.BackColor = System.Drawing.Color.Transparent;
            this.classUN.Location = new System.Drawing.Point(93, 31);
            this.classUN.Name = "classUN";
            this.classUN.Size = new System.Drawing.Size(57, 13);
            this.classUN.TabIndex = 7;
            this.classUN.Text = "UserName";
            // 
            // ultraGroupBox1
            // 
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.ultraGroupBox1.Appearance = appearance1;
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 290);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(540, 79);
            this.ultraGroupBox1.TabIndex = 1;
            // 
            // ultraGroupBox2
            // 
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.ultraGroupBox2.Appearance = appearance2;
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox2.Location = new System.Drawing.Point(0, 81);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(540, 209);
            this.ultraGroupBox2.TabIndex = 2;
            this.ultraGroupBox2.Click += new System.EventHandler(this.ultraGroupBox2_Click);
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 369);
            this.Controls.Add(this.ultraGroupBox2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.class31);
            this.Name = "frmLoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.frmLoginForm_Load);
            this.class31.ResumeLayout(false);
            this.class31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorUN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.Class3 class31;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorPW;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorUN;
        private ClassLibrary1.Class1 classLogin;
        private ClassLibrary1.Class5 classPW;
        private ClassLibrary1.Class5 classUN;
    }
}