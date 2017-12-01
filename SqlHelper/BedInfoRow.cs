// <fileinfo name="BedInfoRow_Base.cs">
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
	/// The base class for <see cref="BedInfoRow"/> that 
	/// represents a record in the <c>BedInfo</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="BedInfoRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public  class BedInfoRow
	{
		private int _bedIDD;
		private string _bedName;
		private int _ratePerDay;
		private bool _ratePerDayNull = true;
		private string _bedType;

		/// <summary>
		/// Initializes a new instance of the <see cref="BedInfoRow"/> class.
		/// </summary>
		public BedInfoRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>BedIDD</c> column value.
		/// </summary>
		/// <value>The <c>BedIDD</c> column value.</value>
		public int BedIDD
		{
			get { return _bedIDD; }
			set { _bedIDD = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BedName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BedName</c> column value.</value>
		public string BedName
		{
			get { return _bedName; }
			set { _bedName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>RatePerDay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>RatePerDay</c> column value.</value>
		public int RatePerDay
		{
			get
			{
				if(IsRatePerDayNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _ratePerDay;
			}
			set
			{
				_ratePerDayNull = false;
				_ratePerDay = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="RatePerDay"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsRatePerDayNull
		{
			get { return _ratePerDayNull; }
			set { _ratePerDayNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BedType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BedType</c> column value.</value>
		public string BedType
		{
			get { return _bedType; }
			set { _bedType = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  BedIDD=");
			dynStr.Append(BedIDD);
			dynStr.Append("  BedName=");
			dynStr.Append(BedName);
			dynStr.Append("  RatePerDay=");
            dynStr.Append(IsRatePerDayNull ? (object)"<NULL>" : RatePerDay);
           // dynStr.Append(RatePerDay);
            dynStr.Append("  BedType=");
			dynStr.Append(BedType);
			return dynStr.ToString();
		}
	} // End of BedInfoRow_Base class
} // End of namespace
