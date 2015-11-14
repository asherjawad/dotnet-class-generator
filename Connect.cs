using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Globalization;
using System.Windows.Forms;
using GNR8.Code;
using GNR8.Properties;
using SQLDMO;

namespace GNR8
{
	#region Comments
	/// <summary>
	/// Establish Connection to selected database.
	/// </summary>
	/// <remarks>
	/// <h3>Changes</h3>
	/// <list type="table">
	/// 	<listheader>
	/// 		<th>Author</th>
	/// 		<th>Date</th>
	/// 		<th>Details</th>
	/// 	</listheader>
	/// 	<item>
	/// 		<term>Mark Merrens</term>
	/// 		<description>21/04/2008</description>
	/// 		<description>Created.</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	public partial class Connect : Form
	{
		#region Construction
		/// <summary>
		/// No args constructor.
		/// </summary>
		public Connect()
		{
			this.InitializeComponent();

			// Gather any saved properties.
			string provider = Settings.Default.ProviderName;
			this.txtProvider.Text = (string.IsNullOrEmpty(provider)) ? Resources.PROVIDER : provider;
			this.cboServers.Text = Settings.Default.ServerName;
			this.cboCatalog.Text = Settings.Default.InitialCatalog;
			this.txtUserId.Text = Settings.Default.UserId;
			this.cbUIS.Checked = Settings.Default.Trusted;
		}
		#endregion

		#region Local Methods
		/// <summary>
		/// Make a connection and, optionally, display a MessageBox if test was successful.
		/// </summary>
		/// <param name="Test">Which type of operation?</param>
		/// <returns>bool</returns>
		private bool MakeConnection(bool Test)
		{
			bool success = true;

			this.Cursor = Cursors.WaitCursor;
			this.pbStatus.Visible = true;
			System.Windows.Forms.Application.DoEvents();

			// Populate the DBInstance class.
			DBInstance.ProviderString = this.txtProvider.Text;
			DBInstance.ServerName = this.cboServers.Text;
			DBInstance.InitialCatalog = this.cboCatalog.Text;
			DBInstance.UserId = this.txtUserId.Text;
			DBInstance.Password = this.txtPassword.Text;
			DBInstance.UseIS = this.cbUIS.Checked;
			string connection = DBInstance.ConnectionString;

			// Test the connection.
			using (OleDbConnection oleDbConnection = new OleDbConnection(connection))
			{
				try
				{
					// Test the connection.
					oleDbConnection.Open();

					// Display result.
					if (Test)
					{
						this.Cursor = Cursors.Default;
						this.pbStatus.Visible = false;
						Messages.GoodConnection(connection);
					}

					// Preserve the values for future use.
					Settings.Default.ProviderName = this.txtProvider.Text;
					Settings.Default.ServerName = this.cboServers.Text;
					Settings.Default.InitialCatalog = this.cboCatalog.Text;
					Settings.Default.UserId = this.txtUserId.Text;
					Settings.Default.Trusted = this.cbUIS.Checked;
					Settings.Default.Save();

					// If we were testing keep the dialog open.
					if (!Test)
					{
						this.Close();
					}
				}
				catch (Exception e)
				{
					this.pbStatus.Visible = false;
					this.Cursor = Cursors.Default;

					// Test failed.
					Messages.BadConnection(e);

					// Put the cursor back to the server name box.
					this.cboServers.Focus();

					success = false;
				}
			}

			return success;
		}
		#endregion

		#region Events
		/// <summary>
		/// Test the given connection parameters.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnTest_Click(object sender, EventArgs e)
		{
			this.MakeConnection(true);
		}

		/// <summary>
		/// Test the given connection parameters (and move on).
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (this.MakeConnection(false))
			{
				Globals.CanConnect = true;
				this.Close();
			}
		}

		/// <summary>
		/// Handle Integrated Security request.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void cbUIS_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbUIS.Checked)
			{
				this.txtUserId.Text = string.Empty;
				this.txtPassword.Text = string.Empty;
				this.txtUserId.Enabled = false;
				this.txtPassword.Enabled = false;
			}
			else
			{
				this.txtUserId.Enabled = true;
				this.txtPassword.Enabled = true;
			}
		}

		/// <summary>
		/// Get a list of discoverable servers.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnServers_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.btnServers.Enabled = false;
				this.cboServers.Enabled = false;
				this.cboServers.Items.Clear();
				this.cboServers.Text = Resources.SEARCHING;
				this.cboCatalog.Items.Clear();
				this.cboCatalog.Text = string.Empty;
				System.Windows.Forms.Application.DoEvents();

				DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();

				for (int loop = 0; loop < servers.Rows.Count; loop++)
				{
					this.cboServers.Items.Add(servers.Rows[loop]["ServerName"] + "\\" + servers.Rows[loop]["InstanceName"]);
				}

				if (this.cboServers.Items.Count > 0)
				{
					this.cboServers.SelectedIndex = 0;
				}
				else
				{
					this.cboServers.Text = string.Empty;
				}

				this.btnServers.Enabled = true;
				this.cboServers.Enabled = true;
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				this.btnServers.Enabled = true;
				this.cboServers.Enabled = true;
				this.cboServers.Text = string.Empty;
				this.Cursor = Cursors.Default;
				Messages.BadConnection(ex);
			}
		}

		/// <summary>
		/// Retrieve a list of catalogs for thew given server.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods")]
		private void btnCatalogs_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.btnCatalogs.Enabled = false;
				this.cboCatalog.Enabled = false;
				this.cboCatalog.Items.Clear();
				this.cboCatalog.Text = Resources.SEARCHING;
				System.Windows.Forms.Application.DoEvents();

				SQLServerClass server = new SQLServerClass();

				string serverName = this.cboServers.Text;
				string userName = string.Empty;
				string password = string.Empty;

				if (!this.cbUIS.Checked)
				{
					// If the user has not selected Integrated Security
					// ensure that they have given a user id and password.
					if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
					{
						this.btnCatalogs.Enabled = true;
						this.cboCatalog.Enabled = true;
						this.cboCatalog.Text = string.Empty;
						this.Cursor = Cursors.Default;

						string message =
							string.Format(
								CultureInfo.InvariantCulture,
								Resources.NO_USER_DETAIL,
								Environment.NewLine);
						// Display the message/warning and leave.
						MessageBox.Show(message, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					else
					{
						userName = this.txtUserId.Text;
						password = this.txtPassword.Text;
						server.Connect(serverName, userName, password);
					}
				}
				else
				{
					server.LoginSecure = true;
					server.Connect(serverName, string.Empty, string.Empty);
				}

				// To hold found objects.
				Collection<string> catalogs = new Collection<string>();

				// Get the objects.
				foreach (Database2 db in server.Databases)
				{
					if (!db.SystemObject)
					{
						catalogs.Add(db.Name);
					}
				}

				// Add all of the found objects to the combo.
				this.cboCatalog.DataSource = catalogs;

				this.btnCatalogs.Enabled = true;
				this.cboCatalog.Enabled = true;
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				this.btnCatalogs.Enabled = true;
				this.cboCatalog.Enabled = true;
				this.cboCatalog.Text = string.Empty;
				this.Cursor = Cursors.Default;
				Messages.BadConnection(ex);
			}
		}
		#endregion
	}
}