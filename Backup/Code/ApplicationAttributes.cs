using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace GNR8.Code
{
	#region Comments
	/// <summary>
	/// Provides access to the attributes within AssemblyInfo.cs.<br/>
	/// Since this is now embedded into a library it will always refer
	/// to the primary assembly otherwise it will extract the AssemblyInfo
	/// data from this project. If you extract this class to your own project
	/// replace <c>assembly</c> with <c>Assembly.GetExecutingAssembly()</c>.
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
	/// 		<description>31/01/2006</description>
	/// 		<description>Created</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	static class ApplicationAttributes
	{
		#region Assembly Attribute Accessors
		/// <summary>
		/// Get the Assembly (Application) Title.
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyTitle
		{
			get
			{
				// Get all Title attributes on this assembly.
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

				// If there is at least one Title attribute.
				if (attributes.Length > 0)
				{
					// Select the first one.
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute) attributes[0];

					// If it is not an empty string, return it
					if (!string.IsNullOrEmpty(titleAttribute.Title))
					{
						return titleAttribute.Title;
					}
				}

				// If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name.
				return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		/// <summary>
		/// Get the Assembly (Application) Version.
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyVersion
		{
			get
			{
				string version =
					string.Format(
						CultureInfo.InvariantCulture,
						@"{0}.{1}",
						Assembly.GetExecutingAssembly().GetName().Version.Major,
						Assembly.GetExecutingAssembly().GetName().Version.Minor);

				return version;	// Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		/// <summary>
		/// Gett he Assembly (Application) Description.
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyDescription
		{
			get
			{
				// Get all Description attributes on this assembly.
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

				// If there aren't any Description attributes, return an empty string.
				if (attributes.Length == 0)
				{
					return string.Empty;
				}

				// If there is a Description attribute, return its value.
				return ((AssemblyDescriptionAttribute) attributes[0]).Description;
			}
		}

		/// <summary>
		/// Get the Assembly (Application) Product name.
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyProduct
		{
			get
			{
				// Get all Product attributes on this assembly.
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);

				// If there aren't any Product attributes, return an empty string
				if (attributes.Length == 0)
				{
					return string.Empty;
				}

				// If there is a Product attribute, return its value.
				return ((AssemblyProductAttribute) attributes[0]).Product;
			}
		}

		/// <summary>
		/// Get the Assembly (Application) Copyright.
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyCopyright
		{
			get
			{
				// Get all Copyright attributes on this assembly.
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

				// If there aren't any Copyright attributes, return an empty string.
				if (attributes.Length == 0)
				{
					return string.Empty;
				}

				// If there is a Copyright attribute, return its value.
				return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
			}
		}

		/// <summary>
		/// Get the Assembly (Application) Company Name.
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyCompany
		{
			get
			{
				// Get all Company attributes on this assembly.
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);

				// If there aren't any Company attributes, return an empty string.
				if (attributes.Length == 0)
				{
					return string.Empty;
				}

				// If there is a Company attribute, return its value.
				return ((AssemblyCompanyAttribute) attributes[0]).Company;
			}
		}

		/// <summary>
		/// Get the Assembly (Application) Guid.
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyGuid
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false);

				// If there aren't any Company attributes, return an empty string.
				if (attributes.Length == 0)
				{
					return string.Empty;
				}

				// If there is a Company attribute, return its value.
				return ((GuidAttribute) attributes[0]).Value;
			}
		}

		/// <summary>
		/// What mode are we operating in? Release or Debug?
		/// </summary>
		/// <returns>string</returns>
		public static string AssemblyMode
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyConfigurationAttribute), false);

				// If there aren't any Company attributes, return an empty string.
				if (attributes.Length == 0)
				{
					return string.Empty;
				}

				// If there is a Company attribute, return its value.
				return ((AssemblyConfigurationAttribute) attributes[0]).ToString();
			}
		}
		#endregion
	}
}