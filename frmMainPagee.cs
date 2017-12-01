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
    public partial class frmMainPagee : Form
    {
        public frmMainPagee()
        {
            InitializeComponent();
        }

        private void ultraPictureBox1_Click(object sender, EventArgs e)
        {
            frmDoctorList objfrmDoctorList = new frmDoctorList();
            objfrmDoctorList.Show();
            Visible = false;
        }

        private void ultraPictureBoxPatient_Click(object sender, EventArgs e)
        {
            frmPatientList objfrmPatientList = new frmPatientList();
            objfrmPatientList.Show();
            Visible = false;
        }

        private void ultraPictureBoxBed_Click(object sender, EventArgs e)
        {
            frmBedList objfrmBedList = new frmBedList();
            objfrmBedList.Show();
            Visible = false;
        }

        private void ultraPictureBoxVisit_Click(object sender, EventArgs e)
        {
            frmPatientVisit objfrmPatientVisit = new frmPatientVisit();
            objfrmPatientVisit.Show();
            Visible = false;
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void ultraTilePanel2_TileStateChanged(object sender, Infragistics.Win.Misc.TileStateChangedEventArgs e)
        {
            frmDoctorList objfrmDoctorList = new frmDoctorList();
            objfrmDoctorList.Show();
            Visible = false;
        }

        private void ultraTilePanelBed_TileStateChanged(object sender, Infragistics.Win.Misc.TileStateChangedEventArgs e)
        {
            frmBedList objfrmBedList = new frmBedList();
            objfrmBedList.Show();
            Visible = false;
        }

        private void ultraTilePanelVisit_TileStateChanged(object sender, Infragistics.Win.Misc.TileStateChangedEventArgs e)
        {
            frmPatientVisit objfrmPatientVisit = new frmPatientVisit();
            objfrmPatientVisit.Show();
            Visible = false;
        }

        private void ultraTilePanelDoctor_Click(object sender, EventArgs e)
        {

            frmPatientVisit objfrmPatientVisit = new frmPatientVisit();
            objfrmPatientVisit.Show();
            Visible = false;
        }

        private void ultraPictureBoxDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorList objfrmDoctorList = new frmDoctorList();
            objfrmDoctorList.Show();
            Visible = false;
        }

        private void ultraPictureBoxPatient_Click_1(object sender, EventArgs e)
        {
            frmPatientList objfrmPatientList = new frmPatientList();
            objfrmPatientList.Show();
            Visible = false;

        }

        private void ultraPictureBoxBed_Click_1(object sender, EventArgs e)
        {
            frmBedList objfrmBedList = new frmBedList();
            objfrmBedList.Show();
            Visible = false;
        }

        private void ultraPictureBoxVisit_Click_1(object sender, EventArgs e)
        {
            frmPatientVisit objfrmPatientVisit = new frmPatientVisit();
            objfrmPatientVisit.Show();
            Visible = false;
        }
    }
}
