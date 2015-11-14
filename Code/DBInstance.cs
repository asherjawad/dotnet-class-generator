using System.Globalization;
using GNR8.Properties;

namespace GNR8.Code
{
	#region Comments
	/// <summary>
	/// Contains details of the current connection.
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

	static class DBInstance
	{
		#region Properties
		/// <summary>
		/// The complete connection string.
		/// </summary>
		public static string ConnectionString
		{
			get
			{
				string connection = string.Empty;

				// Set the connection string against Integrated Security.
				if (UseIS)
				{
					connection = 
						string.Format(
							CultureInfo.InvariantCulture,
							Resources.PROVIDER_IS,
							ProviderString,
							ServerName,
							InitialCatalog);
				}
				else
				{
					connection =
						string.Format(
							CultureInfo.InvariantCulture,
							Resources.PROVIDER_NOT_IS,
							ProviderString,
							Password,
							UserId,
							ServerName,
							InitialCatalog);
				}

				return connection;
			}
		}

		/// <summary>
		/// The Provider string.
		/// </summary>
		public static string ProviderString { get; set; }

		/// <summary>
		/// The Server Name.
		/// </summary>
		public static string ServerName { get; set; }

		/// <summary>
		/// The Initial Catalog.
		/// </summary>
		public static string InitialCatalog { get; set; }

		/// <summary>
		/// The User.
		/// </summary>
		public static string UserId { get; set; }

		/// <summary>
		/// The Password.
		/// </summary>
		public static string Password { get; set; }

		/// <summary>
		/// Use Integrated Security.
		/// </summary>
		public static bool UseIS { get; set; }
		#endregion
	}
}