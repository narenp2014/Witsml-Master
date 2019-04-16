﻿//----------------------------------------------------------------------- 
// PDS WITSMLstudio Framework, 2018.3
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

namespace PDS.WITSMLstudio.Framework
{
    /// <summary>
    /// Generic helper class for ParseEnum method.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class Enum<T>
    {
        /// <summary>
        /// Parses the specified enumeration value.
        /// </summary>
        /// <param name="enumValue">The enum value.</param>
        /// <param name="ignoreCase">if set to <c>true</c> comparison is case insensitive.</param>
        /// <returns>The parsed enumeration value.</returns>
        public static T Parse(string enumValue, bool ignoreCase = true)
        {
            return (T) typeof(T).ParseEnum(enumValue, ignoreCase);
        }
    }
}