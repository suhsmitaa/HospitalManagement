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
using System.Text.RegularExpressions;
using MyCompany.MyProject.Db;

namespace DoctorListInfo
{

    public partial class frmDoctorRegister : Form
    {
        public string Name;
        public string Address;
        public string  phone;
        public string ID;

        HospitalDB objHospDB = new HospitalDB();
       
        Regex mRegxExpression;
        public string strFormMode;
        private int selectedRowIndex;
        frmDoctorList objfrmDoctorList = new frmDoctorList();
        public DataTable dtDoctorRegister=new DataTable();
        //SqlConnection conn = new SqlConnection("Data Source = cisma; Initial Catalog = DoctorList; Integrated Security = True");


        public frmDoctorRegister()
        {
            InitializeComponent();
        }

#region "custom method"
        public void SetSelectedRow(int rowIndex)
        { //passing value to textbox if its private
            if (rowIndex != -1)
            {
                selectedRowIndex = rowIndex;
                ultraTextEditorName.Text = dtDoctorRegister.Rows[rowIndex]["Name"].ToString();
                ultraTextEditorAddress.Text = dtDoctorRegister.Rows[rowIndex]["Address"].ToString();
                classtePhone.Text = dtDoctorRegister.Rows[rowIndex]["Phone"].ToString();



            }
        }

        private void openfrmDoctorList()
        {
            //frmMain objfrmMain = new frmMain();
            frmDoctorList objfrmDoctorList = new frmDoctorList();
            objfrmDoctorList.Show();
            Visible = false;
        }
        #endregion

        private void frmDoctorRegister_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            classtextEditorID.Text = ID;
            //LoadID();


        }

     

       

       

       

        private void ultraGroupBox2_Click(object sender, EventArgs e)
        {

        }

      

      

       

        private void ultraButtonCancel_Click_1(object sender, EventArgs e)
        {
            frmDoctorList objfrmDoctorList = new frmDoctorList();
            objfrmDoctorList.Show();
            Visible = false;
        }

      

        private void ultraButtonRegister_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (this.strFormMode == "Edit")
                {
                    
                    objHospDB = new HospitalDB();
                    DoctorInfo objDoctorInfo = new DoctorInfo(objHospDB);
                    DoctorInfoRow objDoctorInfoRow = new DoctorInfoRow();
                    objDoctorInfoRow.DoctorIDD = Convert.ToInt32(classtextEditorID.Text);
                    objDoctorInfoRow.Name = ultraTextEditorName.Text;
                    objDoctorInfoRow.Address = ultraTextEditorAddress.Text;
                    objDoctorInfoRow.Phone = classtePhone.Text;
                    objDoctorInfo.Update(objDoctorInfoRow);
                  

                    MessageBox.Show( ":updated");
                    openfrmDoctorList();
                }
                else
                {
                   
                    objHospDB = new HospitalDB();
                    DoctorInfo objDoctorInfo = new DoctorInfo(objHospDB);
                    DoctorInfoRow objDoctorInfoRow = new DoctorInfoRow();
                    // SqlCommand cmd = objHospDB.CreateCommand("insert into DoctorInfo values('" + ultraTextEditorName.Text + "','" + ultraTextEditorAddress.Text + "','" + classtePhone.Text + "');");
                    objDoctorInfoRow.Name = ultraTextEditorName.Text;
                    objDoctorInfoRow.Address = ultraTextEditorAddress.Text;
                    objDoctorInfoRow.Phone =classtePhone.Text;

                    objDoctorInfo.Insert(objDoctorInfoRow);
                    MessageBox.Show(":Registerd");
                    openfrmDoctorList();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error");
            }  
        }

        private void ultraGroupBox_Click(object sender, EventArgs e)
        {

        }
    }
}
