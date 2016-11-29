using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using GNR8.Properties;

namespace GNR8.Code
{
	#region Comments
	/// <summary>
	/// Contains Xml processing methods.
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
	/// 		<description>03/07/2008</description>
	/// 		<description>Created</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	[Serializable]
	class XmlHelper
	{
		#region Construction
		/// <summary>
		/// Initializes a new instance of the XmlHelper class for create, append and delete.
		/// </summary>
		/// <param name="Key">The Token name.</param>
		/// <param name="Value">The Token value.</param>
		internal XmlHelper(string Key, string Value)
		{
			this.Key = Key;
			this.Value = Value;
		}

		/// <summary>
		/// Initializes a new instance of the XmlHelper class for editing.
		/// </summary>
		/// <param name="OriginalKey">The original key.</param>
		/// <param name="Key">The new key.</param>
		/// <param name="Value">The new value (might be the old value).</param>
		internal XmlHelper(string OriginalKey, string Key, string Value)
		{
			this.OriginalKey = OriginalKey;
			this.Key = Key;
			this.Value = Value;
		}
		#endregion

		#region Static Properties
		/// <summary>
		/// This is where the Xml file is expected to be found: no deviation!!!
		/// </summary>
		internal static string FullPath
		{
			get
			{
				return
					string.Format(
						CultureInfo.InvariantCulture,
						@"{0}\Tokens.xml",
						Application.StartupPath);
			}
		}
		#endregion

		#region Private Properties
		/// <summary>
		/// The Token name.
		/// </summary>
		private string Key { get; set; }

		/// <summary>
		/// The Token value.
		/// </summary>
		private string Value { get; set; }

		/// <summary>
		/// When editing, the original key.
		/// </summary>
		private string OriginalKey { get; set; }
		#endregion

		#region Private Methods
		/// <summary>
		/// Add the new key and value to the XML file.
		/// </summary>
		private void Append()
		{
			// Need these.
			XmlElement child;
			XmlText text;

			// Get the file: we think we know it exists...
			XmlDocument doc = new XmlDocument();
			doc.Load(FullPath);

			// Create the parent element.
			XmlElement element = doc.CreateElement(Resources.TOKENS);

			// Add the child nodes...
			child = doc.CreateElement(Resources.TOKEN);
			text = doc.CreateTextNode(this.Key);
			child.AppendChild(text);
			element.AppendChild(child);
			doc.DocumentElement.AppendChild(element);

			child = doc.CreateElement(Resources.CONTENT);
			text = doc.CreateTextNode(this.Value);
			child.AppendChild(text);
			element.AppendChild(child);
			doc.DocumentElement.AppendChild(element);

			// Save the file.
			doc.Save(FullPath);
		}

		/// <summary>
		/// If the file wasn't found, create it and add the initial values.
		/// </summary>
		private void Create()
		{
			// Create a new file as this.FullPath.
			XmlTextWriter writer = new XmlTextWriter(FullPath, Encoding.UTF8);

			// Some properties...
			writer.Formatting = Formatting.Indented;
			writer.WriteStartDocument(true);

			// Add the node data.
			writer.WriteStartElement(ApplicationAttributes.AssemblyTitle);
				writer.WriteStartElement(Resources.TOKENS);
					writer.WriteElementString(Resources.TOKEN, this.Key);
					writer.WriteElementString(Resources.CONTENT, this.Value);
				writer.WriteEndElement();
			writer.WriteEndElement();

			// Save to disk.
			writer.WriteEndDocument();
			writer.Flush();
			writer.Close();
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Creates or Adds Data.
		/// </summary>
		public void CreateOrAppend()
		{
			// Does the file already exist?
			if (!File.Exists(FullPath))
			{
				// Create the file and write out the new values.
				this.Create();
			}
			else
			{
				// Append data to the file.
				this.Append();
			}
		}

		/// <summary>
		/// Delete the node for the given key.
		/// </summary>
		public void Delete()
		{
			// Check to make sure there is something to do.
			if (File.Exists(FullPath))
			{
				// Get the file.
				XmlDocument doc = new XmlDocument();
				doc.Load(FullPath);

				// Get the nodes (will be all).
				XmlNodeList list = doc.SelectNodes(Resources.NODE_LIST_KEY);

				// Find and remove given node.
				foreach (XmlNode node in list)
				{
					if (node.InnerText == this.Key)
					{
						// Remove key and value nodes.
						node.ParentNode.RemoveAll();

						// Done: eave.
						break;
					}
				}

				// Get the nodes (will be empty nodes).
				list = doc.SelectNodes(Resources.NODE_LIST_EMPTY);

				// Find and remove.
				foreach (XmlNode node in list)
				{
					node.ParentNode.RemoveChild(node);
				}

				// Save the file.
				doc.Save(FullPath);
			}
		}

		/// <summary>
		/// Update the given node.
		/// </summary>
		public void Edit()
		{
			// Check to make sure there is something to do.
			if (File.Exists(FullPath))
			{
				// Get the file.
				XmlDocument doc = new XmlDocument();
				doc.Load(FullPath);

				// Get the nodes (will be all).
				XmlNodeList list = doc.SelectNodes(Resources.NODE_LIST_KEY);

				// Find and remove given node.
				foreach (XmlNode node in list)
				{
					if (node.InnerText == this.OriginalKey)
					{
						// Update key and value nodes.
						node.InnerText = this.Key;
						node.NextSibling.InnerText = this.Value;

						// Done: leave.
						break;
					}
				}

				// Save the file.
				doc.Save(FullPath);
			}
		}
		#endregion

		#region Static Methods
		/// <summary>
		/// Return a <see cref="DataTable"/> containing the file data.
		/// </summary>
		public static DataTable Load()
		{
			DataTable table = null;

			// Does the file already exist?
			if (File.Exists(FullPath))
			{
				// Create a DataSet.
				DataSet set = new DataSet();
				set.Locale = CultureInfo.InvariantCulture;

				// Read the file.
				set.ReadXml(FullPath);

				// Make sure that the document contains some data!
				if (set.Tables.Count != 0)
				{
					// Get the table.
					table = set.Tables[0];
				}

				set.Dispose();
			}

			return table;
		}
		#endregion
	}
}