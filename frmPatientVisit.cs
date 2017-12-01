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
using Infragistics.Win.UltraWinGrid;

namespace DoctorListInfo
{
    public partial class frmPatientVisit : Form
    {

        frmPatientVisitReg objfrmPatienVisitRegister;
        HospitalDB objHospDB = null;
        DataSet dsPatientVisit;
        DataTable dtPatientVisit = new DataTable();
        string id;
        UltraGridRow row;
        public frmPatientVisit()
        {
            InitializeComponent();
        }

   #region "Custom method"
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
            catch (Exception ex)
            {

            }
        }
        #endregion

        private void frmPatientVisit_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtPatientVisit.Columns.Add("Id");
            dtPatientVisit.Columns.Add("Patient Type");
            dtPatientVisit.Columns.Add("Doctor ID");
            dtPatientVisit.Columns.Add("Bed ID");
            dtPatientVisit.Columns.Add("Date Of Visit");
            dtPatientVisit.Columns.Add("Date Of Discharge");
            dtPatientVisit.Columns.Add("Symptoms");
            dtPatientVisit.Columns.Add("Disease");
            dtPatientVisit.Columns.Add("Treatment");

            ultraGridPatientVisit.DataSource = dtPatientVisit;
        }

        private void ultraButtonNew_Click(object sender, EventArgs e)
        {
            objfrmPatienVisitRegister = new frmPatientVisitReg();
            objfrmPatienVisitRegister.Show();
            Visible = false;
        }

        private void ultraButtonDelete_Click(object sender, EventArgs e)
        {
            ultraGridPatientVisit.Rows[this.ultraGridPatientVisit.ActiveRow.Index].Delete(true);
            try
            {
                //conn.Open();
                objHospDB = new HospitalDB();
                SqlCommand cmd = objHospDB.CreateCommand("delete from PatientVisitInfo where ID='" + this.id + "';");
                int o = cmd.ExecuteNonQuery();
                //conn.Close();
                MessageBox.Show(o + ":deleted");
                //conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ultraButtonRefresh_Click(object sender, EventArgs e)
        {
            dsPatientVisit = new DataSet();

            try
            {
                objHospDB = new HospitalDB();

                PatientVisitInfo objPatientVisitInfo = new PatientVisitInfo(objHospDB);
                dtPatientVisit = objPatientVisitInfo.GetAllAsDataTable();
                ultraGridPatientVisit.DataSource = dtPatientVisit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (objHospDB != null)
                {
                    objHospDB.Dispose();
                }
            }
        }

   

        private void ultraButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmPatientVisitReg objfrmPatientVisitRgister = new frmPatientVisitReg();
                objfrmPatientVisitRgister.id = id.ToString();
                objfrmPatientVisitRgister.strFormMode = "Edit";
                objfrmPatientVisitRgister.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void ultraButtonBTMainPage_Click(object sender, EventArgs e)
        {
            frmMainPagee objfrmmain = new frmMainPagee();
            objfrmmain.Show();
            Visible = false;
        }

        private void ultraButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                dsPatientVisit = new DataSet();
                objHospDB = new HospitalDB();
                //SqlCommand cmd = objhospdb.CreateCommand("select Name,DoctorId,BedId, PatientType,DateofVisit,DateofDischarge,Symptoms,Disease,Treatment from PatientInfo p left join PatientVisitInfo o on p.Id = o.Id where  Name like '%" + ultraTextEditorName.Text + "%' AND DateofVisit='" + ultraDateTimeEditorDOV.Value.ToString() + "' AND DateofDischarge='" + ultraDateTimeEditorDOA.Value.ToString() + "' ;");
                SqlCommand cmd = objHospDB.CreateCommand("dbo.PatientVisitInfoSearchAll");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = ultraTextEditorName.Text;
                cmd.Parameters.AddWithValue("@DateofVisit", SqlDbType.DateTime).Value = DateTime.Parse(ultraDateTimeEditorDOV.Text);
               // cmd.Parameters.AddWithValue("@DateofDischarge", SqlDbType.DateTime).Value = DateTime.Parse(ultraDateTimeEditorDOA.Text);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dsPatientVisit);
              ultraGridPatientVisit.DataSource = dsPatientVisit.Tables[0];
             //  ultraGridPatientVisit.DataSource = dtPatientVisit;
                ultraGridPatientVisit.DataBind();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
