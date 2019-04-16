﻿//----------------------------------------------------------------------- 
// PDS WITSMLstudio Store, 2018.1
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

// ----------------------------------------------------------------------
// <auto-generated>
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------

using Energistics.DataAccess;
using Energistics.DataAccess.WITSML131;
using Energistics.DataAccess.WITSML131.ComponentSchemas;
using Energistics.DataAccess.WITSML131.ReferenceData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PDS.WITSMLstudio.Store.Data.Realtimes
{
    [TestClass]
    public partial class Realtime131StoreTests : Realtime131TestBase
    {
        partial void BeforeEachTest();

        partial void AfterEachTest();

        protected override void OnTestSetUp()
        {
            BeforeEachTest();
        }

        protected override void OnTestCleanUp()
        {
            AfterEachTest();
        }

        [TestMethod]
        public void Realtime131DataAdapter_GetFromStore_Can_Get_Realtime()
        {
            AddParents();
            DevKit.AddAndAssert<RealtimeList, Realtime>(Realtime);
            DevKit.GetAndAssert<RealtimeList, Realtime>(Realtime);
       }

        [TestMethod]
        public void Realtime131DataAdapter_AddToStore_Can_Add_Realtime()
        {
            AddParents();
            DevKit.AddAndAssert<RealtimeList, Realtime>(Realtime);
        }

        [TestMethod]
        public void Realtime131DataAdapter_UpdateInStore_Can_Update_Realtime()
        {
            AddParents();
            DevKit.AddAndAssert<RealtimeList, Realtime>(Realtime);
            DevKit.UpdateAndAssert<RealtimeList, Realtime>(Realtime);
            DevKit.GetAndAssert<RealtimeList, Realtime>(Realtime);
        }

        [TestMethod]
        public void Realtime131DataAdapter_DeleteFromStore_Can_Delete_Realtime()
        {
            AddParents();
            DevKit.AddAndAssert<RealtimeList, Realtime>(Realtime);
            DevKit.DeleteAndAssert<RealtimeList, Realtime>(Realtime);
            DevKit.GetAndAssert<RealtimeList, Realtime>(Realtime, isNotNull: false);
        }
    }
}