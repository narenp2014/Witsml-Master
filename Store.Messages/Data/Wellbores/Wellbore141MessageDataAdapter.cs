﻿//----------------------------------------------------------------------- 
// PDS WITSMLstudio Core, 2018.3
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

using System.ComponentModel.Composition;
using Energistics.DataAccess.WITSML141;
using PDS.WITSMLstudio.Framework;
using PDS.WITSMLstudio.Store.Configuration;

namespace PDS.WITSMLstudio.Store.Data.Wellbores
{
    /// <summary>
    /// Data adapter that encapsulates CRUD functionality for <see cref="Wellbore" />
    /// </summary>
    /// <seealso cref="PDS.WITSMLstudio.Store.Data.MessageDataAdapter{Wellbore}" />
    /// <seealso cref="PDS.WITSMLstudio.Store.Configuration.IWitsml141Configuration" />
    [Export(typeof(IWitsml141Configuration))]
    [Export(typeof(IWitsmlDataAdapter<Wellbore>))]
    [Export141(ObjectTypes.Wellbore, typeof(IWitsmlDataAdapter))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class Wellbore141MessageDataAdapter : MessageDataAdapter<Wellbore>, IWitsml141Configuration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wellbore141MessageDataAdapter"/> class.
        /// </summary>
        /// <param name="container">The composition container.</param>
        [ImportingConstructor]
        public Wellbore141MessageDataAdapter(IContainer container) : base(container, ObjectNames.Wellbore141)
        {
            Logger.Debug("Instance created.");
        }

        /// <summary>
        /// Gets the server capabilities.
        /// </summary>
        /// <param name="capServer">The capServer instance.</param>
        public void GetCapabilities(CapServer capServer)
        {
            Logger.DebugFormat("Getting the supported capabilities for Wellbore data version {0}.", capServer.Version);

            //capServer.Add(Functions.GetFromStore, ObjectTypes.Wellbore);
            capServer.Add(Functions.AddToStore, ObjectTypes.Wellbore);
            capServer.Add(Functions.UpdateInStore, ObjectTypes.Wellbore);
            //capServer.Add(Functions.DeleteFromStore, ObjectTypes.Wellbore);
        }
    }
}