//----------------------------------------------------------------------- 
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

// ----------------------------------------------------------------------
// <auto-generated>
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------

using Energistics.DataAccess;
using Energistics.DataAccess.WITSML141;
using Energistics.DataAccess.WITSML141.ComponentSchemas;
using Energistics.DataAccess.WITSML141.ReferenceData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PDS.WITSMLstudio.Store.Data.Messages
{
    [TestClass]
    public partial class Message141StoreTests : Message141TestBase
    {
        public Message141StoreTests()
            : base(false)
        {
        }

        [TestMethod]
        public void Message141DataAdapter_GetFromStore_Can_Get_Message()
        {
            AddParents();
            DevKit.AddAndAssert<MessageList, Message>(Message);
            DevKit.GetAndAssert<MessageList, Message>(Message);
       }

        [TestMethod]
        public void Message141DataAdapter_AddToStore_Can_Add_Message()
        {
            AddParents();
            DevKit.AddAndAssert<MessageList, Message>(Message);
        }

        [TestMethod]
        public void Message141DataAdapter_UpdateInStore_Can_Update_Message()
        {
            AddParents();
            DevKit.AddAndAssert<MessageList, Message>(Message);
            DevKit.UpdateAndAssert<MessageList, Message>(Message);
            DevKit.GetAndAssert<MessageList, Message>(Message);
        }

        [TestMethod]
        public void Message141DataAdapter_DeleteFromStore_Can_Delete_Message()
        {
            AddParents();
            DevKit.AddAndAssert<MessageList, Message>(Message);
            DevKit.DeleteAndAssert<MessageList, Message>(Message);
            DevKit.GetAndAssert<MessageList, Message>(Message, isNotNull: false);
        }

        [TestMethod]
        public void Message141WitsmlStore_GetFromStore_Can_Transform_Message()
        {
            AddParents();
            DevKit.AddAndAssert<MessageList, Message>(Message);

            // Re-initialize all capServer providers
            DevKit.Store.CapServerProviders = null;
            DevKit.Container.BuildUp(DevKit.Store);

            string typeIn, queryIn;
            var query = DevKit.List(DevKit.CreateQuery(Message));
            DevKit.SetupParameters<MessageList, Message>(query, ObjectTypes.Message, out typeIn, out queryIn);

            var options = OptionsIn.Join(OptionsIn.ReturnElements.All, OptionsIn.DataVersion.Version131);
            var request = new WMLS_GetFromStoreRequest(typeIn, queryIn, options, null);
            var response = DevKit.Store.WMLS_GetFromStore(request);

            Assert.IsFalse(string.IsNullOrWhiteSpace(response.XMLout));
            Assert.AreEqual((short)ErrorCodes.Success, response.Result);

            var result = WitsmlParser.Parse(response.XMLout);
            var version = ObjectTypes.GetVersion(result.Root);
            Assert.AreEqual(OptionsIn.DataVersion.Version131.Value, version);
        }

        [TestMethod]
        public void Message141DataAdapter_AddToStore_Creates_ChangeLog()
        {
            AddParents();

            DevKit.AddAndAssert<MessageList, Message>(Message);

            var result = DevKit.GetAndAssert<MessageList, Message>(Message);
            var expectedHistoryCount = 1;
            var expectedChangeType = ChangeInfoType.add;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);
        }

        [TestMethod]
        public void Message141DataAdapter_UpdateInStore_Updates_ChangeLog()
        {
            AddParents();

            DevKit.AddAndAssert<MessageList, Message>(Message);

            // Update the Message141
            Message.Name = "Change";
            DevKit.UpdateAndAssert(Message);

            var result = DevKit.GetAndAssert<MessageList, Message>(Message);
            var expectedHistoryCount = 2;
            var expectedChangeType = ChangeInfoType.update;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);
        }

        [TestMethod]
        public void Message141DataAdapter_DeleteFromStore_Updates_ChangeLog()
        {
            AddParents();

            DevKit.AddAndAssert<MessageList, Message>(Message);

            // Delete the Message141
            DevKit.DeleteAndAssert(Message);

            var expectedHistoryCount = 2;
            var expectedChangeType = ChangeInfoType.delete;
            DevKit.AssertChangeLog(Message, expectedHistoryCount, expectedChangeType);
        }

        [TestMethod]
        public void Message141DataAdapter_ChangeLog_Tracks_ChangeHistory_For_Add_Update_Delete()
        {
            AddParents();

            // Add the Message141
            DevKit.AddAndAssert<MessageList, Message>(Message);

            // Verify ChangeLog for Add
            var result = DevKit.GetAndAssert<MessageList, Message>(Message);
            var expectedHistoryCount = 1;
            var expectedChangeType = ChangeInfoType.add;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);

            // Update the Message141
            Message.Name = "Change";
            DevKit.UpdateAndAssert(Message);

            result = DevKit.GetAndAssert<MessageList, Message>(Message);
            expectedHistoryCount = 2;
            expectedChangeType = ChangeInfoType.update;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);

            // Delete the Message141
            DevKit.DeleteAndAssert(Message);

            expectedHistoryCount = 3;
            expectedChangeType = ChangeInfoType.delete;
            DevKit.AssertChangeLog(Message, expectedHistoryCount, expectedChangeType);

            // Re-add the same Message141...
            DevKit.AddAndAssert<MessageList, Message>(Message);

            //... the same changeLog should be reused.
            result = DevKit.GetAndAssert<MessageList, Message>(Message);
            expectedHistoryCount = 4;
            expectedChangeType = ChangeInfoType.add;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);

            DevKit.AssertChangeHistoryTimesUnique(result);
        }

        [TestMethod]
        public void Message141DataAdapter_GetFromStore_Filter_ExtensionNameValue()
        {
            AddParents();

            var extensionName1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var extensionName2 = DevKit.ExtensionNameValue("Ext-2", "2.0", "cm", PrimitiveType.@float);
            extensionName2.MeasureClass = MeasureClass.Length;
            var extensionName3 = DevKit.ExtensionNameValue("Ext-3", "3.0", "cm", PrimitiveType.unknown);

            Message.CommonData = new CommonData()
            {
                ExtensionNameValue = new List<ExtensionNameValue>()
                {
                    extensionName1, extensionName2, extensionName3
                }
            };

            // Add the Message141
            DevKit.AddAndAssert(Message);

            // Query for first extension
            var commonDataXml = "<commonData>" + Environment.NewLine +
                                "<extensionNameValue uid=\"\">" + Environment.NewLine +
                                "<name />{0}" + Environment.NewLine +
                                "</extensionNameValue>" + Environment.NewLine +
                                "</commonData>";

            var extValueQuery = string.Format(commonDataXml, "<dataType>double</dataType>");
            var queryXml = string.Format(BasicXMLTemplate, Message.UidWell, Message.UidWellbore, Message.Uid, extValueQuery);
            var result = DevKit.Query<MessageList, Message>(ObjectTypes.Message, queryXml, null, OptionsIn.ReturnElements.Requested);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            var resultMessage = result[0];
            Assert.IsNotNull(resultMessage);

            var commonData = resultMessage.CommonData;
            Assert.IsNotNull(commonData);
            Assert.AreEqual(1, commonData.ExtensionNameValue.Count);

            var env = commonData.ExtensionNameValue[0];
            Assert.IsNotNull(env);
            Assert.AreEqual(extensionName1.Uid, env.Uid);
            Assert.AreEqual(extensionName1.Name, env.Name);

            // Query for second extension
            extValueQuery = string.Format(commonDataXml, "<measureClass>length</measureClass>");
            queryXml = string.Format(BasicXMLTemplate, Message.UidWell, Message.UidWellbore, Message.Uid, extValueQuery);
            result = DevKit.Query<MessageList, Message>(ObjectTypes.Message, queryXml, null, OptionsIn.ReturnElements.Requested);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            resultMessage = result[0];
            Assert.IsNotNull(resultMessage);

            commonData = resultMessage.CommonData;
            Assert.IsNotNull(commonData);
            Assert.AreEqual(1, commonData.ExtensionNameValue.Count);

            env = commonData.ExtensionNameValue[0];
            Assert.IsNotNull(env);
            Assert.AreEqual(extensionName2.Uid, env.Uid);
            Assert.AreEqual(extensionName2.Name, env.Name);

            // Query for third extension
            extValueQuery = string.Format(commonDataXml, "<dataType>unknown</dataType>");
            queryXml = string.Format(BasicXMLTemplate, Message.UidWell, Message.UidWellbore, Message.Uid, extValueQuery);
            result = DevKit.Query<MessageList, Message>(ObjectTypes.Message, queryXml, null, OptionsIn.ReturnElements.Requested);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            resultMessage = result[0];
            Assert.IsNotNull(resultMessage);

            commonData = resultMessage.CommonData;
            Assert.IsNotNull(commonData);
            Assert.AreEqual(1, commonData.ExtensionNameValue.Count);

            env = commonData.ExtensionNameValue[0];
            Assert.IsNotNull(env);
            Assert.AreEqual(extensionName3.Uid, env.Uid);
            Assert.AreEqual(extensionName3.Name, env.Name);
        }

        [TestMethod]
        public void Message141DataAdapter_ChangeLog_Syncs_Message_Name_Changes()
        {
            AddParents();

            // Add the Message141
            DevKit.AddAndAssert<MessageList, Message>(Message);

            // Assert that all Message names match corresponding changeLog names
            DevKit.AssertChangeLogNames(Message);

            // Update the Message141 names
            Message.Name = "Change";
            Message.NameWell = "Well Name Change";

            Message.NameWellbore = "Wellbore Name Change";

            DevKit.UpdateAndAssert(Message);

            // Assert that all Message names match corresponding changeLog names
            DevKit.AssertChangeLogNames(Message);
        }
    }
}