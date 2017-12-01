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
    public partial class frmBedRegister : Form
    {
        public string BedName { get; set; }
        Regex mRegxExpression;
        public string id;
        public string frmStrMode;
        SqlCommand query;
        HospitalDB objHospDB = null;
        public frmBedRegister()
        {
            InitializeComponent();
        }

        #region "Custom Method"
        private void LoadBedTypeCombo()
        {
            DataTable dtLoadBedType = LoadComboHelper.LoadBedCombo();
            ultraComboBedType.DataSource = dtLoadBedType;
            ultraComboBedType.DisplayMember = "BedType";
            ultraComboBedType.ValueMember = "BedType";
        }

        private void openfrmBedList()
        {
            //frmMain objfrmMain = new frmMain();
            frmBedList objfrmBedList = new frmBedList();
            objfrmBedList.Show();
            Visible = false;

        }
        #endregion
        private void ultraLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ultraButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.frmStrMode == "Edit")
                {
                    objHospDB = new HospitalDB();
                    BedInfo objBedInfo = new BedInfo(objHospDB);
                    BedInfoRow objBedInfoRow = new BedInfoRow();

                    objBedInfoRow.BedIDD = Convert.ToInt32(classtextEditorID.Text);
                    objBedInfoRow.BedName = ultraTextEditorBedName.Text;
                    objBedInfoRow.RatePerDay = Convert.ToInt32(classtERatePerDay.Text);
                    objBedInfoRow.BedType = ultraComboBedType.Value.ToString();
                    objBedInfo.Update(objBedInfoRow);
                    MessageBox.Show(":updated");
                    openfrmBedList();
                }
                else
                {
                    objHospDB = new HospitalDB();
                    BedInfo objBedInfo = new BedInfo(objHospDB);
                    BedInfoRow objBedInfoRow = new BedInfoRow();
                    objBedInfoRow.BedName = ultraTextEditorBedName.Text;
                    objBedInfoRow.RatePerDay = Convert.ToInt32(classtextEditorID.Text);
                    objBedInfoRow.BedType = ultraComboBedType.Text;

                    objBedInfo.Insert(objBedInfoRow);

                    MessageBox.Show(":Registerd");
                    openfrmBedList();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
  
        private void frmBedRegister_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadBedTypeCombo();
            classtextEditorID.Text = id;
         
        }

       

        private void ultraButtonCancel_Click(object sender, EventArgs e)
        {
           

            frmBedList objfrmBedList = new frmBedList();
            objfrmBedList.Show();
            Visible = false;

        }
    }
}
