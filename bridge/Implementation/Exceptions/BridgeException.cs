﻿#region Copyright
// <copyright file="BridgeException.cs" company="OpenEngSB">
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

namespace Org.Openengsb.Loom.CSharp.Bridge.Implementation.Exceptions
{
    /// <summary>
    /// Exception for Problems with the OpenEngSB Connection
    /// </summary>
    public class BridgeException : Exception
    {
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public BridgeException()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        public BridgeException(string message)
        : base(message)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception Message</param>
        /// <param name="inner">Inner Exception</param>
        public BridgeException(string message, Exception inner)
        : base(message, inner)
        {
        }
        #endregion
    }
}