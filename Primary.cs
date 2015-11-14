using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GNR8.Code;
using GNR8.Properties;

namespace GNR8
{
	#region Comments
	/// <summary>
	/// Primary Form.
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
	/// 		<description>Created</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	public partial class Primary : Form
	{
		#region Construction
		/// <summary>
		/// No-args constructor.
		/// </summary>
		public Primary()
		{
			this.InitializeComponent();

			// Instantiate the objects collection.
			this.objects = new Collection<string>();

			// Display the connection dialog.
			ReConnect();

			// If the connection could be made...
			if (Globals.CanConnect)
			{
				// Refresh the list of database objects.
				this.RefreshLists();
			}
		}
		#endregion

		#region Private Members
		/// <summary>
		/// Storage for Tables and Views.
		/// </summary>
		private Collection<string> objects;
		#endregion

		#region Local Methods
		/// <summary>
		/// Populate a collection with a list of all of the tables and views
		/// used in the database defined by the current connection string.
		/// </summary>
		private void QueryDBSchema()
		{
			// Schema information for the current database connection.
			DataTable schema;

			// Loop counter.
			int loop = 0;

			// Clean up the menu so the menu item does not hang while this function executes.
			this.Refresh();

			// Make sure we have at least an Initial Catalog...
			if (!string.IsNullOrEmpty(DBInstance.InitialCatalog))
			{
				// Instantiate an OleDbConnection object.
				using (OleDbConnection oleDbConnection = new OleDbConnection(DBInstance.ConnectionString))
				{
					try
					{
						// Open the connection.
						oleDbConnection.Open();

						// Retrieve the Table objects.
						schema = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "table" });

						// Store the table names in the object collection.
						for (loop = 0; loop < schema.Rows.Count; loop++)
						{
							objects.Add(schema.Rows[loop].ItemArray[2].ToString());
						}
					}
					catch (Exception e)
					{
						Messages.BadConnection(e);
					}
				}
			}
		}

		/// <summary>
		/// Re-populate the list view.
		/// </summary>
		private void RefreshLists()
		{
			this.QueryDBSchema();

			if (this.objects.Count != 0)
			{
				this.lstObjects.DataSource = this.objects;
				this.lstObjects.SelectedIndex = -1;
				this.btnProcess.Enabled = true;
				this.chkSelectAll.Enabled = true;
				this.lblInfo.Text = 
					string.Format(
						CultureInfo.InvariantCulture,
						@"{0}.{1} :: {2} tables listed.",
						// I fthe server name ends with a \ then remove it: looks ugly.
						(string.IsNullOrEmpty(DBInstance.ServerName)) ? Resources.LOCAL : DBInstance.ServerName.TrimEnd('\\'),
						DBInstance.InitialCatalog,
						this.objects.Count);
			}
			else
			{
				this.btnProcess.Enabled = false;
				this.chkSelectAll.Enabled = false;
				this.lblInfo.Text = null;
			}
		}

		/// <summary>
		/// Display the connection dialog.
		/// </summary>
		private static void ReConnect()
		{
			Connect connect = new Connect();
			connect.ShowDialog();
		}
		#endregion

		#region Events
		/// <summary>
		/// Select/Deselect all objects.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
		{
			for (int loop = 0; loop < this.lstObjects.Items.Count; loop++)
			{
				this.lstObjects.SetItemChecked(loop, this.chkSelectAll.Checked);
			} 
		}

		/// <summary>
		/// Process a table.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnProcess_Click(object sender, EventArgs e)
		{
			// Make sure that there is something to do.
			if (this.lstObjects.CheckedItems.Count == 0)
			{
				MessageBox.Show(Resources.NO_OBJECTS_SELECTED, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				// Make sure that the template exists or we're wasting time!
				string templatePath =
					string.Format(
						CultureInfo.InvariantCulture,
						@"{0}\Template.txt",
						Application.StartupPath);

				if (!File.Exists(templatePath))
				{
					// Construct the message.
					string failure =
						string.Format(
							CultureInfo.InvariantCulture,
							Resources.NO_TEMPLATE,
							templatePath,
							Environment.NewLine);

					// and display...
					MessageBox.Show(failure, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					Collection<string> selected = new Collection<string>();

					// Gather each of the selected items (if any) into a collection object.
					foreach (int item in this.lstObjects.CheckedIndices)
					{
						selected.Add(this.lstObjects.Items[item].ToString());
					}

					// Pass the collection to Process and display.
					Process process = new Process(selected);
					process.ShowDialog();
				}
			}
		}

		/// <summary>
		/// Display the Database connection dialog.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tsbConnect_Click(object sender, EventArgs e)
		{
			ReConnect();
			this.RefreshLists();
		}

		/// <summary>
		/// Refresh the list boxes.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tsbRefresh_Click(object sender, EventArgs e)
		{
			this.RefreshLists();
		}

		/// <summary>
		/// Generate a new template.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tsbGenerate_Click(object sender, EventArgs e)
		{
			string template = Resources.TEMPLATE;
			string templatePath =
				string.Format(
					CultureInfo.InvariantCulture,
					@"{0}\Template.txt",
					Application.StartupPath);
			File.WriteAllText(templatePath, template, Encoding.Default);

			// Construct the message.
			string outcome =
				string.Format(
					CultureInfo.InvariantCulture,
					Resources.NEW_TEMPLATE,
					templatePath,
					Environment.NewLine);

			MessageBox.Show(outcome, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		/// <summary>
		/// Display the Custom Tokens Dialog.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tbsCustom_Click(object sender, EventArgs e)
		{
			Custom custom = new Custom();
			custom.ShowDialog();
		}

		/// <summary>
		/// Display the Tokens dialog.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tsbTokens_Click(object sender, EventArgs e)
		{
			// Display as non-modal.
			if (!Globals.DialogIsLoaded)
			{
				Tokens token = new Tokens();
				token.Show();

				// Let the app know we're up.
				Globals.DialogIsLoaded = true;
			}
		}

		/// <summary>
		/// Display the About dialog.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tsbAbout_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}

		/// <summary>
		/// Quit the application.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tsbExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion
	}
}
