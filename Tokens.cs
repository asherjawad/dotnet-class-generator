using System.ComponentModel;
using System.Windows.Forms;
using GNR8.Code;
using GNR8.Properties;

namespace GNR8
{
	#region Comments
	/// <summary>
	/// Tokens Dialog.
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
	/// 		<description>01/07/2008</description>
	/// 		<description>Created.</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	public partial class Tokens : Form
	{
		#region Construction
		/// <summary>
		/// No-args constructor.
		/// </summary>
		public Tokens()
		{
			this.InitializeComponent();

			// Fill the DataGridView.
			this.BindGrid();

			// Nice and neat.
			this.dgTokens.Height = 183;
			this.dgTokens.Width = 466;
		}
		#endregion

		#region Local Methods
		/// <summary>
		/// Bind the <see cref="DataGridView"/> to the <see cref="BindingList"/>.
		/// </summary>
		private void BindGrid()
		{
			// Sorry about the name: I was tired. Sue me.
			BindingList<Tokenz> token = new BindingList<Tokenz>();

			// Can't get comments from the resource file.
			// Pity: still, this is the only place I want them.
			token.Add(new Tokenz(Template.AUTHOR, "The name of the author/creator of the class to add to the remarks."));
			token.Add(new Tokenz(Template.CTORBODY, "Contains the constructor body code."));
			token.Add(new Tokenz(Template.CTORPARAMETERS, "Contains the constructor method parameters."));
			token.Add(new Tokenz(Template.DATECREATED, "The date that the class was created to add to the remarks."));
			token.Add(new Tokenz(Template.NAMESPACE, "The name of the namespace to assign to the class."));
			token.Add(new Tokenz(Template.OBJECTNAME, "The name of the table (object) from which the class will be constructed."));
			token.Add(new Tokenz(Template.PRIMARYKEY, "The primary key of the table (if found)."));
			token.Add(new Tokenz(Template.PROPERTIES, "The properties for the table columns."));

			// Bind the, er, BindingList...
			this.dgTokens.DataSource = token;
		}
		#endregion

		#region Events
		/// <summary>
		/// As this is a non-Modal form this is necessary.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			// Release.
			Globals.DialogIsLoaded = false;

			this.Close();
		}
		#endregion
	}

	#region Internal Class: Tokenz
	/// <summary>
	/// So I can get the tokens/descriptions into a <see cref="DataGridView"/>. Duh!
	/// The Properties must be exposed as public or they can't be seen.
	/// </summary>
	internal class Tokenz
	{
		#region Public Properties
		/// <summary>
		/// The name of the Token.
		/// </summary>
		public string Token { get; set; }

		/// <summary>
		/// Its purpose.
		/// </summary>
		public string Description { get; set; }
		#endregion

		#region Construction
		/// <summary>
		/// The one and only constructor.
		/// </summary>
		/// <param name="Token">The name of the Token.</param>
		/// <param name="Description">Its purpose.</param>
		internal Tokenz(string Token, string Description)
		{
			this.Token = Token;
			this.Description = Description;
		}
		#endregion
	}
	#endregion
}
