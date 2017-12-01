using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoctorListInfo
{
    class LoadComboHelper
    {
        public static  DataTable LoadBedCombo()
        {
            DataTable dtComboBed = new DataTable();
            dtComboBed.Columns.Add("BedType");

            DataRow drBedType = dtComboBed.NewRow();
            drBedType["BedType"] = "Gatch Bed";
            dtComboBed.Rows.Add(drBedType);

            drBedType = dtComboBed.NewRow();
            drBedType["BedType"] = "Electric Bed";
            dtComboBed.Rows.Add(drBedType);

            drBedType = dtComboBed.NewRow();
            drBedType["BedType"] = "Strechers";
            dtComboBed.Rows.Add(drBedType);

            drBedType = dtComboBed.NewRow();
            drBedType["BedType"] = "Low Beds";
            dtComboBed.Rows.Add(drBedType);

            drBedType = dtComboBed.NewRow();
            drBedType["BedType"] = "Low Air Loss Beds";
            dtComboBed.Rows.Add(drBedType);

            drBedType = dtComboBed.NewRow();
            drBedType["BedType"] = "Circo-electric Beds";
            dtComboBed.Rows.Add(drBedType);

            drBedType = dtComboBed.NewRow();
            drBedType["BedType"] = "Clinitron Beds";
            dtComboBed.Rows.Add(drBedType);

            return dtComboBed;
        }

        public static DataTable LoadPatientType()
        {
            DataTable dtPatientType = new DataTable();

            dtPatientType.Columns.Add("PatientType");

            DataRow drPatientType = dtPatientType.NewRow();
            drPatientType["PatientType"] = "0";
            dtPatientType.Rows.Add(drPatientType);

            drPatientType = dtPatientType.NewRow();
            drPatientType["PatientType"] = "1";
            dtPatientType.Rows.Add(drPatientType);

            return dtPatientType;


        }
    }
}
