﻿#region Copyright
// <copyright file="ConnectorDescription.cs" company="OpenEngSB">
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
using Newtonsoft.Json;

namespace Org.Openengsb.Loom.CSharp.Bridge.OpenEngSB300.Remote.RemoteObjects
{
    /// <summary>
    /// This class represents an Connector instance on the bus.
    /// </summary>
    public class ConnectorDescription
    {
        #region Variables
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<String, Object> Properties { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public IDictionary<String, String> Attributes { get; set; }

        [JsonProperty(PropertyName = "domainType")]
        public String DomainType { get; set; }

        [JsonProperty(PropertyName = "connectorType")]
        public String ConnectorType { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ConnectorDescription()
        {
            Attributes = new Dictionary<string, string>();
            Properties = new Dictionary<string, object>();
        }

        #endregion
    }
}
