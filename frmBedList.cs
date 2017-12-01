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
    public partial class frmBedList : Form
    {
        public string id;
        DataTable dtBedList = new DataTable();
        frmBedRegister objfrmBedRegister;
        DataSet dsBedList = new DataSet();
        //SqlConnection conn = new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");

        HospitalDB objHospDB ;
        public frmBedList()
        {
            InitializeComponent();
        }

        #region "Custom Load"
        private void LoadBedListGridView()
        {
            dtBedList.Columns.Add("ID");
            dtBedList.Columns.Add("BedName");
            dtBedList.Columns.Add("RatePerDay");
            dtBedList.Columns.Add("BedType");

            ultraGridBedList.DataSource = dtBedList;

        }

        #endregion

        private void ultraButtonNew_Click(object sender, EventArgs e)
        {
            objfrmBedRegister = new frmBedRegister();
            objfrmBedRegister.Show();
            Visible = false;
        }

        private void frmBedList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadBedListGridView();

        }

     

        private void ultraButtonRefresh_Click(object sender, EventArgs e)
        {
            dsBedList = new DataSet();
            //ultraGridBedList.Rows.Refresh(Infragistics.Win.UltraWinGrid.RefreshRow.RefreshDisplay);
          try
            {
                objHospDB = new HospitalDB();
                BedInfo objBedinfo = new BedInfo(objHospDB);
                dtBedList = objBedinfo.GetAllAsDataTable();
                ultraGridBedList.DataSource = dtBedList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void ultraButtonDelete_Click(object sender, EventArgs e)
        {
            ultraGridBedList.Rows[this.ultraGridBedList.ActiveRow.Index].Delete(true);
            try
            {
                objHospDB = new HospitalDB();
                BedInfo objBedInfo = new BedInfo(objHospDB);
                BedInfoRow objBedInfoRow = new BedInfoRow();

                objBedInfoRow.BedIDD = Convert.ToInt32(id);
                objBedInfo.Delete(objBedInfoRow);
                //SqlCommand cmd = objHospDB.CreateCommand("delete from BedInfo where ID='" + this.id + "';");
                // int o = cmd.ExecuteNonQuery();
                // conn.Close();
                MessageBox.Show(":deleted");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ultraGridBedList_AfterRowActivate(object sender, EventArgs e)
        {

          
        }

        private void ultraButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objfrmBedRegister = new frmBedRegister();
                objfrmBedRegister.id = id.ToString();
                objfrmBedRegister.frmStrMode = "Edit";
                objfrmBedRegister.ShowDialog();
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

        private void ultraGridBedList_AfterRowActivate_1(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGridBedList.ActiveRow;
            if (row != null)
            {

                id = row.Cells["BedIDD"].Text;

            }
            else
            {

            }
        }
    }
}
