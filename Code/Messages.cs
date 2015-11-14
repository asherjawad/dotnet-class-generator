using System;
using System.Globalization;
using System.Windows.Forms;
using GNR8.Properties;

namespace GNR8.Code
{
	#region Comments
	/// <summary>
	/// MessageBox methods: here because I use each more than once.
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

	static class Messages
	{
		#region Local Methods
		/// <summary>
		/// Exception Message.
		/// </summary>
		/// <param name="e">The Exception to message about.</param>
		internal static void BadConnection(Exception e)
		{
			// Construct the message.
			string failure =
				string.Format(
					CultureInfo.InvariantCulture,
					Resources.CONNECTION_BAD,
					e.Message,
					Environment.NewLine);

			// and display...
			MessageBox.Show(failure, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Report a good connection.
		/// </summary>
		/// <param name="Connection">The connection string for display.</param>
		internal static void GoodConnection(string Connection)
		{
			// Construct the message.
			string success =
				string.Format(
					CultureInfo.InvariantCulture,
					Resources.CONNECTION_GOOD,
					Connection,
					Environment.NewLine);

			// and display...
			MessageBox.Show(success, ApplicationAttributes.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
	}
}