// <fileinfo name="PatientVisitInfoCollection_Base.cs">
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
	/// The base class for <see cref="PatientVisitInfo"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="PatientVisitInfo"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class PatientVisitInfo
	{
		// Constants
		public const string IdColumnName = "Id";
		public const string PatientTypeColumnName = "PatientType";
		public const string DoctorIdColumnName = "DoctorId";
		public const string BedIdColumnName = "BedId";
		public const string DateofVisitColumnName = "DateofVisit";
		public const string DateofDischargeColumnName = "DateofDischarge";
		public const string SymptomsColumnName = "Symptoms";
		public const string DiseaseColumnName = "Disease";
		public const string TreatmentColumnName = "Treatment";

		// Instance fields
		private HospitalDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="PatientVisitInfo"/> 
		/// class with the specified <see cref="HospitalDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="HospitalDB"/> object.</param>
		public PatientVisitInfo(HospitalDB db)
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
		/// Gets an array of all records from the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		public virtual PatientVisitInfoRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._PatientVisitInfo_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="PatientVisitInfoRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="PatientVisitInfoRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public PatientVisitInfoRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			PatientVisitInfoRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="PatientVisitInfoRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		public PatientVisitInfoRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="PatientVisitInfoRow"/> objects that 
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
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		public virtual PatientVisitInfoRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[PatientVisitInfo]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="PatientVisitInfoRow"/> by the primary key.
		/// </summary>
		/// <param name="id">The <c>Id</c> column value.</param>
		/// <returns>An instance of <see cref="PatientVisitInfoRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual PatientVisitInfoRow GetByPrimaryKey(int id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_GetByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			PatientVisitInfoRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="PatientVisitInfoRow"/> objects 
		/// by the <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		public PatientVisitInfoRow[] GetByBedId(int bedId)
		{
			return GetByBedId(bedId, false);
		}

		/// <summary>
		/// Gets an array of <see cref="PatientVisitInfoRow"/> objects 
		/// by the <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <param name="bedIdNull">true if the method ignores the bedId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		public virtual PatientVisitInfoRow[] GetByBedId(int bedId, bool bedIdNull)
		{
			return MapRecords(CreateGetByBedIdCommand(bedId, bedIdNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByBedIdAsDataTable(int bedId)
		{
			return GetByBedIdAsDataTable(bedId, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <param name="bedIdNull">true if the method ignores the bedId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByBedIdAsDataTable(int bedId, bool bedIdNull)
		{
			return MapRecordsToDataTable(CreateGetByBedIdCommand(bedId, bedIdNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object that can be used to 
		/// return records by the <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <param name="bedIdNull">true if the method ignores the bedId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetByBedIdCommand(int bedId, bool bedIdNull)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_GetBy_BedId", true);
			AddParameter(cmd, "BedId", bedIdNull ? null : (object)bedId);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="PatientVisitInfoRow"/> objects 
		/// by the <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		public PatientVisitInfoRow[] GetByDoctorId(int doctorId)
		{
			return GetByDoctorId(doctorId, false);
		}

		/// <summary>
		/// Gets an array of <see cref="PatientVisitInfoRow"/> objects 
		/// by the <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <param name="doctorIdNull">true if the method ignores the doctorId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		public virtual PatientVisitInfoRow[] GetByDoctorId(int doctorId, bool doctorIdNull)
		{
			return MapRecords(CreateGetByDoctorIdCommand(doctorId, doctorIdNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByDoctorIdAsDataTable(int doctorId)
		{
			return GetByDoctorIdAsDataTable(doctorId, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <param name="doctorIdNull">true if the method ignores the doctorId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByDoctorIdAsDataTable(int doctorId, bool doctorIdNull)
		{
			return MapRecordsToDataTable(CreateGetByDoctorIdCommand(doctorId, doctorIdNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object that can be used to 
		/// return records by the <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <param name="doctorIdNull">true if the method ignores the doctorId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetByDoctorIdCommand(int doctorId, bool doctorIdNull)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_GetBy_DoctorId", true);
			AddParameter(cmd, "DoctorId", doctorIdNull ? null : (object)doctorId);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <param name="value">The <see cref="PatientVisitInfoRow"/> object to be inserted.</param>
		public virtual void Insert(PatientVisitInfoRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_Insert", true);
			AddParameter(cmd, "PatientType",
				value.IsPatientTypeNull ? DBNull.Value : (object)value.PatientType);
			AddParameter(cmd, "DoctorId",
				value.IsDoctorIdNull ? DBNull.Value : (object)value.DoctorId);
			AddParameter(cmd, "BedId",
				value.IsBedIdNull ? DBNull.Value : (object)value.BedId);
			AddParameter(cmd, "DateofVisit",
				value.IsDateofVisitNull ? DBNull.Value : (object)value.DateofVisit);
			AddParameter(cmd, "DateofDischarge",
				value.IsDateofDischargeNull ? DBNull.Value : (object)value.DateofDischarge);
			AddParameter(cmd, "Symptoms", value.Symptoms);
			AddParameter(cmd, "Disease", value.Disease);
			AddParameter(cmd, "Treatment", value.Treatment);
			value.Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <param name="value">The <see cref="PatientVisitInfoRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(PatientVisitInfoRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_Update", true);
			AddParameter(cmd, "PatientType",
				value.IsPatientTypeNull ? DBNull.Value : (object)value.PatientType);
			AddParameter(cmd, "DoctorId",
				value.IsDoctorIdNull ? DBNull.Value : (object)value.DoctorId);
			AddParameter(cmd, "BedId",
				value.IsBedIdNull ? DBNull.Value : (object)value.BedId);
			AddParameter(cmd, "DateofVisit",
				value.IsDateofVisitNull ? DBNull.Value : (object)value.DateofVisit);
			AddParameter(cmd, "DateofDischarge",
				value.IsDateofDischargeNull ? DBNull.Value : (object)value.DateofDischarge);
			AddParameter(cmd, "Symptoms", value.Symptoms);
			AddParameter(cmd, "Disease", value.Disease);
			AddParameter(cmd, "Treatment", value.Treatment);
			AddParameter(cmd, "Id", value.Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>PatientVisitInfo</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>PatientVisitInfo</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
		/// Deletes the specified object from the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <param name="value">The <see cref="PatientVisitInfoRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(PatientVisitInfoRow value)
		{
			return DeleteByPrimaryKey(value.Id);
		}

		/// <summary>
		/// Deletes a record from the <c>PatientVisitInfo</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="id">The <c>Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>PatientVisitInfo</c> table using the 
		/// <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByBedId(int bedId)
		{
			return DeleteByBedId(bedId, false);
		}

		/// <summary>
		/// Deletes records from the <c>PatientVisitInfo</c> table using the 
		/// <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <param name="bedIdNull">true if the method ignores the bedId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByBedId(int bedId, bool bedIdNull)
		{
			return CreateDeleteByBedIdCommand(bedId, bedIdNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object that can be used to
		/// delete records using the <c>FK_HospitalDB_BedInfo</c> foreign key.
		/// </summary>
		/// <param name="bedId">The <c>BedId</c> column value.</param>
		/// <param name="bedIdNull">true if the method ignores the bedId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteByBedIdCommand(int bedId, bool bedIdNull)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_DeleteBy_BedId", true);
			AddParameter(cmd, "BedId", bedIdNull ? null : (object)bedId);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>PatientVisitInfo</c> table using the 
		/// <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByDoctorId(int doctorId)
		{
			return DeleteByDoctorId(doctorId, false);
		}

		/// <summary>
		/// Deletes records from the <c>PatientVisitInfo</c> table using the 
		/// <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <param name="doctorIdNull">true if the method ignores the doctorId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByDoctorId(int doctorId, bool doctorIdNull)
		{
			return CreateDeleteByDoctorIdCommand(doctorId, doctorIdNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object that can be used to
		/// delete records using the <c>FK_HospitalDB_DoctorInfo</c> foreign key.
		/// </summary>
		/// <param name="doctorId">The <c>DoctorId</c> column value.</param>
		/// <param name="doctorIdNull">true if the method ignores the doctorId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteByDoctorIdCommand(int doctorId, bool doctorIdNull)
		{
			SqlCommand cmd = _db.CreateCommand("dbo._PatientVisitInfo_DeleteBy_DoctorId", true);
			AddParameter(cmd, "DoctorId", doctorIdNull ? null : (object)doctorId);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>PatientVisitInfo</c> records that match the specified criteria.
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
		/// to delete <c>PatientVisitInfo</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[PatientVisitInfo]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._PatientVisitInfo_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		protected PatientVisitInfoRow[] MapRecords(SqlCommand command)
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
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		protected PatientVisitInfoRow[] MapRecords(SqlDataReader reader)
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
		/// <returns>An array of <see cref="PatientVisitInfoRow"/> objects.</returns>
		protected virtual PatientVisitInfoRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int idColumnIndex = reader.GetOrdinal("Id");
			int patientTypeColumnIndex = reader.GetOrdinal("PatientType");
			int doctorIdColumnIndex = reader.GetOrdinal("DoctorId");
			int bedIdColumnIndex = reader.GetOrdinal("BedId");
			int dateofVisitColumnIndex = reader.GetOrdinal("DateofVisit");
			int dateofDischargeColumnIndex = reader.GetOrdinal("DateofDischarge");
			int symptomsColumnIndex = reader.GetOrdinal("Symptoms");
			int diseaseColumnIndex = reader.GetOrdinal("Disease");
			int treatmentColumnIndex = reader.GetOrdinal("Treatment");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					PatientVisitInfoRow record = new PatientVisitInfoRow();
					recordList.Add(record);

					record.Id = Convert.ToInt32(reader.GetValue(idColumnIndex));
					if(!reader.IsDBNull(patientTypeColumnIndex))
						record.PatientType = Convert.ToInt32(reader.GetValue(patientTypeColumnIndex));
					if(!reader.IsDBNull(doctorIdColumnIndex))
						record.DoctorId = Convert.ToInt32(reader.GetValue(doctorIdColumnIndex));
					if(!reader.IsDBNull(bedIdColumnIndex))
						record.BedId = Convert.ToInt32(reader.GetValue(bedIdColumnIndex));
					if(!reader.IsDBNull(dateofVisitColumnIndex))
						record.DateofVisit = Convert.ToDateTime(reader.GetValue(dateofVisitColumnIndex));
					if(!reader.IsDBNull(dateofDischargeColumnIndex))
						record.DateofDischarge = Convert.ToDateTime(reader.GetValue(dateofDischargeColumnIndex));
					if(!reader.IsDBNull(symptomsColumnIndex))
						record.Symptoms = Convert.ToString(reader.GetValue(symptomsColumnIndex));
					if(!reader.IsDBNull(diseaseColumnIndex))
						record.Disease = Convert.ToString(reader.GetValue(diseaseColumnIndex));
					if(!reader.IsDBNull(treatmentColumnIndex))
						record.Treatment = Convert.ToString(reader.GetValue(treatmentColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (PatientVisitInfoRow[])(recordList.ToArray(typeof(PatientVisitInfoRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="PatientVisitInfoRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="PatientVisitInfoRow"/> object.</returns>
		protected virtual PatientVisitInfoRow MapRow(DataRow row)
		{
			PatientVisitInfoRow mappedObject = new PatientVisitInfoRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Id"
			dataColumn = dataTable.Columns["Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Id = (int)row[dataColumn];
			// Column "PatientType"
			dataColumn = dataTable.Columns["PatientType"];
			if(!row.IsNull(dataColumn))
				mappedObject.PatientType = (int)row[dataColumn];
			// Column "DoctorId"
			dataColumn = dataTable.Columns["DoctorId"];
			if(!row.IsNull(dataColumn))
				mappedObject.DoctorId = (int)row[dataColumn];
			// Column "BedId"
			dataColumn = dataTable.Columns["BedId"];
			if(!row.IsNull(dataColumn))
				mappedObject.BedId = (int)row[dataColumn];
			// Column "DateofVisit"
			dataColumn = dataTable.Columns["DateofVisit"];
			if(!row.IsNull(dataColumn))
				mappedObject.DateofVisit = (System.DateTime)row[dataColumn];
			// Column "DateofDischarge"
			dataColumn = dataTable.Columns["DateofDischarge"];
			if(!row.IsNull(dataColumn))
				mappedObject.DateofDischarge = (System.DateTime)row[dataColumn];
			// Column "Symptoms"
			dataColumn = dataTable.Columns["Symptoms"];
			if(!row.IsNull(dataColumn))
				mappedObject.Symptoms = (string)row[dataColumn];
			// Column "Disease"
			dataColumn = dataTable.Columns["Disease"];
			if(!row.IsNull(dataColumn))
				mappedObject.Disease = (string)row[dataColumn];
			// Column "Treatment"
			dataColumn = dataTable.Columns["Treatment"];
			if(!row.IsNull(dataColumn))
				mappedObject.Treatment = (string)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>PatientVisitInfo</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "PatientVisitInfo";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("PatientType", typeof(int));
			dataColumn = dataTable.Columns.Add("DoctorId", typeof(int));
			dataColumn = dataTable.Columns.Add("BedId", typeof(int));
			dataColumn = dataTable.Columns.Add("DateofVisit", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("DateofDischarge", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Symptoms", typeof(string));
			dataColumn.MaxLength = 1000;
			dataColumn = dataTable.Columns.Add("Disease", typeof(string));
			dataColumn.MaxLength = 1000;
			dataColumn = dataTable.Columns.Add("Treatment", typeof(string));
			dataColumn.MaxLength = 1000;
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

				case "PatientType":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "DoctorId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "BedId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "DateofVisit":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "DateofDischarge":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Symptoms":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Disease":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Treatment":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of PatientVisitInfoCollection_Base class
}  // End of namespace
