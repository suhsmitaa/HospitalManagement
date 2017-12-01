using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyCompany.MyProject.Db;

namespace DoctorListInfo
{
   
    public partial class frmMain : Form
    {

        public string id;
        public string ID;

        HospitalDB objHospitalDB = null;

        DataTable dtPatientListtbl = new DataTable();
        DataTable dtBedListtbl = new DataTable();
        DataTable dtDoctorList  = new DataTable();
        DataTable dtPatientVisit = new DataTable();

        Button btnDoctorList=new Button();

        DataSet dsBedList = new DataSet();
        DataSet dsPatientList = new DataSet();
        DataSet dsDoctorList = new DataSet();
        DataSet dsPatientVisit = new DataSet();

        DataRow dr;

        UltraGridRow row;
        SqlConnection conn = new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");
        public frmMain()
        {
            InitializeComponent();
        }


#region "Custom LoadMethods"
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadGridDoctorListTable();
            LoadGridBedListTable();
            LoadGridPatientListTable();
            LoadGridPatientVisitTable();
        }

        private void LoadGridPatientVisitTable()
        {
            dtPatientVisit.Columns.Add("Id");
            dtPatientVisit.Columns.Add("Patient Type");
            dtPatientVisit.Columns.Add("Doctor ID");
            dtPatientVisit.Columns.Add("Bed ID");
            dtPatientVisit.Columns.Add("Date Of Visit");
            dtPatientVisit.Columns.Add("Date Of Discharge");
            dtPatientVisit.Columns.Add("Symptoms");
            dtPatientVisit.Columns.Add("Disease");
            dtPatientVisit.Columns.Add("Treatment");

            ultraGridPatientVisit.DataSource=dtPatientVisit;
        }

        private void LoadGridPatientListTable()
        {
            dtPatientListtbl.Columns.Add("ID");
            dtPatientListtbl.Columns.Add("Name");
            dtPatientListtbl.Columns.Add("Address");
            dtPatientListtbl.Columns.Add("Date Of Birth");
            dtPatientListtbl.Columns.Add("Phone");
            dtPatientListtbl.Columns.Add("Emergency Contact");
            dtPatientListtbl.Columns.Add("Date Of Registration");

            ultraGridPatientList.DataSource = dtPatientListtbl;
        }

        private void LoadGridBedListTable()
        {
            dtBedListtbl.Columns.Add("ID");
            dtBedListtbl.Columns.Add("BedName");
            dtBedListtbl.Columns.Add("RatePerDay");
            dtBedListtbl.Columns.Add("BedType");

            ultraGridBedList.DataSource = dtBedListtbl;

        }

        private void LoadGridDoctorListTable()
        {
            dtDoctorList.Columns.Add("ID");
            dtDoctorList.Columns.Add("Name");
            dtDoctorList.Columns.Add("Address");
            dtDoctorList.Columns.Add("Phone");

            ultraGridDoctorList.DataSource = dtDoctorList;
        }

#endregion

#region "Custom Doctor Methods" 
        private void ultraButtonDoctorList_Click(object sender, EventArgs e)
        {
            frmDoctorList objfrmdoctorlist = new frmDoctorList();
            objfrmdoctorlist.Show();
            Visible = false;
        }

        private void ultraButtonNew_Click(object sender, EventArgs e)
        {
            frmDoctorRegister objDoctorRegister = new frmDoctorRegister();
            objDoctorRegister.Show();
            Visible = false;
        }

        private void ultraGridDoctorList_AfterRowActivate(object sender, EventArgs e)
        {

            row = this.ultraGridDoctorList.ActiveRow;
            if (row != null)
            {

                ID = row.Cells["DoctorIDD"].Text;

            }
            else
            {

            }
        }

        private void ultraButtonEdit_Click(object sender, EventArgs e)
        {
            frmDoctorRegister objDoctorRegister = new frmDoctorRegister();
            objDoctorRegister.ID = ID.ToString();
            objDoctorRegister.strFormMode = "Edit";
            objDoctorRegister.ShowDialog();
        }

        private void ultraButtonRefresh_Click(object sender, EventArgs e)
        {
            dsDoctorList = new DataSet();

            try {
                objHospitalDB = new HospitalDB();

                SqlCommand cmd = objHospitalDB.CreateCommand("select * from DoctorInfo");
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsDoctorList);

                ultraGridDoctorList.DataSource = dsDoctorList.Tables[0];

            } catch(Exception ex)
            {
                MessageBox.Show("Error");
            }

        }

        private void ultraButtonDelete_Click(object sender, EventArgs e)
        {
            ultraGridDoctorList.Rows[this.ultraGridDoctorList.ActiveRow.Index].Delete(true);
            // conn.Open();
            objHospitalDB = new HospitalDB();
            SqlCommand cmd = objHospitalDB.CreateCommand("delete from DoctorInfo where DoctorIDD='" + this.ID + "';");
            int o = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(o + ":deleted");

        }
        #endregion

 #region  "Custom Patient Method"

        private void ultraButtonEditPatient_Click(object sender, EventArgs e)
        {
            frmPatientRgister objfrmPatientRgister = new frmPatientRgister();
            objfrmPatientRgister.id = id.ToString();
            objfrmPatientRgister.strFormMode = "Edit";
            objfrmPatientRgister.ultraButtonRegister.Text = "Update";
            objfrmPatientRgister.ShowDialog();
        }

        private void ultraButtonNewPatient_Click(object sender, EventArgs e)
        {
            frmPatientRgister objfrmPatientRegister = new frmPatientRgister();
            objfrmPatientRegister.Show();
            Visible = false;

        }

        private void ultraGridPatientList_AfterRowActivate(object sender, EventArgs e)
        {
            row = this.ultraGridPatientList.ActiveRow;
            if (row != null)
            {

                id = row.Cells["Id"].Text;
            }
            else
            {

            }
        }

        private void ultraButtonDeletePatient_Click(object sender, EventArgs e)
        {

             ultraGridPatientList.Rows[this.ultraGridPatientList.ActiveRow.Index].Delete(true);
            // conn.Open();
            objHospitalDB = new HospitalDB();
            SqlCommand cmd = objHospitalDB.CreateCommand("delete from PatientInfo where ID='" + this.id + "';");
            int o = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(o + ":deleted");
        }
        private void ultraButtonRefreshPatient_Click(object sender, EventArgs e)
        {
            dsPatientList = new DataSet();
           
            try
            {
                objHospitalDB = new HospitalDB();
                SqlCommand cmd = objHospitalDB.CreateCommand("select * from PatientInfo ");
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsPatientList);

                ultraGridPatientList.DataSource = dsPatientList.Tables[0];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void ultraButtonSearchPatient_Click(object sender, EventArgs e)
        {
          

            dsPatientList = new DataSet();
            // conn.Open();
            objHospitalDB = new HospitalDB();
            SqlCommand cmd = objHospitalDB.CreateCommand("Select * from PatientInfo where Name like '%" + ultraTextEditorPatientName.Text + "%' AND DateOfBirth ='"+ ultraDateTimeEditorPatient .Text+ "';");
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dsPatientList);

            ultraGridPatientList.DataSource = dsPatientList.Tables[0];
            conn.Close();
        }
        #endregion

 #region "Custom Bed Methods"
        private void ultraButtonNewBed_Click(object sender, EventArgs e)
        {
          

            frmBedRegister objfrmBedReg = new frmBedRegister();
            objfrmBedReg.Show();
            Visible = false;
        }

        private void ultraGridBedList_AfterRowActivate(object sender, EventArgs e)
        {


            row = this.ultraGridBedList.ActiveRow;
            if (row != null)
            {

                id = row.Cells["BedIDD"].Text;
            }
            else
            {

            }
        }

        private void ultraButtonEditBed_Click(object sender, EventArgs e)
        {
            frmBedRegister objfrmBedRegister = new frmBedRegister();
            objfrmBedRegister.id = id.ToString();
            objfrmBedRegister.frmStrMode = "Edit";

            objfrmBedRegister.ShowDialog();
        }

        private void ultraButtonDeleteBed_Click(object sender, EventArgs e)
        {
            ultraGridBedList.Rows[this.ultraGridBedList.ActiveRow.Index].Delete(true);
            //conn.Open();
            objHospitalDB = new HospitalDB();
            SqlCommand cmd = objHospitalDB.CreateCommand("delete from BedInfo where BedIDD='" + this.id + "';");
            int o = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(o + ":deleted");
        }

        private void ultraButtonRefreshBed_Click(object sender, EventArgs e)
        {
            dsBedList = new DataSet();
            try
            {
                objHospitalDB = new HospitalDB();
                SqlCommand cmd = objHospitalDB.CreateCommand("select * from BedInfo ", false);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsBedList);
                ultraGridBedList.DataSource = dsBedList.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (objHospitalDB != null)
                {
                    objHospitalDB.Dispose();
                }
            }


            //conn.Open();
            //ultraGridBedList.Rows.Refresh(Infragistics.Win.UltraWinGrid.RefreshRow.RefreshDisplay);



            //conn.Close();
        }

        #endregion

#region "Custom PatientVisit"


        private void ultraButtonNewPatientVisit_Click(object sender, EventArgs e)
        {


            frmPatientVisitReg objfrmPatientVisitReg = new frmPatientVisitReg();
            objfrmPatientVisitReg.Show();
            Visible = false;
        }


        private void ultraButtonRefreshPatientVisit_Click(object sender, EventArgs e)
        {
            dsPatientVisit = new DataSet();

            try
            {
                objHospitalDB = new HospitalDB();
                SqlCommand cmd = objHospitalDB.CreateCommand("select * from PatientVisitInfo ", false);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsPatientList);
                ultraGridBedList.DataSource = dsPatientList.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (objHospitalDB != null)
                {
                    objHospitalDB.Dispose();
                }
            }

          

        }

        private void ultraGridPatientVisit_AfterRowActivate(object sender, EventArgs e)
        {

            try
            {

                row = this.ultraGridPatientVisit.ActiveRow;
                if (row != null)
                {

                    id = row.Cells["Id"].Text;
                }
                else
                {

                }
            }
            catch(Exception ex)
            {

            }
            
            
        }

        private void ultraButtonEditPatientVisit_Click(object sender, EventArgs e)
        {
            frmPatientVisitReg objfrmPatientVisitRgister = new frmPatientVisitReg();
            objfrmPatientVisitRgister.id = id.ToString();
            objfrmPatientVisitRgister.strFormMode = "Edit";
            objfrmPatientVisitRgister.ShowDialog();
        }

        private void ultraButtonDeletePatientVisit_Click(object sender, EventArgs e)
        {
            ultraGridPatientVisit.Rows[this.ultraGridPatientVisit.ActiveRow.Index].Delete(true);
            //conn.Open();
            objHospitalDB = new HospitalDB();
            SqlCommand cmd = objHospitalDB.CreateCommand("delete from PatientVisitInfo where ID='" + this.id + "';");
            int o = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(o + ":deleted");
           conn.Close();
        }

        private void ultraButtonSearchPatientVisit_Click(object sender, EventArgs e)
        {
           // dsPatientVisit = new DataSet();
           // LeftJoins();

            /* BindingSource bs = new BindingSource();
             bs.DataSource = ultraGridPatientVisit.DataSource;
             bs.Filter = "Name   like '%" + ultraTextEditorName.Text +"%'";
             ultraGridPatientVisit.DataSource = bs;*/

            
            conn.Open();
            dsPatientVisit = new DataSet();
            //LeftJoins();
            //SqlCommand cmd = new SqlCommand("Select * from PatientVisitInfo,PatientInfo where  Name like '%" + ultraTextEditorName.Text + "%' OR DateofVisit='" + ultraDateTimeEditorDOV.Text + "' OR DateofDischarge='" + ultraDateTimeEditorDOA.Text + "' ;", conn);
            SqlCommand cmd = new SqlCommand("select Name,DoctorId,BedId, PatientType,DateofVisit,DateofDischarge,Symptoms,Disease,Treatment from PatientInfo p left join PatientVisitInfo o on p.Id = o.Id where  Name like '%" + ultraTextEditorName.Text + "%' AND DateofVisit='" + ultraDateTimeEditorDOV.Value.ToString() + "' AND DateofDischarge='" + ultraDateTimeEditorDOA.Value.ToString() + "' ;", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dsPatientVisit);

            ultraGridPatientVisit.DataSource = dsPatientVisit.Tables[0];
            conn.Close();



        }

        private void LeftJoins()
        {
            dsPatientVisit = new DataSet();
            //ultraGridPatientVisit.Rows.Refresh(Infragistics.Win.UltraWinGrid.RefreshRow.RefreshDisplay);
            SqlCommand cmd = new SqlCommand("select Name,DoctorId,BedId, PatientType,DateofVisit,DateofDischarge,Symptoms,Disease,Treatment from PatientInfo p left join PatientVisitInfo o on p.Id = o.Id ", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dsPatientList);

            ultraGridPatientVisit.DataSource = dsPatientList.Tables[0];
        }

        #endregion

        private void ultraGridDoctorList_AfterPerformAction(object sender, AfterUltraGridPerformActionEventArgs e)
        {

        }

        private void ultraTabControlMain_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {

        }
    }
}
