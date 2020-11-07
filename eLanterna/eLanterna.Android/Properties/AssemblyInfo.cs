using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("eLanterna")]
[assembly: AssemblyDescription("O simpla aplicatie de aprins si stins lanterna de la telefon.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("EduardBoboc")]
[assembly: AssemblyProduct("eLanterna")]
[assembly: AssemblyCopyright("Copyright Eduard Boboc © 2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("ro-ro")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
