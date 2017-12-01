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
using Infragistics.Win.UltraWinGrid;
using MyCompany.MyProject.Db;

namespace DoctorListInfo
{
    public partial class frmPatientList : Form
    {

        public String id;
        HospitalDB objHospDB = new HospitalDB();
        DataTable dtPatientList = new DataTable();
        DataSet dsPatientList = new DataSet();
        frmPatientRgister objfrmPatientRgister;
        //SqlConnection conn = new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");

        public frmPatientList()
        {
            InitializeComponent();
        }

 #region  "Custom Method"

        private void LoadPatientList()
        {
            dtPatientList.Columns.Add("ID");
            dtPatientList.Columns.Add("Name");
            dtPatientList.Columns.Add("Address");
            dtPatientList.Columns.Add("Date Of Birth");
            dtPatientList.Columns.Add("Phone");
            dtPatientList.Columns.Add("Emergency Contact");
            dtPatientList.Columns.Add("Date Of Registration");

            ultraGridPatientList.DataSource = dtPatientList;
        }


        private void ultraGridPatientList_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGridPatientList.ActiveRow;
            if (row != null)
            {

                id = row.Cells["ID"].Text;

            }
            else
            {

            }

        }

        private void ultraGridPatientList_AfterCellActivate(object sender, EventArgs e)
        {

        }

  #endregion

        private void frmPatientList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadPatientList();
        }

     

        private void ultraButtonNew_Click(object sender, EventArgs e)
        {
            objfrmPatientRgister = new frmPatientRgister();
            objfrmPatientRgister.Show();
            Visible = false;
        }

        private void ultraButtonRefresh_Click(object sender, EventArgs e)
        {
            dsPatientList = new DataSet();
            try
            {
                objHospDB = new HospitalDB();
                PatientInfo objPatientInfo = new PatientInfo(objHospDB);
                dtPatientList = objPatientInfo.GetAllAsDataTable();
                ultraGridPatientList.DataSource = dtPatientList;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

    

        private void ultraButtonDelete_Click(object sender, EventArgs e)
        {
            ultraGridPatientList.Rows[this.ultraGridPatientList.ActiveRow.Index].Delete(true);

            try
            {
                objHospDB = new HospitalDB();
                PatientInfo objPatientInfo = new PatientInfo(objHospDB);
                PatientInfoRow objPatientInfoRow = new PatientInfoRow();
                objPatientInfoRow.Id = Convert.ToInt32(id);


                objPatientInfo.Delete(objPatientInfoRow);


                MessageBox.Show(":deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ultraButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objfrmPatientRgister = new frmPatientRgister();
                objfrmPatientRgister.id = id.ToString();
                objfrmPatientRgister.strFormMode = "Edit";
                objfrmPatientRgister.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void ultraButtonSearch_Click(object sender, EventArgs e)
        {
              try
            {

           DataSet ddsPatientList = new DataSet();
  
                
                objHospDB = new HospitalDB();

           SqlCommand cmd = objHospDB.CreateCommand("dbo.PatientInfoSearchAll");
          cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = ultraTextEditorPatientName.Text;
            cmd.Parameters.AddWithValue("@DateOfBirth",SqlDbType.DateTime).Value = DateTime.Parse(uDTEDOR.Text);
                SqlDataAdapter sda = new SqlDataAdapter();
                 sda.SelectCommand = cmd;
          
                sda.Fill(ddsPatientList);
          
                 ultraGridPatientList.DataSource = ddsPatientList.Tables[0];
                 ultraGridPatientList.DataBind();




             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }


        }


        private void ultraButtonBTMainPage_Click(object sender, EventArgs e)
        {
            frmMainPagee objfrmMainPage = new frmMainPagee();
            objfrmMainPage.Show();
            Visible = false;
        }

        private void ultraGroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
