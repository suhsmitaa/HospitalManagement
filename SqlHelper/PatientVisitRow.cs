// <fileinfo name="PatientVisitRow_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;

namespace MyCompany.MyProject.Db
{
	/// <summary>
	/// The base class for <see cref="PatientVisitRow"/> that 
	/// represents a record in the <c>PatientVisit</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="PatientVisitRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public  class PatientVisitRow
	{
		private int _id;
		private int _patientType;
		private bool _patientTypeNull = true;
		private int _doctorId;
		private bool _doctorIdNull = true;
		private int _bedId;
		private bool _bedIdNull = true;
		private System.DateTime _dateofVisit;
		private bool _dateofVisitNull = true;
		private System.DateTime _dateofDischarge;
		private bool _dateofDischargeNull = true;
		private string _symptoms;
		private string _disease;
		private string _treatment;

		/// <summary>
		/// Initializes a new instance of the <see cref="PatientVisitRow"/> class.
		/// </summary>
		public PatientVisitRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Id</c> column value.
		/// </summary>
		/// <value>The <c>Id</c> column value.</value>
		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PatientType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PatientType</c> column value.</value>
		public int PatientType
		{
			get
			{
				if(IsPatientTypeNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _patientType;
			}
			set
			{
				_patientTypeNull = false;
				_patientType = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="PatientType"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsPatientTypeNull
		{
			get { return _patientTypeNull; }
			set { _patientTypeNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>DoctorId</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DoctorId</c> column value.</value>
		public int DoctorId
		{
			get
			{
				if(IsDoctorIdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _doctorId;
			}
			set
			{
				_doctorIdNull = false;
				_doctorId = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="DoctorId"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDoctorIdNull
		{
			get { return _doctorIdNull; }
			set { _doctorIdNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BedId</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BedId</c> column value.</value>
		public int BedId
		{
			get
			{
				if(IsBedIdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _bedId;
			}
			set
			{
				_bedIdNull = false;
				_bedId = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="BedId"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsBedIdNull
		{
			get { return _bedIdNull; }
			set { _bedIdNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>DateofVisit</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DateofVisit</c> column value.</value>
		public System.DateTime DateofVisit
		{
			get
			{
				if(IsDateofVisitNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _dateofVisit;
			}
			set
			{
				_dateofVisitNull = false;
				_dateofVisit = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="DateofVisit"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDateofVisitNull
		{
			get { return _dateofVisitNull; }
			set { _dateofVisitNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>DateofDischarge</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DateofDischarge</c> column value.</value>
		public System.DateTime DateofDischarge
		{
			get
			{
				if(IsDateofDischargeNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _dateofDischarge;
			}
			set
			{
				_dateofDischargeNull = false;
				_dateofDischarge = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="DateofDischarge"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDateofDischargeNull
		{
			get { return _dateofDischargeNull; }
			set { _dateofDischargeNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Symptoms</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Symptoms</c> column value.</value>
		public string Symptoms
		{
			get { return _symptoms; }
			set { _symptoms = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Disease</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Disease</c> column value.</value>
		public string Disease
		{
			get { return _disease; }
			set { _disease = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Treatment</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Treatment</c> column value.</value>
		public string Treatment
		{
			get { return _treatment; }
			set { _treatment = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Id=");
			dynStr.Append(Id);
			dynStr.Append("  PatientType=");
			dynStr.Append(IsPatientTypeNull ? (object)"<NULL>" : PatientType);
			dynStr.Append("  DoctorId=");
			dynStr.Append(IsDoctorIdNull ? (object)"<NULL>" : DoctorId);
			dynStr.Append("  BedId=");
			dynStr.Append(IsBedIdNull ? (object)"<NULL>" : BedId);
			dynStr.Append("  DateofVisit=");
			dynStr.Append(IsDateofVisitNull ? (object)"<NULL>" : DateofVisit);
			dynStr.Append("  DateofDischarge=");
			dynStr.Append(IsDateofDischargeNull ? (object)"<NULL>" : DateofDischarge);
			dynStr.Append("  Symptoms=");
			dynStr.Append(Symptoms);
			dynStr.Append("  Disease=");
			dynStr.Append(Disease);
			dynStr.Append("  Treatment=");
			dynStr.Append(Treatment);
			return dynStr.ToString();
		}
	} // End of PatientVisitRow_Base class
} // End of namespace
