// <fileinfo name="PatientInfoRow_Base.cs">
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
using System.Data.SqlClient;

namespace MyCompany.MyProject.Db
{
	/// <summary>
	/// The base class for <see cref="PatientInfoRow"/> that 
	/// represents a record in the <c>PatientInfo</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="PatientInfoRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class PatientInfoRow
	{
		private int _id;
		private string _name;
		private string _address;
		private System.DateTime _dateOfBirth;
		private bool _dateOfBirthNull = true;
		private int _phone;
		private bool _phoneNull = true;
		private int _emergencyContact;
		private bool _emergencyContactNull = true;
		private System.DateTime _dateOfRegistration;
		private bool _dateOfRegistrationNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="PatientInfoRow"/> class.
		/// </summary>
		public PatientInfoRow()
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
		/// Gets or sets the <c>Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Name</c> column value.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Address</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Address</c> column value.</value>
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the <c>DateOfBirth</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DateOfBirth</c> column value.</value>
		public System.DateTime DateOfBirth
		{
			get
			{
				if(IsDateOfBirthNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _dateOfBirth;
			}
			set
			{
				_dateOfBirthNull = false;
				_dateOfBirth = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="DateOfBirth"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDateOfBirthNull
		{
			get { return _dateOfBirthNull; }
			set { _dateOfBirthNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Phone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Phone</c> column value.</value>
		public int Phone
		{
			get
			{
				if(IsPhoneNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _phone;
			}
			set
			{
				_phoneNull = false;
				_phone = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Phone"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsPhoneNull
		{
			get { return _phoneNull; }
			set { _phoneNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EmergencyContact</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EmergencyContact</c> column value.</value>
		public int EmergencyContact
		{
			get
			{
				if(IsEmergencyContactNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _emergencyContact;
			}
			set
			{
				_emergencyContactNull = false;
				_emergencyContact = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="EmergencyContact"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsEmergencyContactNull
		{
			get { return _emergencyContactNull; }
			set { _emergencyContactNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>DateOfRegistration</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DateOfRegistration</c> column value.</value>
		public System.DateTime DateOfRegistration
		{
			get
			{
				if(IsDateOfRegistrationNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _dateOfRegistration;
			}
			set
			{
				_dateOfRegistrationNull = false;
				_dateOfRegistration = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="DateOfRegistration"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDateOfRegistrationNull
		{
			get { return _dateOfRegistrationNull; }
			set { _dateOfRegistrationNull = value; }
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
			dynStr.Append("  Name=");
			dynStr.Append(Name);
			dynStr.Append("  Address=");
			dynStr.Append(Address);
			dynStr.Append("  DateOfBirth=");
			dynStr.Append(IsDateOfBirthNull ? (object)"<NULL>" : DateOfBirth);
			dynStr.Append("  Phone=");
			dynStr.Append(IsPhoneNull ? (object)"<NULL>" : Phone);
			dynStr.Append("  EmergencyContact=");
			dynStr.Append(IsEmergencyContactNull ? (object)"<NULL>" : EmergencyContact);
			dynStr.Append("  DateOfRegistration=");
			dynStr.Append(IsDateOfRegistrationNull ? (object)"<NULL>" : DateOfRegistration);
			return dynStr.ToString();
		}
	} // End of PatientInfoRow_Base class
} // End of namespace
