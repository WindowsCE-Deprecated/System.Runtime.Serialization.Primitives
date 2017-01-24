﻿using System;
using System.Reflection;
using System.Resources;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: NeutralResourcesLanguage("en-us")]
[assembly: AssemblyCompany("Fabrício Godoy")]
[assembly: AssemblyCopyright("© Fabrício Godoy. All rights reserved.")]
[assembly: AssemblyProduct("System.Runtime.Serialization.Primitives")]
[assembly: AssemblyDescription("Provides common types, including System.Runtime.Serialization.DataContractAttribute, for libraries that support data contract serialization")]
[assembly: CLSCompliant(true)]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.2")]
[assembly: AssemblyFileVersion("1.0.2")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Retail")]
#endif

#if CLASSIC
[assembly: AssemblyKeyFile(@"..\..\..\tools\keypair.snk")]
[assembly: AssemblyDelaySign(true)]
#endif
