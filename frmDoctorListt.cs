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
using System.Configuration;
using MyCompany.MyProject.Db;

namespace DoctorListInfo
{
    public partial class frmDoctorList : Form
    {

        public String id;
        frmDoctorRegister objDoctorRegister;
        public DataTable dtDoctorList = new DataTable();
        DataSet dsDoctorList = new DataSet();
       // SqlConnection conn=new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");

        HospitalDB objHospDB = new HospitalDB();

        public frmDoctorList()
        {
            InitializeComponent();
        }

        #region "Custom Method"
        private void LoadGridTable()
        {

            dtDoctorList.Columns.Add("ID");
            dtDoctorList.Columns.Add("Name");
            dtDoctorList.Columns.Add("Address");
            dtDoctorList.Columns.Add("Phone");

            ultraGridDoctorList.DataSource = dtDoctorList;

        }

        private void ultraGridDoctorList_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGridDoctorList.ActiveRow;
            if (row != null)
            {
                //this.txtFirstName.Text = row.Cells["First Name"].Text;
                id = row.Cells["DoctorIDD"].Text;
                // this.txtLastName.Text = row.Cells["Last Name"].Text;
            }
            else
            {

            }
        }
        #endregion

        private void frmDoctorList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadGridTable();
        }

      

        private void ultraButtonRefresh_Click(object sender, EventArgs e)
        {
            dsDoctorList = new DataSet();

            try
            {
                objHospDB = new HospitalDB();
                DoctorInfo objDoctorInfo = new DoctorInfo(objHospDB);
                dtDoctorList = objDoctorInfo.GetAllAsDataTable();
                ultraGridDoctorList.DataSource = dtDoctorList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

        }

        private void ultraButtonNew_Click(object sender, EventArgs e)
        {
            objDoctorRegister = new frmDoctorRegister();
            objDoctorRegister.Show();
            Visible = false;
        }

        private void ultraButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                ultraGridDoctorList.Rows[this.ultraGridDoctorList.ActiveRow.Index].Delete(true);
                objHospDB = new HospitalDB();
                DoctorInfo objDoctorInfo = new DoctorInfo(objHospDB);
                DoctorInfoRow objDoctroInfoRow = new DoctorInfoRow();

                objDoctroInfoRow.DoctorIDD = Convert.ToInt32(id);
                objDoctorInfo.Delete(objDoctroInfoRow);



                MessageBox.Show(":deleted");
            }catch(SqlException ex)
            {
                
                
                    MessageBox.Show(ex.Message);
               
            }
           


        }

        private void ultraButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objDoctorRegister = new frmDoctorRegister();
                objDoctorRegister.ID = id.ToString();
                objDoctorRegister.strFormMode = "Edit";
                objDoctorRegister.ShowDialog();

            }catch(Exception ex)
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

        private void ultraGridDoctorList_BeforeRowActivate(object sender, RowEventArgs e)
        {

        }
    }
}
