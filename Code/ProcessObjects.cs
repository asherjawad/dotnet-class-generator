using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GNR8.Properties;

namespace GNR8.Code
{
	#region Comments
	/// <summary>
	/// Contains object processing methods.
	/// </summary>
	/// <remarks>
	/// Some detail from: http://kbalertz.com/309681/Retrieve-Schema-Information-Using-GetOleDbSchemaTable-Visual.aspx.
	/// <h3>Changes</h3>
	/// <list type="table">
	/// 	<listheader>
	/// 		<th>Author</th>
	/// 		<th>Date</th>
	/// 		<th>Details</th>
	/// 	</listheader>
	/// 	<item>
	/// 		<term>Mark Merrens</term>
	/// 		<description>27/06/2008</description>
	/// 		<description>Created</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	class ProcessObjects : IDisposable
	{
		#region Construction
		/// <summary>
		/// No-args constructor.
		/// </summary>
		public ProcessObjects()
		{
			// Locate
			string templatePath =
				string.Format(
					CultureInfo.InvariantCulture,
					@"{0}\Template.txt",
					Application.StartupPath);

			// and read the template in.
			this.TEMPLATE = File.ReadAllText(templatePath);			
		}

		/// <summary>
		/// Immediately releases all resources owned by the object.
		/// </summary>
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
		#endregion

		#region Private Members
		/// <summary>
		/// Contains the template data.
		/// </summary>
		private string TEMPLATE;
		#endregion

		#region Properties
		/// <summary>
		/// The name of the object to create a class for.
		/// </summary>
		internal virtual String ObjectName { get; set; }

		/// <summary>
		/// The name to assign to the NameSpace
		/// </summary>
		internal virtual String NameSpaceName { get; set; }

		/// <summary>
		/// The path to which to save the resultant class objects.
		/// </summary>
		internal virtual string SavePath { get; set; }

		/// <summary>
		/// The name of the author/creator.
		/// </summary>
		internal virtual string Creator { get; set; }

		/// <summary>
		/// The constructor details.
		/// </summary>
		internal virtual string CtorDetail { get; set; }

		/// <summary>
		/// The constructor parameters.
		/// </summary>
		internal virtual string CtorPrameters { get; set; }

		/// <summary>
		/// The full path to the file to save as.
		/// </summary>
		private string FullPath
		{ 
			get
			{
				string fullPath =
					string.Format(
						CultureInfo.InvariantCulture,
						@"{0}/{1}.cs",
						this.SavePath,
						this.ObjectName);

				return fullPath;
			}
		}
		#endregion

		#region The Main Method
		/// <summary>
		/// Process the passed object.
		/// </summary>
		internal void ProcessObject()
		{
			// Sets Ctor detail and parameters.
			this.CreateConstructor();

			// Process Custom tokens first.
			this.CustomTokens();

			// Process default Tokens.
			this.DefaultTokens();

			// Save to disk.
			File.WriteAllText(this.FullPath, this.TEMPLATE, Encoding.Default);
		}
		#endregion

		#region Process Tokens
		/// <summary>
		/// Process the default tokens.
		/// </summary>
		private void DefaultTokens()
		{
			this.TEMPLATE = 
				this.TEMPLATE
					.Replace(Template.AUTHOR, this.Creator)
					.Replace(Template.CTORBODY, this.CtorDetail)
					.Replace(Template.CTORPARAMETERS, this.CtorPrameters)
					.Replace(Template.DATECREATED, DateTime.Today.ToShortDateString())
					.Replace(Template.NAMESPACE, this.NameSpaceName)
					.Replace(Template.OBJECTNAME, this.ObjectName)
					.Replace(Template.PRIMARYKEY, this.PrimaryKey())
					.Replace(Template.PROPERTIES, CreateProperties());
		}

		/// <summary>
		/// Process any custom tokens.
		/// </summary>
		private void CustomTokens()
		{
			string key = string.Empty;
			string value = string.Empty;

			// Get all of the custom tokens, if available.
			DataTable table = XmlHelper.Load();

			// Make sure there is something to do.
			if (table != null)
			{
				foreach(DataRow row in table.Rows)
				{
					key = 
						string.Format(
							CultureInfo.InvariantCulture,
							@"{{{0}}}",
							row[0].ToString());
					value = row[1].ToString();

					// Works quite well; quite well indeed.
					this.TEMPLATE = 
						this.TEMPLATE
							.Replace(key, value)
							.Replace("{0}", Environment.NewLine)
							.Replace("{1}", "\t");
				}
			}
		}
		#endregion

		#region Primary Key
		/// <summary>
		/// Get the primary key.
		/// </summary>
		/// <returns>string</returns>
		private string PrimaryKey()
		{
			string pk = Resources.NO_PRIMARYKEY;

			try
			{
				OleDbConnection oleDbConnection = new OleDbConnection(DBInstance.ConnectionString);

				using (OleDbCommand command = new OleDbCommand("sp_pkeys", oleDbConnection))
				{
					command.CommandType = CommandType.StoredProcedure;
					OleDbParameter param = new OleDbParameter();
					param.Value = this.ObjectName;
					command.Parameters.Add(param);

					OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
					DataTable dataTable = new DataTable();
					dataTable.Locale = CultureInfo.InvariantCulture;
					dataAdapter.Fill(dataTable);

					if (dataTable.Rows.Count > 0)
					{
						pk = dataTable.Rows[0]["column_name"].ToString();
					}
				}
			}
			catch (Exception e)
			{
				// Error parsing Primary Key.
				Messages.BadConnection(e);
			}

			return pk;
		}
		#endregion

		#region Create Constructor
		/// <summary>
		/// Create a constructor from the table definition.
		/// </summary>
		/// <returns>string</returns>
		private void CreateConstructor()
		{
			string parameters = string.Empty;
			string ctor = string.Empty;

			// Sql to retrieve object detail.
			string sql =
				string.Format(
					CultureInfo.InvariantCulture,
					@"select * from [{0}]",
					this.ObjectName);

			// Start up the connection using the current connection string
			using (OleDbConnection oleDbConnection = new OleDbConnection(DBInstance.ConnectionString))
			{
				try
				{
					// Get the table columns.
					OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDbConnection);

					// Open the connection. 
					oleDbConnection.Open();

					// Get the schema table.
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.KeyInfo);
					DataTable dataTable = oleDbDataReader.GetSchemaTable();

					foreach (DataRow dataRow in dataTable.Rows)
					{
						// Get the name of the column.
						string name = dataRow[0].ToString();

						foreach (DataColumn dataColumn in dataTable.Columns)
						{
							// Contains the actual data type.
							string column = dataRow[dataColumn].ToString().Replace("System.", string.Empty);

							if (dataColumn.ColumnName == "DataType")
							{
								parameters += column + " " + name + ", ";
								ctor += "			this." + name + " = " + name + ";" + Environment.NewLine;
							}
						}
					}

					oleDbDataReader.Close();

					// Strip the final comma.
					int intIndex = parameters.LastIndexOf(",", StringComparison.OrdinalIgnoreCase);
					parameters = parameters.Remove(intIndex);
					// and populate the property.
					this.CtorPrameters = parameters;

					//// Remove leading tabs and strip the final Environment.NewLine.
					this.CtorDetail = ctor.Trim();
				}
				catch (Exception e)
				{
					// Connection failed.
					Messages.BadConnection(e);
				}
			}
		}
		#endregion

		#region Create Properties
		/// <summary>
		/// Create all of the properties from the table definition.
		/// </summary>
		/// <returns>string</returns>
		private string CreateProperties()
		{
			StringBuilder builder = new StringBuilder();

			// Sql to retrieve object detail.
			string sql =
				string.Format(
					CultureInfo.InvariantCulture,
					@"select * from [{0}]",
					this.ObjectName);

			// Start up the connection using the current connection string
			using (OleDbConnection oleDbConnection = new OleDbConnection(DBInstance.ConnectionString))
			{
				try
				{
					// Get the table columns.
					OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDbConnection);

					// Open the connection. 
					oleDbConnection.Open();

					// Get the schema table.
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.KeyInfo);
					DataTable dataTable = oleDbDataReader.GetSchemaTable();

					foreach (DataRow dataRow in dataTable.Rows)
					{
						// Get the name of the column.
						string name = dataRow[0].ToString();

						foreach (DataColumn dataColumn in dataTable.Columns)
						{
							// Contains the actual data type.
							string column = dataRow[dataColumn].ToString().Replace("System.", string.Empty);

							if (dataColumn.ColumnName == "DataType")
							{
								builder.AppendFormat(@"		/// <summary>{0}", Environment.NewLine);
								builder.AppendFormat(@"		/// Gets or sets the {0} value.{1}", name, Environment.NewLine);
								builder.AppendFormat(@"		/// </summary>{0}", Environment.NewLine);
								builder.AppendFormat(@"		public virtual {0} {1} {{ get; set; }}{2}{2}", column, name, Environment.NewLine);
							}
						}
					}

					oleDbDataReader.Close();
				}
				catch (Exception e)
				{
					// Connection failed.
					Messages.BadConnection(e);
				}
			}

			// Remove the first 2 tabs and strip the final 2 Environment.NewLines.
			return builder.ToString().Trim();
		}
		#endregion
	}
}