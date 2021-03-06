﻿#region	License
//--------------------------------------------------
// <License>
//     <Copyright> 2018 © Top Nguyen </Copyright>
//     <Url> http://topnguyen.com/ </Url>
//     <Author> Top </Author>
//     <Project> Elect </Project>
//     <File>
//         <Name> ElectDIOptions.cs </Name>
//         <Created> 16/03/2018 1:51:16 PM </Created>
//         <Key> e4a80a81-561e-459f-874c-c80030bb30cb </Key>
//     </File>
//     <Summary>
//         ElectDIOptions.cs is a part of Elect
//     </Summary>
// <License>
//--------------------------------------------------
#endregion License

using Elect.Core.Interfaces;
using Microsoft.Extensions.PlatformAbstractions;
using System.Collections.Generic;

namespace Elect.DI.Models
{
    public class ElectDIOptions : IElectOptions
    {
        /// <summary>
        ///     List assembly folder to scan, default is application base path. 
        /// </summary>
        public List<string> ListAssemblyFolderPath { get; set; } = new List<string> { PlatformServices.Default.Application.ApplicationBasePath };

        /// <summary>
        ///     List assembly name to scan, default is application name. 
        /// </summary>
        /// <remarks>Default is root assembly name, e.g: Elect.DI.dll => Scan Elect.dll and Elect.*.dll </remarks>
        public List<string> ListAssemblyName { get; set; } = new List<string> { PlatformServices.Default.Application.ApplicationName };
    }
}