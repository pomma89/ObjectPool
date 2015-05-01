﻿/*
 * Generic Object Pool Implementation
 *
 * Implemented by Ofir Makmal, 28/1/2013
 *
 * My Blog: Blogs.microsoft.co.il/blogs/OfirMakmal
 * Email:   Ofir.Makmal@gmail.com
 *
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following set of attributes.
// Change these attribute values to modify the information associated with an assembly.
[assembly: AssemblyTitle("CodeProject.ObjectPool")]
[assembly: AssemblyDescription("An implementation of a Generic Object Pool.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Ofir Makmal")]
[assembly: AssemblyProduct("Generic Object Pool")]
[assembly: AssemblyCopyright("Copyright © Ofir Makmal 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible to COM components. If
// you need to access a type in this assembly from COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("9fa5458c-89ab-4a37-9062-233a8fc52dfd")]

// Version information for an assembly consists of the following four values:
// 
// Major Version Minor Version Build Number Revision
// 
// You can specify all the values or you can default the Build and Revision Numbers by using the '*'
// as shown below: [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.4.0")]
[assembly: AssemblyFileVersion("1.4.0")]

// Common Language Specification (CLS) compliance generally refers to the claim that CLS rules and
// restrictions are being followed.
[assembly: CLSCompliant(true)]

// To allow simpler unit testing.
[assembly: InternalsVisibleTo("UnitTests")]