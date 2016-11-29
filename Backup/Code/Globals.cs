using System;

namespace GNR8.Code
{
	#region Comments
	/// <summary>
	/// Application Globals.
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
	/// 		<description>30/06/2008</description>
	/// 		<description>Created</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	static class Globals
	{
		#region Globals
		/// <summary>
		/// Can we make a valid connection to a database?
		/// </summary>
		internal static Boolean CanConnect = false;

		/// <summary>
		/// Is a non-modal dialog visible?
		/// </summary>
		internal static Boolean DialogIsLoaded = false;
		#endregion
	}
}