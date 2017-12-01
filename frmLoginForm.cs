using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorListInfo
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void classLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ultraTextEditorPW.PasswordChar = '*';
        }

        private void classLogin_Click_1(object sender, EventArgs e)
        {
            if (ultraTextEditorUN.Text == "Admin" && ultraTextEditorPW.Text == "ADMIN")
            {
                frmMainPagee objfrmMain = new frmMainPagee();
                objfrmMain.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect UserName or PassWord");
            }
        }

        private void ultraGroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
