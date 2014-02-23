﻿#region Copyright
// <copyright file="CustomJsonUnMarshaller.cs" company="OpenEngSB">
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
using Newtonsoft.Json;

namespace Org.Openengsb.Loom.CSharp.Bridge.Implementation.Communication.Json
{
    /// <summary>
    /// Json Marshaller, which converts Maps (java) to a EntryX (X is a number)
    /// </summary>
    public class CustomJsonUnMarshaller : AbstractJsonMarshaller
    {
        #region Public Methods
        public override bool CanConvert(Type objectType)
        {
            return IsMapType(objectType) || IsException(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("This state should never be reached");
        }
        #endregion
    }
}