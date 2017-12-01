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
    public partial class frmPatienVisitRegister : Form
    {
        public string id;
        public string strFormMode;
        DataTable dtPatientVisit = new DataTable();
        DataTable dtPatientVisitBed = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");
        TextBox tbPatientVisit = new TextBox();

        HospitalDB objhospdb ;

        
        public frmPatienVisitRegister()
        {
            InitializeComponent();
        }


        #region "CUSTOM METHOD"
        private void LoadPatientType()
        {
            DataTable dtPatientType = LoadComboHelper.LoadPatientType();
            ultraComboPatientType.DataSource = dtPatientType;
            ultraComboPatientType.DisplayMember = "PatientType";
            ultraComboPatientType.ValueMember = "PatientType";

        }

#endregion
        private void frmPatienVisitRegister_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadTextbox();
            LoadPatientType();
            LoadComboBoxDoctorId();
            LoadComboBoxBedId();
            classtextEditorID.Text = id;
        }

        private void LoadTextbox()
        {
            tbPatientVisit.Location = new Point(380, 130);
            tbPatientVisit.Size = new Size(350,750);
            ultraGroupBox1.Controls.Add(tbPatientVisit);
        }

        private void LoadComboBoxDoctorId()
        {
            SqlCommand cmd = new SqlCommand("select distinct DoctorIDD from DoctorInfo ", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dtPatientVisit);
            ultraComboEditorDoctorId.Items.Add("--select--");
            foreach (DataRow Row in dtPatientVisit.Rows)
            {
                ultraComboEditorDoctorId.Items.Add(Row["DoctorIDD"].ToString());
            }
        }

        private void LoadComboBoxBedId()
        {
            SqlCommand cmd = new SqlCommand("select distinct BedIDD from BedInfo ", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dtPatientVisitBed);
            ultraComboEditorBedId.Items.Add("--select--");
            foreach (DataRow Row in dtPatientVisitBed.Rows)
            {
                ultraComboEditorBedId.Items.Add(Row["BedIDD"].ToString());
            }

        }

        private void ultraButtonRegister_Click(object sender, EventArgs e)
        {

            objhospdb = new HospitalDB();
            PatientVisitInfo objpatientVisitInfo = new PatientVisitInfo(objhospdb);
            PatientVisitInfoRow objPatientVisitInfoRow = new PatientVisitInfoRow();
            objPatientVisitInfoRow.PatientType = Convert.ToInt32( ultraComboPatientType.Text);
            objPatientVisitInfoRow.DoctorId =Convert.ToInt32(ultraComboEditorDoctorId.Text);
            objPatientVisitInfoRow.BedId =Convert.ToInt32(ultraComboEditorBedId.Text);
            objPatientVisitInfoRow.DateofVisit = ultraDateTimeEditorDOV.DateTime;
            objPatientVisitInfoRow.DateofDischarge = ultraDateTimeEditorDOD.DateTime;
            objPatientVisitInfoRow.Symptoms = ultraTextEditorSymptoms.Text;
            objPatientVisitInfoRow.Disease = ultraTextEditorDisease.Text;
            objPatientVisitInfoRow.Treatment = ultraTextEditorTreatment.Text;


            objpatientVisitInfo.Insert(objPatientVisitInfoRow);
           /*
            SqlCommand cmd = objhospdb.CreateCommand("insert into PatientVisitInfo values('" + ultraComboPatientType .Text+ "', '"+ultraComboEditorDoctorId.Text+ "','" + ultraComboEditorBedId.Text + "','" + ultraDateTimeEditorDOV .Text+ "','"+ ultraDateTimeEditorDOD .Text+ "','"+ ultraTextEditorSymptoms .Text+ "','"+ ultraTextEditorDisease .Text+ "','"+ ultraTextEditorTreatment .Text+ "')");
           int o = cmd.ExecuteNonQuery();
            conn.Close();*/

            MessageBox.Show(":Registered");
            openfrmMain();

        }

        private void openfrmMain()
        {
            frmMain objfrmMain = new frmMain();
            objfrmMain.Show();
            Visible = false;
        }

        private void ultraComboDoctorId_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
        
        }

        private void ultraComboPatientType_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void ultraButtonCancel_Click(object sender, EventArgs e)
        {
            frmMain objfrmMain = new frmMain();
            objfrmMain.Show();
            Visible = false;
        }

        private void ultraComboDoctorId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ultraComboEditorDoctorId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
