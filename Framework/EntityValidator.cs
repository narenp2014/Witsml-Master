﻿//----------------------------------------------------------------------- 
// PDS WITSMLstudio Framework, 2018.1
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

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDS.WITSMLstudio.Framework
{
    /// <summary>
    /// Defines a helper method that can be used to validate objects using data annotation attributes.
    /// </summary>
    public static class EntityValidator
    {
        /// <summary>
        /// Determines whether the specified object is valid.
        /// </summary>
        /// <param name="instance">The object instance.</param>
        /// <param name="results">The validation results.</param>
        /// <returns>true if the object is valid; otherwise, false</returns>
        public static bool TryValidate(object instance, out IList<ValidationResult> results)
        {
            var context = new ValidationContext(instance, serviceProvider: null, items: null);
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(instance, context, results, validateAllProperties: true);
        }
    }
}
