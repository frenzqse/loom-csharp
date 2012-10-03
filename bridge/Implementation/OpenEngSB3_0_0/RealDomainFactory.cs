﻿/***
 * Licensed to the Austrian Association for Software Tool Integration (AASTI)
 * under one or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information regarding copyright
 * ownership. The AASTI licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 ***/
using System;
using System.Collections.Generic;
using Org.Openengsb.Loom.CSharp.Bridge.Interface.Common;
using Org.Openengsb.Loom.CSharp.Bridge.Interface.OpenEngSB3_0_0.Remote;
using Org.Openengsb.Loom.CSharp.Bridge.Interface;

namespace Org.Openengsb.Loom.CSharp.Bridge.Interface.OpenEngSB3_0_0
{
    /// <summary>
    /// This class produces and manages proxies.
    /// </summary>
    public class RealDomainFactory<T> : AbstractRealDomainFactory<T>
    {
        public RealDomainFactory(string destination, T domainService, EExceptionHandling exceptionhandling)
            : base(destination, domainService, exceptionhandling)
        {
        }
        public RealDomainFactory(string destination, T domainService)
            : base(destination, domainService)
        {
        }
        #region Abstact Method Implementation
        protected override A getSubEventhandler<A>(String domainType)
        {
            return new DomainProxy<A>(destination, getDomainTypServiceId(domainType), domainType,exceptionhandling).GetTransparentProxy();
        }
        protected override DomainReverse<T> createInstance(string serviceId, string domainType, bool createConstructor)
        {
            return new DomainReverseProxy<T>(domainService, destination, serviceId, domainType, createConstructor, exceptionhandling);
        }
        protected override DomainReverse<T> createInstance(string serviceId, string domainType, bool createConstructor, string username, string password)
        {
            return new DomainReverseProxy<T>(domainService, destination, serviceId, domainType, username, password, createConstructor, exceptionhandling);
        }
        #endregion

    }
}