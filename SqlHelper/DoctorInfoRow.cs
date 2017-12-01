// <fileinfo name="DoctorInfoRow_Base.cs">
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
	/// The base class for <see cref="DoctorInfoRow"/> that 
	/// represents a record in the <c>DoctorInfo</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="DoctorInfoRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class DoctorInfoRow
	{
		private int _doctorIDD;
		private string _name;
		private string _address;
		private string _phone;

		/// <summary>
		/// Initializes a new instance of the <see cref="DoctorInfoRow"/> class.
		/// </summary>
		public DoctorInfoRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>DoctorIDD</c> column value.
		/// </summary>
		/// <value>The <c>DoctorIDD</c> column value.</value>
		public int DoctorIDD
		{
			get { return _doctorIDD; }
			set { _doctorIDD = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Name</c> column value.
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
		/// Gets or sets the <c>Phone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Phone</c> column value.</value>
		public string Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  DoctorIDD=");
			dynStr.Append(DoctorIDD);
			dynStr.Append("  Name=");
			dynStr.Append(Name);
			dynStr.Append("  Address=");
			dynStr.Append(Address);
			dynStr.Append("  Phone=");
			dynStr.Append(Phone);
			return dynStr.ToString();
		}
	} // End of DoctorInfoRow_Base class
} // End of namespace
