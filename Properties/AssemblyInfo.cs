using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

[assembly: AssemblyTitle("GNR8")]
[assembly: AssemblyDescription("Create simple classes from one or more database tables.")]
[assembly: AssemblyProduct("GNR8")]
[assembly: AssemblyCompany("MWM")]
[assembly: AssemblyCopyright("Copyright © 2008, MWM")]
[assembly: AssemblyTrademark("{None}")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("2fcd9431-de2c-4200-8b79-c7947c584ec5")]
[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyDelaySign(false)]
[assembly: AllowPartiallyTrustedCallers]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: CLSCompliant(true)]
[assembly: FileIOPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly: NeutralResourcesLanguageAttribute("en-GB")]