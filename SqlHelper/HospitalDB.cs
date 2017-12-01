using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;

namespace MyCompany.MyProject.Db
{
    public class HospitalDB : IDisposable
    {
        SqlConnection _connection;
        SqlTransaction _transaction;

        public enum ActiveState
        {
            Active, All
        }

        public HospitalDB()
		{
			InitConnection();
		}		

        protected void InitConnection()
        {
            try
            {
                _connection = CreateConnection();
                _connection.Open();
            }
            catch (Exception ex)
            {
                _connection = null;
                MessageBox.Show("Connection with the server could not be established!", "System Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		protected internal  SqlDataReader ExecuteReader(SqlCommand command)
		{
			return command.ExecuteReader();
		}
		public SqlConnection Connection
		{
			get { return _connection; }
		}

		/// <summary>
		/// Begins a new database transaction.
		/// </summary>
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// <returns>An object representing the new transaction.</returns>
        public SqlTransaction BeginTransaction()
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction();
			return _transaction;
		}

		/// <summary>
		/// Begins a new database transaction with the specified 
		/// transaction isolation level.
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		/// <param name="isolationLevel">The transaction isolation level.</param>
		/// <returns>An object representing the new transaction.</returns>
        public SqlTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction(isolationLevel);
			return _transaction;
		}

		/// <summary>
		/// Commits the current database transaction.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		public void CommitTransaction()
		{
			CheckTransactionState(true);
			_transaction.Commit();
			_transaction = null;
		}

		/// <summary>
		/// Rolls back the current transaction from a pending state.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="CommitTransaction"/>
		/// </summary>
		public void RollbackTransaction()
		{
			CheckTransactionState(true);
			_transaction.Rollback();
			_transaction = null;
		}

		// Checks the state of the current transaction
		private void CheckTransactionState(bool mustBeOpen)
		{
			if(mustBeOpen)
			{
				if(null == _transaction)
					throw new InvalidOperationException("Transaction is not open.");
			}
			else
			{
				if(null != _transaction)
					throw new InvalidOperationException("Transaction is already open.");
			}
		}

        protected SqlConnection CreateConnection()
		{
            string srvString = ""; 
            string dbString = "";
            string userName = "";
            string password = "";
            System.Xml.XmlDocument xmlConfig = new XmlDocument();
            string tempDirectoryPath = Application.StartupPath;         
            //tempDirectoryPath = tempDirectoryPath.Remove(tempDirectoryPath.IndexOf("bin"), 9);
            xmlConfig.Load(tempDirectoryPath + @"\XMLFiles\DMTServer.config");
            XmlNodeList xmlNode = xmlConfig.SelectNodes("Home/ConnValue");
            foreach (XmlNode xmlN in xmlNode)
            {
                srvString = xmlN.ChildNodes[0].FirstChild.Value;
                dbString = xmlN.ChildNodes[1].FirstChild.Value;
                userName = xmlN.ChildNodes[2].FirstChild.Value;
                password = xmlN.ChildNodes[3].FirstChild.Value;
            }
            #if ODBC
			            return new System.Data.Odbc.OdbcConnection("INSERT ODBC CONNECTION STRING");
            #else
            return new SqlConnection("Initial Catalog=" + dbString + ";Data Source=" + srvString +
				";user id= " + userName +";password = " + password);
            #endif
		}
        
        protected SqlConnection CreateConnection(string UFO)
        {
            string srvString = "";
            string dbString = "";
            string userName = "";
            string password = "";
            System.Xml.XmlDocument xmlConfig = new XmlDocument();
            string tempDirectoryPath = Application.StartupPath;
            //tempDirectoryPath = tempDirectoryPath.Remove(tempDirectoryPath.IndexOf("bin"), 9);
            xmlConfig.Load(tempDirectoryPath + @"\XMLFiles\DMTServer.config");
            XmlNodeList xmlNode = xmlConfig.SelectNodes("Home/ConnValue");
            foreach (XmlNode xmlN in xmlNode)
            {
                srvString = xmlN.ChildNodes[4].FirstChild.Value;
                dbString = xmlN.ChildNodes[5].FirstChild.Value;
                userName = xmlN.ChildNodes[6].FirstChild.Value;
                password = xmlN.ChildNodes[7].FirstChild.Value;
            }
#if ODBC
			            return new System.Data.Odbc.OdbcConnection("INSERT ODBC CONNECTION STRING");
#else
            return new SqlConnection("Initial Catalog=" + dbString + ";Data Source=" + srvString +
                ";user id= " + userName + ";password = " + password);
#endif
        }
	
		/// <summary>
		/// Adds a new parameter to the specified command. It is not recommended that 
		/// you use this method directly from your custom code. Instead use the 
		/// <c>AddParameter</c> method of the &lt;TableCodeName&gt;Collection_Base classes.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.OleDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="dbType">One of the <see cref="System.Data.DbType"/> values. </param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
        internal SqlParameter AddParameter(SqlCommand cmd, string paramName,
			DbType dbType, object value)
		{
            SqlParameter parameter = cmd.CreateParameter();
			parameter.ParameterName = CreateCollectionParameterName(paramName);
			parameter.DbType = dbType;
			parameter.Value = null == value ? DBNull.Value : value;
			cmd.Parameters.Add(parameter);
			return parameter;
		}
		

		/// <summary>
		/// Creates a DataTable object for the specified command.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.OleDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected internal DataTable CreateDataTable(SqlCommand command)
		{
			DataTable dataTable = new DataTable();
#if ODBC
			new System.Data.Odbc.OdbcDataAdapter((System.Data.Odbc.OdbcCommand)command).Fill(dataTable);
#else
            new SqlDataAdapter((SqlCommand)command).Fill(dataTable);
#endif		
			return dataTable;
		}

		/// <summary>
		/// Returns a SQL statement parameter name that is specific for the data provider.
		/// For example it returns ? for OleDb provider, or @paramName for MS SQL provider.
		/// </summary>
		/// <param name="paramName">The data provider neutral SQL parameter name.</param>
		/// <returns>The SQL statement parameter name.</returns>
		public  string CreateSqlParameterName(string paramName)
		{
#if ODBC
			return "?";
#else
			return "?";
#endif
		}

		/// <summary>
		/// Creates a .Net data provider specific parameter name that is used to
		/// create a parameter object and add it to the parameter collection of
		/// <see cref="System.Data.OleDbCommand"/>.
		/// </summary>
		/// <param name="baseParamName">The base name of the parameter.</param>
		/// <returns>The full data provider specific parameter name.</returns>
		public  string CreateCollectionParameterName(string baseParamName)
		{
#if ODBC
			return "@" + baseParamName;
#else
			return "@" + baseParamName;
#endif
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.OleDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <returns>An <see cref="System.Data.OleDbCommand"/> object.</returns>
        public SqlCommand CreateCommand(string sqlText)
		{
			return CreateCommand(sqlText, false);
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.OleDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <param name="procedure">Specifies whether the sqlText parameter is 
		/// the name of a stored procedure.</param>
		/// <returns>An <see cref="System.Data.OleDbCommand"/> object.</returns>
        public SqlCommand CreateCommand(string sqlText, bool procedure)
		{
            SqlCommand cmd = _connection.CreateCommand();
			cmd.CommandText = sqlText;
			cmd.Transaction = _transaction;
			if(procedure)
				cmd.CommandType = CommandType.StoredProcedure;
			return cmd;
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// An application can call the <c>Close</c> method more than
		/// one time without generating an exception.
		/// </summary>
		public  void Close()
		{
			if(null != _connection)
				_connection.Close();
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// </summary>
		public  void Dispose()
		{
			Close();
			if(null != _connection)
				_connection.Dispose();
		}

        public static implicit operator SqlConnection(HospitalDB v)
        {
            throw new NotImplementedException();
        }

        internal SqlCommand CreateCommand(object p, bool v)
        {
            throw new NotImplementedException();
        }
    }
}
