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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void ultraTile1_StateChanged(object sender, Infragistics.Win.Misc.TileStateChangedEventArgs e)
        {

        }

        private void ultraPictureBox1_Click(object sender, EventArgs e)
        {
            frmDoctorList objfrmDoctroList = new frmDoctorList();
            objfrmDoctroList.Show();
            Visible = false;
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ultraPictureBox3_Click(object sender, EventArgs e)
        {
            frmBedList objfrmBedList = new frmBedList();
            objfrmBedList.Show();
            Visible = false;
        }

        private void ultraPictureBox2_Click(object sender, EventArgs e)
        {
            frmPatientList objfrmPatientList = new frmPatientList();
            objfrmPatientList.Show();
            Visible = false;
        }

        private void ultraPictureBox4_Click(object sender, EventArgs e)
        {
            frmPatientVisit objfrmPatientVisit = new frmPatientVisit();
            objfrmPatientVisit.Show();
            Visible = false;
        }
    }
}
