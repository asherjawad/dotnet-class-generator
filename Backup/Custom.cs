using System;
using System.Globalization;
using System.Windows.Forms;
using GNR8.Code;
using GNR8.Properties;

namespace GNR8
{
	#region Comments
	/// <summary>
	/// Handles CRUD of Custom Tokens.
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
	/// 		<description>02/07/2008</description>
	/// 		<description>Created.</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	public partial class Custom : Form
	{
		#region Construction
		/// <summary>
		/// No-args constructor.
		/// </summary>
		public Custom()
		{
			this.InitializeComponent();

			// Populate the grid.
			this.BindGrid();
		}
		#endregion

		#region Private Members
		/// <summary>
		/// Are we adding/editing?
		/// </summary>
		private bool IsEditing = false;
		#endregion

		#region Local Methods
		/// <summary>
		/// Bind the file data to the grid for display.
		/// </summary>
		private void BindGrid()
		{
			// Load (if available) and display the Xml data.
			this.dgTokens.DataSource = XmlHelper.Load();

			// Hide/show delete/edit buttons.
			this.DisplayButtons();
		}

		/// <summary>
		/// Hide/Show the Delete/Edit buttons depending on state.
		/// </summary>
		private void DisplayButtons()
		{
			bool state = (this.dgTokens.Rows.Count == 0) ? false : true;
			this.btnEdit.Visible = state;
			this.btnDelete.Visible = state;			
		}
		#endregion

		#region Events
		/// <summary>
		/// Process and insert/append custom tokens.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnCreateOrAppend_Click(object sender, EventArgs e)
		{
			string key = this.txtKey.Text.Trim();
			string value = this.txtValue.Text.Trim();

			// Make sure that there is something worth saving.
			// Hey; my app, my limits.
			if (key.Length < 3 || value.Length < 3)
			{
				MessageBox.Show(Resources.KEY_VALUE_TOO_SHORT, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (this.IsEditing)
				{
					// Get the original key.
					string originalKey = this.dgTokens.CurrentRow.Cells[0].Value.ToString();

					// Update the data.
					new XmlHelper(originalKey, key, value).Edit();

					// Reset.
					this.IsEditing = false;
				}
				else
				{
					// Create  and insert data or append and insert data.
					new XmlHelper(key, value).CreateOrAppend();
				}

				// Either way, clear the text boxes...
				this.txtKey.Text = null;
				this.txtValue.Text = null;

				// and refresh the grid.
				this.BindGrid();
			}

			this.txtKey.Focus();
		}

		/// <summary>
		/// Delete selected item.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Get the key.
			string key = this.dgTokens.CurrentCell.Value.ToString();
	
			// Construct a confirmation message.
			string message = 
				string.Format(
					CultureInfo.InvariantCulture,
					@"Are you sure that you want to delete '{0}'?{1}{1}If you continue you will not be able to recover the value.",
					key,
					Environment.NewLine);

			// Ask the question.
			if (MessageBox.Show(message, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				// Okay, they really mean it!
				new XmlHelper(key, null).Delete();

				// Refresh the grid.
				this.BindGrid();
			}
		}

		/// <summary>
		/// Edit the selected item.
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnEdit_Click(object sender, EventArgs e)
		{
			string key = this.dgTokens.CurrentRow.Cells[0].Value.ToString();
			string value = this.dgTokens.CurrentRow.Cells[1].Value.ToString();

			this.txtKey.Text = key;
			this.txtValue.Text = value;
			this.txtKey.Focus();

			this.IsEditing = true;
		}
		#endregion
	}
}