﻿#region Copyright
// <copyright file="RetryDefaultExceptionHandler.cs" company="OpenEngSB">
// Licensed to the Austrian Association for Software Tool Integration (AASTI)
// under one or more contributor license agreements. See the NOTICE file
// distributed with this work for additional information regarding copyright
// ownership. The AASTI licenses this file to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file except in compliance
// with the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.Openengsb.Loom.CSharp.Bridge.Interface;
using Org.Openengsb.Loom.CSharp.Bridge.Interface.ExceptionHandling;

namespace Org.Openengsb.Loom.CSharp.Bridge.Implementation.Common
{
    /// <summary>
    /// This is a basic ExceptionHandler and should illustrate the Handling
    /// </summary>
    public class RetryDefaultExceptionHandler : ABridgeExceptionHandling
    {
        #region Constructors
        public RetryDefaultExceptionHandler()
        {
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Defines how the Bridge should be have. In this example, it checks if the mehtod should be exected again or
        /// if the Exception should be forwarded.
        /// </summary>
        /// <param name="exception">The exception, which has been thrown</param>
        /// <param name="obj">Parameters of the method</param>
        /// <returns></returns>
        public override Object HandleException(Exception exception, params Object[] obj)
        {
            // Invokes the method that throws the exception, again.
            return Invoke(obj);
        }
        #endregion
    }
}