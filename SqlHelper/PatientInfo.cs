// <fileinfo name="PatientInfoCollection_Base.cs">
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
using System.Data;
using System.Data.SqlClient;

namespace MyCompany.MyProject.Db
{
	/// <summary>
	/// The base class for <see cref="PatientInfo"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="PatientInfo"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class PatientInfo
	{
		// Constants
		public const string IdColumnName = "Id";
		public const string NameColumnName = "Name";
		public const string AddressColumnName = "Address";
		public const string DateOfBirthColumnName = "DateOfBirth";
		public const string PhoneColumnName = "Phone";
		public const string EmergencyContactColumnName = "EmergencyContact";
		public const string DateOfRegistrationColumnName = "DateOfRegistration";

		// Instance fields
		private HospitalDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="PatientInfo"/> 
		/// class with the specified <see cref="HospitalDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="HospitalDB"/> object.</param>
		public PatientInfo(HospitalDB db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="HospitalDB"/> object.</value>
		protected HospitalDB Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>PatientInfo</c> table.
		/// </summary>
		/// <returns>An array of <see cref="PatientInfoRow"/> objects.</returns>
		public virtual PatientInfoRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>PatientInfo</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>PatientInfo</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._PatientInfo_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="PatientInfoRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="PatientInfoRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public PatientInfoRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			PatientInfoRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="PatientInfoRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="PatientInfoRow"/> objects.</returns>
		public PatientInfoRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="PatientInfoRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example:
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="PatientInfoRow"/> objects.</returns>
		public virtual PatientInfoRow[] GetAsArray(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(SqlDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(SqlDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object for the specified search criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			string sql = "SELECT * FROM [dbo].[PatientInfo]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="PatientInfoRow"/> by the primary key.
		/// </summary>
		/// <param name="id">The <c>Id</c> column value.</param>
		/// <returns>An instance of <see cref="PatientInfoRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual PatientInfoRow GetByPrimaryKey(int id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientInfo_GetByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			PatientInfoRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>PatientInfo</c> table.
		/// </summary>
		/// <param name="value">The <see cref="PatientInfoRow"/> object to be inserted.</param>
		public virtual void Insert(PatientInfoRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientInfo_Insert", true);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Address", value.Address);
			AddParameter(cmd, "DateOfBirth",
				value.IsDateOfBirthNull ? DBNull.Value : (object)value.DateOfBirth);
			AddParameter(cmd, "Phone",
				value.IsPhoneNull ? DBNull.Value : (object)value.Phone);
			AddParameter(cmd, "EmergencyContact",
				value.IsEmergencyContactNull ? DBNull.Value : (object)value.EmergencyContact);
			AddParameter(cmd, "DateOfRegistration",
				value.IsDateOfRegistrationNull ? DBNull.Value : (object)value.DateOfRegistration);
			value.Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

        public virtual void  Search(PatientInfoRow value)
        {
            SqlCommand cmd = _db.CreateCommand("dbo.PatientInfoSearchAll", true);
            AddParameter(cmd, "Name", value.Name);
            //AddParameter(cmd, "Address", value.Address);
            AddParameter(cmd, "DateOfBirth",
                value.IsDateOfBirthNull ? DBNull.Value : (object)value.DateOfBirth);
           // AddParameter(cmd, "Phone",
               // value.IsPhoneNull ? DBNull.Value : (object)value.Phone);
           // AddParameter(cmd, "EmergencyContact",
             //   value.IsEmergencyContactNull ? DBNull.Value : (object)value.EmergencyContact);
            //AddParameter(cmd, "DateOfRegistration",
              //  value.IsDateOfRegistrationNull ? DBNull.Value : (object)value.DateOfRegistration);
            //MapRecords(CreateGetAllCommand());
            //  PatientInfoRow[] tempArray = MapRecords(cmd);
           // MapRecords(cmd);
            //cmd.ExecuteNonQuery();
            //value.Id = Convert.ToInt32(cmd.ExecuteScalar());
        }


        /// <summary>
        /// Updates a record in the <c>PatientInfo</c> table.
        /// </summary>
        /// <param name="value">The <see cref="PatientInfoRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Update(PatientInfoRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientInfo_Update", true);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Address", value.Address);
			AddParameter(cmd, "DateOfBirth",
				value.IsDateOfBirthNull ? DBNull.Value : (object)value.DateOfBirth);
			AddParameter(cmd, "Phone",
				value.IsPhoneNull ? DBNull.Value : (object)value.Phone);
			AddParameter(cmd, "EmergencyContact",
				value.IsEmergencyContactNull ? DBNull.Value : (object)value.EmergencyContact);
			AddParameter(cmd, "DateOfRegistration",
				value.IsDateOfRegistrationNull ? DBNull.Value : (object)value.DateOfRegistration);
			AddParameter(cmd, "Id", value.Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>PatientInfo</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>PatientInfo</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
		/// argument when your code calls this method in an ADO.NET transaction context. Note that in 
		/// this case, after you call the Update method you need call either <c>AcceptChanges</c> 
		/// or <c>RejectChanges</c> method on the DataTable object.
		/// <code>
		/// MyDb db = new MyDb();
		/// try
		/// {
		///		db.BeginTransaction();
		///		db.MyCollection.Update(myDataTable, false);
		///		db.CommitTransaction();
		///		myDataTable.AcceptChanges();
		/// }
		/// catch(Exception)
		/// {
		///		db.RollbackTransaction();
		///		myDataTable.RejectChanges();
		/// }
		/// </code>
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		/// <param name="acceptChanges">Specifies whether this method calls the <c>AcceptChanges</c>
		/// method on the changed DataRow objects.</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((int)row["Id"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}

		/// <summary>
		/// Deletes the specified object from the <c>PatientInfo</c> table.
		/// </summary>
		/// <param name="value">The <see cref="PatientInfoRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(PatientInfoRow value)
		{
			return DeleteByPrimaryKey(value.Id);
		}

		/// <summary>
		/// Deletes a record from the <c>PatientInfo</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="id">The <c>Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientInfo_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>PatientInfo</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>The number of deleted records.</returns>
		public int Delete(string whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object that can be used 
		/// to delete <c>PatientInfo</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[PatientInfo]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>PatientInfo</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._PatientInfo_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="PatientInfoRow"/> objects.</returns>
		protected PatientInfoRow[] MapRecords(SqlCommand command)
		{
			using(SqlDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <returns>An array of <see cref="PatientInfoRow"/> objects.</returns>
		protected PatientInfoRow[] MapRecords(SqlDataReader reader)
		{
			int totalRecordCount = -1;
			return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to map.</param>
		/// <param name="length">The number of records to map.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="PatientInfoRow"/> objects.</returns>
		protected virtual PatientInfoRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int idColumnIndex = reader.GetOrdinal("Id");
			int nameColumnIndex = reader.GetOrdinal("Name");
			int addressColumnIndex = reader.GetOrdinal("Address");
			int dateOfBirthColumnIndex = reader.GetOrdinal("DateOfBirth");
			int phoneColumnIndex = reader.GetOrdinal("Phone");
			int emergencyContactColumnIndex = reader.GetOrdinal("EmergencyContact");
			int dateOfRegistrationColumnIndex = reader.GetOrdinal("DateOfRegistration");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					PatientInfoRow record = new PatientInfoRow();
					recordList.Add(record);

					record.Id = Convert.ToInt32(reader.GetValue(idColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(addressColumnIndex))
						record.Address = Convert.ToString(reader.GetValue(addressColumnIndex));
					if(!reader.IsDBNull(dateOfBirthColumnIndex))
						record.DateOfBirth = Convert.ToDateTime(reader.GetValue(dateOfBirthColumnIndex));
					if(!reader.IsDBNull(phoneColumnIndex))
						record.Phone = Convert.ToInt32(reader.GetValue(phoneColumnIndex));
					if(!reader.IsDBNull(emergencyContactColumnIndex))
						record.EmergencyContact = Convert.ToInt32(reader.GetValue(emergencyContactColumnIndex));
					if(!reader.IsDBNull(dateOfRegistrationColumnIndex))
						record.DateOfRegistration = Convert.ToDateTime(reader.GetValue(dateOfRegistrationColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (PatientInfoRow[])(recordList.ToArray(typeof(PatientInfoRow)));
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(SqlCommand command)
		{
			using(SqlDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(SqlDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}
		
		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to read.</param>
		/// <param name="length">The number of records to read.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable MapRecordsToDataTable(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;
			
			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
			dataTable.EndLoadData();

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="PatientInfoRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="PatientInfoRow"/> object.</returns>
		protected virtual PatientInfoRow MapRow(DataRow row)
		{
			PatientInfoRow mappedObject = new PatientInfoRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Id"
			dataColumn = dataTable.Columns["Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Id = (int)row[dataColumn];
			// Column "Name"
			dataColumn = dataTable.Columns["Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Name = (string)row[dataColumn];
			// Column "Address"
			dataColumn = dataTable.Columns["Address"];
			if(!row.IsNull(dataColumn))
				mappedObject.Address = (string)row[dataColumn];
			// Column "DateOfBirth"
			dataColumn = dataTable.Columns["DateOfBirth"];
			if(!row.IsNull(dataColumn))
				mappedObject.DateOfBirth = (System.DateTime)row[dataColumn];
			// Column "Phone"
			dataColumn = dataTable.Columns["Phone"];
			if(!row.IsNull(dataColumn))
				mappedObject.Phone = (int)row[dataColumn];
			// Column "EmergencyContact"
			dataColumn = dataTable.Columns["EmergencyContact"];
			if(!row.IsNull(dataColumn))
				mappedObject.EmergencyContact = (int)row[dataColumn];
			// Column "DateOfRegistration"
			dataColumn = dataTable.Columns["DateOfRegistration"];
			if(!row.IsNull(dataColumn))
				mappedObject.DateOfRegistration = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>PatientInfo</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "PatientInfo";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Name", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Address", typeof(string));
			dataColumn.MaxLength = 255;
			dataColumn = dataTable.Columns.Add("DateOfBirth", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Phone", typeof(int));
			dataColumn = dataTable.Columns.Add("EmergencyContact", typeof(int));
			dataColumn = dataTable.Columns.Add("DateOfRegistration", typeof(System.DateTime));
			return dataTable;
		}
		
		/// <summary>
		/// Adds a new parameter to the specified command.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.SqlCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		protected virtual SqlParameter AddParameter(SqlCommand cmd, string paramName, object value)
		{
			SqlParameter parameter;
			switch(paramName)
			{
				case "Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Address":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "DateOfBirth":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Phone":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "EmergencyContact":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "DateOfRegistration":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of PatientInfoCollection_Base class
}  // End of namespace
