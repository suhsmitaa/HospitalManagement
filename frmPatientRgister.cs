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
    public partial class frmPatientRgister : Form
    {
        public string strFormMode;
        public string id;

        HospitalDB objHospDB = new HospitalDB();

        frmPatientList objfrmPatientList;
       // SqlConnection conn = new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");
        public frmPatientRgister()
        {
            InitializeComponent();
        }

        private void ultraLabel2_Click(object sender, EventArgs e)
        {

        }

        private void frmPatientRgister_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            classtextEditorID.Text = id;
        }

        private void ultraButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.strFormMode == "Edit")
                {
                    ultraButtonRegister.Text = "Update";
                    objHospDB = new HospitalDB();
                   // SqlCommand cmd =objHospDB.CreateCommand("update  PatientInfo set Name='" + ultraTextEditorName.Text + "',Address='" + ultraTextEditorAddress.Text + "',DateOfBirth='" + ultraDateTimeEditorPatientRgister.DateTime + "',Phone='" + classPhone.Text + "',EmergencyContact='" + classEmergencyContact.Text + "',DateOfRegistration='" + ultraDateTimeEditorDORPR.DateTime + "' where ID= '" + classtextEditorID.Text + "'");
                   // int obj = cmd.ExecuteNonQuery();
                PatientInfo objPatietntInfo = new PatientInfo(objHospDB);
                PatientInfoRow objPatientInforow = new PatientInfoRow();

                objPatientInforow.Id = Convert.ToInt32(classtextEditorID.Text);
                objPatientInforow.Name = ultraTextEditorName.Text;
                objPatientInforow.Address = ultraTextEditorAddress.Text;
                objPatientInforow.DateOfBirth = ultraDateTimeEditorPatientRgister.DateTime;
                objPatientInforow.Phone = Convert.ToInt32(classPhone.Text);
                objPatientInforow.EmergencyContact = Convert.ToInt32(classEmergencyContact.Text);
                objPatientInforow.DateOfRegistration = ultraDateTimeEditorDORPR.DateTime;
                
                objPatietntInfo.Update(objPatientInforow);

                MessageBox.Show(":updated");
                    //openfrmPatientList();
                    openPatientList();
                }
                else
                {
                    //conn.Open();
                    objHospDB = new HospitalDB();
                    PatientInfo objPatietntInfo = new PatientInfo(objHospDB);
                    PatientInfoRow objPatientInforow = new PatientInfoRow();


                    objPatientInforow.Name = ultraTextEditorName.Text;
                    objPatientInforow.Address = ultraTextEditorAddress.Text;
                    objPatientInforow.DateOfBirth = ultraDateTimeEditorPatientRgister.DateTime;
                    objPatientInforow.Phone =Convert.ToInt32( classPhone.Text);
                    objPatientInforow.EmergencyContact = Convert.ToInt32( classEmergencyContact.Text);
                    objPatientInforow.DateOfRegistration= ultraDateTimeEditorDORPR.DateTime;
                //SqlCommand cmd = objHospDB.CreateCommand("Insert into PatientInfo values('" + ultraTextEditorName.Text + "','" + ultraTextEditorAddress.Text + "','" + ultraDateTimeEditorPatientRgister.DateTime + "','" + classPhone.Text + "','" + classEmergencyContact.Text + "','" + ultraDateTimeEditorDORPR.DateTime + "')");
              
                objPatietntInfo.Insert(objPatientInforow);
                    MessageBox.Show( ":Registered");
                    //openfrmPatientList();
                    openPatientList();
                }
            }
             catch(Exception ex)
            {
                MessageBox.Show("error");
            }
            
        }

    

        private void openPatientList()
        {
            objfrmPatientList = new frmPatientList();
            objfrmPatientList.Show();
            Visible = false;
        }

        private void ultraButtonCancel_Click(object sender, EventArgs e)
        {
            objfrmPatientList = new frmPatientList();
            objfrmPatientList.Show();
            Visible = false;

        }

        private void ultraGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
