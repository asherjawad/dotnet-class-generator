﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GNR8.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GNR8.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About {0}.
        /// </summary>
        internal static string ABOUT {
            get {
                return ResourceManager.GetString("ABOUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection test failed.{1}{1}{0}.
        /// </summary>
        internal static string CONNECTION_BAD {
            get {
                return ResourceManager.GetString("CONNECTION_BAD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection test was successful.{1}{1}You will connect as:{1}{0}.
        /// </summary>
        internal static string CONNECTION_GOOD {
            get {
                return ResourceManager.GetString("CONNECTION_GOOD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content.
        /// </summary>
        internal static string CONTENT {
            get {
                return ResourceManager.GetString("CONTENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter a key and value of at least 3 characters..
        /// </summary>
        internal static string KEY_VALUE_TOO_SHORT {
            get {
                return ResourceManager.GetString("KEY_VALUE_TOO_SHORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LOCAL.
        /// </summary>
        internal static string LOCAL {
            get {
                return ResourceManager.GetString("LOCAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new Template has been created as:{1}{1}{0}.
        /// </summary>
        internal static string NEW_TEMPLATE {
            get {
                return ResourceManager.GetString("NEW_TEMPLATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have to select at least one object to proceed..
        /// </summary>
        internal static string NO_OBJECTS_SELECTED {
            get {
                return ResourceManager.GetString("NO_OBJECTS_SELECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [PK NOT FOUND].
        /// </summary>
        internal static string NO_PRIMARYKEY {
            get {
                return ResourceManager.GetString("NO_PRIMARYKEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Template ({0}) is missing.{1}{1}Please create or generate a new one to continue..
        /// </summary>
        internal static string NO_TEMPLATE {
            get {
                return ResourceManager.GetString("NO_TEMPLATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either select to use Integrated Security (Trusted Connection){0}or supply a valid user name and password..
        /// </summary>
        internal static string NO_USER_DETAIL {
            get {
                return ResourceManager.GetString("NO_USER_DETAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //*[not(node())].
        /// </summary>
        internal static string NODE_LIST_EMPTY {
            get {
                return ResourceManager.GetString("NODE_LIST_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GNR8/Tokens/Token.
        /// </summary>
        internal static string NODE_LIST_KEY {
            get {
                return ResourceManager.GetString("NODE_LIST_KEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All of the selected objects have now been created and saved to:{0}{0}{1}..
        /// </summary>
        internal static string OBJECTS_CREATED {
            get {
                return ResourceManager.GetString("OBJECTS_CREATED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SQLOLEDB.
        /// </summary>
        internal static string PROVIDER {
            get {
                return ResourceManager.GetString("PROVIDER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider={0};Data Source={1};Initial Catalog={2};Integrated Security=SSPI;.
        /// </summary>
        internal static string PROVIDER_IS {
            get {
                return ResourceManager.GetString("PROVIDER_IS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider={0};Password={1};User ID={2};Data Source={3};Initial Catalog={4};.
        /// </summary>
        internal static string PROVIDER_NOT_IS {
            get {
                return ResourceManager.GetString("PROVIDER_NOT_IS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Searching....
        /// </summary>
        internal static string SEARCHING {
            get {
                return ResourceManager.GetString("SEARCHING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Data;
        ///
        ///namespace {NAMESPACE}
        ///{
        ///	#region Comments
        ///	/// &lt;summary&gt;
        ///	/// {OBJECTNAME} Class.
        ///	/// &lt;/summary&gt;
        ///	/// &lt;remarks&gt;
        ///	/// &lt;h3&gt;Changes&lt;/h3&gt;
        ///	/// &lt;list type=&quot;table&quot;&gt;
        ///	/// 	&lt;listheader&gt;
        ///	/// 		&lt;th&gt;Author&lt;/th&gt;
        ///	/// 		&lt;th&gt;Date&lt;/th&gt;
        ///	/// 		&lt;th&gt;Details&lt;/th&gt;
        ///	/// 	&lt;/listheader&gt;
        ///	/// 	&lt;item&gt;
        ///	/// 		&lt;term&gt;{AUTHOR}&lt;/term&gt;
        ///	/// 		&lt;description&gt;{DATECREATED}&lt;/description&gt;
        ///	/// 		&lt;description&gt;Created&lt;/description&gt;
        ///	/// 	&lt;/item&gt;
        ///	/// &lt;/list&gt;
        ///	/// &lt;/remarks&gt;
        ///	#endregion        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TEMPLATE {
            get {
                return ResourceManager.GetString("TEMPLATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token.
        /// </summary>
        internal static string TOKEN {
            get {
                return ResourceManager.GetString("TOKEN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tokens.
        /// </summary>
        internal static string TOKENS {
            get {
                return ResourceManager.GetString("TOKENS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {0}.
        /// </summary>
        internal static string VERSION {
            get {
                return ResourceManager.GetString("VERSION", resourceCulture);
            }
        }
    }
}
