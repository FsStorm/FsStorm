﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FstSampleTest")>]
[<assembly: AssemblyProductAttribute("FsStorm")>]
[<assembly: AssemblyDescriptionAttribute("F# DSL and runtime for Storm topologies")>]
[<assembly: AssemblyVersionAttribute("0.0.12")>]
[<assembly: AssemblyFileVersionAttribute("0.0.12")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.12"
