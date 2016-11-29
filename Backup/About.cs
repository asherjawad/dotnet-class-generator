using System.Globalization;
using System.Windows.Forms;
using GNR8.Code;
using GNR8.Properties;

namespace GNR8
{
	#region Comments
	/// <summary>
	/// About Dialog.
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

	public partial class About : Form
	{
		#region Construction
		/// <summary>
		/// No args constructor.
		/// </summary>
		public About()
		{
			this.InitializeComponent();

			//  Initialize the AboutBox to display the product information from the assembly information.
			//  Change assembly information settings for your application through either:
			//  - Project->Properties->Application->Assembly Information
			//  - AssemblyInfo.cs
			this.Text = 
				string.Format(
					CultureInfo.InvariantCulture,
					Resources.ABOUT,
					ApplicationAttributes.AssemblyTitle);
			this.lblProductName.Text = ApplicationAttributes.AssemblyProduct;
			this.lblVersion.Text = 
				string.Format(
					CultureInfo.InvariantCulture,
					Resources.VERSION,
					ApplicationAttributes.AssemblyVersion);
			this.lblCopyright.Text = ApplicationAttributes.AssemblyCopyright;
			this.txtDescription.Text = ApplicationAttributes.AssemblyDescription;
		}
		#endregion
	}
}