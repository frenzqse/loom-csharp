﻿using System;
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
        public RetryDefaultExceptionHandler()
        {
        }
        /// <summary>
        /// Defines how the Bridge should be have. In this example, it checks if the mehtod should be exected again or
        /// if the Exception should be forwarded.
        /// </summary>
        /// <param name="exception">The exception, which has been thrown</param>
        /// <param name="obj">Parameters of the method</param>
        /// <returns></returns>
        public override Object HandleException(Exception exception,params Object[] obj)
        {
            // Invokes the method that throws the exception again.
            return Invoke(obj);
            
        }
    }
}