﻿//----------------------------------------------------------------------- 
// PDS WITSMLstudio Store, 2018.3
//
// Copyright 2018 PDS Americas LLC
// 
// Licensed under the PDS Open Source WITSML Product License Agreement (the
// "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.pds.group/WITSMLstudio/OpenSource/ProductLicenseAgreement
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("PDS WITSMLstudio Store")]
[assembly: AssemblyDescription("PDS WITSMLstudio Store Core Library")]
[assembly: AssemblyProduct("PDS WITSMLstudio Store")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("93faae2f-13aa-46df-a94b-36155b51ebfa")]

[assembly: InternalsVisibleTo("PDS.WITSMLstudio.Store.IntegrationTest")]
[assembly: InternalsVisibleTo("PDS.WITSMLstudio.Store.MongoDb.IntegrationTest")]
[assembly: InternalsVisibleTo("PDS.WITSMLstudio.UnitTest")]
