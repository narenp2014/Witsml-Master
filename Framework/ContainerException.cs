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

using System;
using System.Runtime.Serialization;

namespace PDS.WITSMLstudio.Framework
{
    /// <summary>
    /// Represents errors that occur during dependency resolution.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class ContainerException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerException"/> class.
        /// </summary>
        public ContainerException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ContainerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public ContainerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected ContainerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
