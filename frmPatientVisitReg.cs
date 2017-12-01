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
    public partial class frmPatientVisitReg : Form
    {
        HospitalDB    objHospDB = new HospitalDB();
        GroupBox groupBoxFirst=new GroupBox();
        GroupBox groupBoxSecond=new GroupBox();
        GroupBox groupBoxtab = new GroupBox();

        TabControl tabControlPatientVisitControl = new TabControl();
        TabPage tabPatientVisitAppointment= new TabPage("Appointments");
        TabPage tabPatientVisitDiaognistic = new TabPage("Diaognistic");

        Button btnRegister = new Button();
        Button btnCancel = new Button();

        TextBox tbID = new TextBox();
        TextBox tbSymptom = new TextBox();
        TextBox tbTreatment = new TextBox();
        TextBox tbDiaognasis = new TextBox();

        Label lblID = new Label();
        Label lblPatientType = new Label();
        Label lblDcotorId = new Label();
        Label lblBedId = new Label();
        Label lblDOV = new Label();
        Label lblDOR = new Label();
        Label lblsymptoms = new Label();
        Label lbldisease = new Label();
        Label lblTreatment=new Label();
       


        ComboBox comBoxPatientType = new ComboBox();
        ComboBox comBoxDoctorID = new ComboBox();
        ComboBox comBoxBedID = new ComboBox();

        DateTimePicker dtDOV = new DateTimePicker();
        DateTimePicker dtDOR = new DateTimePicker();
        //DateTimePicker
       

       


        public string id;
        public string strFormMode;
        public string dob;
        DataTable dtPatientVisit = new DataTable();
        DataTable dtPatientVisitBed = new DataTable();
      // SqlConnection conn = new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");


        public frmPatientVisitReg()
        {
            InitializeComponent();
        }
        #region "Custom Method"

        private void LoadPatientType()
        {
            DataTable dtPatientType = LoadComboHelper.LoadPatientType();
            comBoxPatientType.DataSource = dtPatientType;
            comBoxPatientType.DisplayMember = "PatientType";
            comBoxPatientType.ValueMember = "PatientType";

        }

        private void LoadComboBoxDoctorId()
        {
               objHospDB = new HospitalDB();
            SqlCommand cmd = objHospDB.CreateCommand("dbo.LoadDoctorID");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dtPatientVisit);
            comBoxDoctorID.Items.Add("--select--");
            foreach (DataRow Row in dtPatientVisit.Rows)
            {
                comBoxDoctorID.Items.Add(Row["DoctorIDD"].ToString());
            }
        }

        private void LoadComboBoxBedId()
        {
            objHospDB = new HospitalDB();
            SqlCommand cmd = objHospDB.CreateCommand("dbo.LoadBedId");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dtPatientVisitBed);
            comBoxBedID.Items.Add("--select--");
            foreach (DataRow Row in dtPatientVisitBed.Rows)
            {
                comBoxBedID.Items.Add(Row["BedIDD"].ToString());
            }

        }

        #endregion
        private void frmPatientVisitReg_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tbID.Text = id;
            LoadComboBoxDoctorId();
            LoadComboBoxBedId();
            LoadPatientType();
            GroupBoxFirst();
            GroupBoxSecond();
          


        }

        private void GroupBoxSecond()
        {
            groupBoxSecond.Name = "GroupBoxRegData";
            groupBoxSecond.Dock = DockStyle.Bottom;
            //groupBoxSecond.BackColor = Color.LightSkyBlue;
            groupBoxSecond.BackgroundImage =Image.FromFile("C://Users/cisma/Pictures/blue.jpg");
            groupBoxSecond.FlatStyle = FlatStyle.Standard;
            

            btnRegister.Location = new Point(1100, 30);
            btnRegister.Size = new Size(100,30);
            btnRegister.Text = "Register";
            btnRegister.Click += new EventHandler(btnRegister_click);
            groupBoxSecond.Controls.Add(btnRegister);

            btnCancel.Location = new Point(1205, 30);
            btnCancel.Size = new Size(100, 30);
            btnCancel.Text = "Cancel";
            btnCancel.Click += new EventHandler(btnCancel_click);
            groupBoxSecond.Controls.Add(btnCancel);

          
            this.Controls.Add(groupBoxSecond);
        }

        private void btnCancel_click(object sender, EventArgs e)
        {
            frmPatientVisit objfrmMain = new frmPatientVisit();
            objfrmMain.Show();
            Visible = false;

        }

        private void btnRegister_click(object sender, EventArgs e)
        {

            if (this.strFormMode == "Edit")
            {
                btnRegister.Text = "Update";
                   objHospDB = new HospitalDB();
                SqlCommand cmd =    objHospDB.CreateCommand("update  PatientVisitInfo set PatientType='" + comBoxPatientType.Text + "',DoctorId='" + comBoxDoctorID.Text + "',BedId='" + comBoxBedID.Text + "',DateofVisit='" + dtDOV.Value.ToString() + "',DateofDischarge='" + dtDOR.Value.ToString() + "',Symptoms='" + tbSymptom.Text + "',Disease='" + tbDiaognasis.Text + "',Treatment='" + tbTreatment.Text + "' where ID= '" + tbID.Text + "'");
                int obj = cmd.ExecuteNonQuery();
               // conn.Close();

                MessageBox.Show(obj + ":updated");
                openfrmMain();
            }
            else
            {
                // conn.Open();
                   objHospDB = new HospitalDB();
                /*
                PatientVisitInfo objpatientVisitInfo = new PatientVisitInfo(   objHospDB);
                PatientVisitInfoRow objPatientVisitInfoRow = new PatientVisitInfoRow();
                objPatientVisitInfoRow.PatientType = Convert.ToInt32(comBoxPatientType.Text);
                objPatientVisitInfoRow.DoctorId = Convert.ToInt32(comBoxDoctorID.Text);
                objPatientVisitInfoRow.BedId = Convert.ToInt32(comBoxBedID.Text);
                //objPatientVisitInfoRow.DateofVisit = dtDOV.Value.ToString();
               // objPatientVisitInfoRow.DateofDischarge = dtDOR.Value.ToString();
                objPatientVisitInfoRow.Symptoms = tbSymptom.Text;
                objPatientVisitInfoRow.Disease = tbDiaognasis.Text;
                objPatientVisitInfoRow.Treatment = tbTreatment.Text;


                objpatientVisitInfo.Insert(objPatientVisitInfoRow);*/
                SqlCommand cmd=   objHospDB.CreateCommand("insert into PatientVisitInfo values('" + comBoxPatientType.Text + "', '" + comBoxDoctorID.Text + "','" + comBoxBedID.Text + "','" + dtDOV.Value.ToString() + "','" + dtDOR.Value.ToString() + "','" + tbSymptom.Text + "','" + tbDiaognasis.Text + "','" + tbTreatment.Text + "')");
                int o = cmd.ExecuteNonQuery();
               // conn.Close();

                MessageBox.Show(":Registered");
                openfrmMain();
            }
            
        }

        private void openfrmMain()
        {
            //frmMain objfrmMain = new frmMain();
            frmPatientVisit objfrmPatientVisit = new frmPatientVisit();
            objfrmPatientVisit.Show();
            Visible = false;
        }

        private void GroupBoxFirst()
        {
            groupBoxFirst.Name = "GroupBoxRegData";
            groupBoxFirst.Dock = DockStyle.Fill;
            groupBoxFirst.Text = "PatientVisitInfo";
            //groupBoxFirst.BackColor = Color.LightSteelBlue;
            groupBoxFirst.BackgroundImage = Image.FromFile("C:\\Users\\cisma\\Pictures\\blue.jpg");
            this.Controls.Add(groupBoxFirst);

            tabControlPatientVisitControl.Dock = DockStyle.Fill;

            tabControlPatientVisitControl.TabPages.Add(tabPatientVisitAppointment);
           tabControlPatientVisitControl.TabPages.Add(tabPatientVisitDiaognistic);
            

            lblID.Location = new Point(30,40);
            lblID.Size = new Size(40, 20);
            lblID.Text = "ID";
            tabPatientVisitAppointment.Controls.Add(lblID);

            tbID.Location = new Point(157,30);
            tbID.Size = new Size(200,20);
            tbID.Multiline = true;
            tabPatientVisitAppointment.Controls.Add(tbID);

            lblPatientType.Location = new Point(30, 65);
            lblPatientType.Size = new Size(80, 20);
            lblPatientType.Text = "PatientType" ;
            tabPatientVisitAppointment.Controls.Add(lblPatientType);

            comBoxPatientType.Location = new Point(157,60);
            comBoxPatientType.Size = new Size(200, 25);
            comBoxPatientType.Name = "ultraComboPatientType";
            tabPatientVisitAppointment.Controls.Add(comBoxPatientType);

            lblDcotorId.Location = new Point(30,95);
            lblDcotorId.Size = new Size(80,20);
            lblDcotorId.Text = "DoctorId";
            tabPatientVisitAppointment.Controls.Add(lblDcotorId);


            comBoxDoctorID.Location = new Point(157, 90);
            comBoxDoctorID.Size = new Size(200, 0);
            tabPatientVisitAppointment.Controls.Add(comBoxDoctorID);

            lblBedId.Location = new Point(30, 125);
            lblBedId.Size = new Size(80, 20);
            lblBedId.Text = "BedId";
            tabPatientVisitAppointment.Controls.Add(lblBedId);

            comBoxBedID.Location = new Point(157, 120);
            comBoxBedID.Size = new Size(200, 0);
            tabPatientVisitAppointment.Controls.Add(comBoxBedID);

            lblDOV.Location = new Point(30,155);
            lblDOV.Size = new Size(110,20);
            lblDOV.Text = "Date Of Visit";
            tabPatientVisitAppointment.Controls.Add(lblDOV);

            dtDOV.Location = new Point(157, 150);
            dtDOV.Size = new Size(200, 0);
            tabPatientVisitAppointment.Controls.Add(dtDOV);


            lblDOR.Location = new Point(30,185);
            lblDOR.Size = new Size(110,20);
            lblDOR.Text = "Date Of Discharge";
            tabPatientVisitAppointment.Controls.Add(lblDOR);

            dtDOR.Location = new Point(157, 180);
            dtDOR.Size = new Size(200, 0);
            tabPatientVisitAppointment.Controls.Add(dtDOR);

            lblsymptoms.Location = new Point(30,70);
            lblsymptoms.Size = new Size(80,40);
            lblsymptoms.Text = "Symptoms";
            tabPatientVisitDiaognistic.Controls.Add(lblsymptoms);

            tbSymptom.Location = new Point(120, 30);
            tbSymptom.Size = new Size(400, 60);
            tbSymptom.Multiline = true;
            tabPatientVisitDiaognistic.Controls.Add(tbSymptom);

            lbldisease.Location = new Point(30, 140);
            lbldisease.Size = new Size(80, 40);
            lbldisease.Text = "Disease";
            tabPatientVisitDiaognistic.Controls.Add(lbldisease);

            tbDiaognasis.Location = new Point(120, 100);
            tbDiaognasis.Size = new Size(400, 60);
            tbDiaognasis.Multiline = true;
            tabPatientVisitDiaognistic.Controls.Add(tbDiaognasis);

            lblTreatment.Location = new Point(30, 210);
            lblTreatment.Size = new Size(80, 40);
            lblTreatment.Text = "Treatment";
            tabPatientVisitDiaognistic.Controls.Add(lblTreatment);

            tbTreatment.Location = new Point(120, 170);
            tbTreatment.Size = new Size(400, 60);
            tbTreatment.Multiline = true;
            tabPatientVisitDiaognistic.Controls.Add(tbTreatment);


            groupBoxFirst.Controls.Add(tabControlPatientVisitControl);


        }
    }
}
