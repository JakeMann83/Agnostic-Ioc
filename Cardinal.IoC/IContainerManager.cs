﻿// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) 2014, Simon Proctor and Nathanael Mann
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Cardinal.IoC.Registration;

namespace Cardinal.IoC
{
    public interface IContainerManager
    {
        /// <summary>
        /// Attempts to resolve the dependency
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <returns>
        /// The resolved dependency
        /// </returns>
        T Resolve<T>();

        /// <summary>
        /// Attempts to resolve the dependency returning the default if failed
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <returns>
        /// The resolved dependency or default
        /// </returns>
        T TryResolve<T>();

        /// <summary>
        /// Attempts to resolve the dependency
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <param name="name">
        /// The component name
        /// </param>
        /// <returns>
        /// The resolved dependency
        /// </returns>
        T Resolve<T>(string name);

        /// <summary>
        /// Attempts to resolve the dependency returning the default if failed
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <param name="name">
        /// The component name
        /// </param>
        /// <returns>
        /// The resolved dependency or default
        /// </returns>
        T TryResolve<T>(string name);

        /// <summary>
        /// Attempts to resolve the dependency
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <param name="name">
        /// The component name
        /// </param>
        /// <param name="parameters">
        /// The arguments
        /// </param>
        /// <returns>
        /// The resolved dependency
        /// </returns>
        T Resolve<T>(string name, IDictionary<string, object> parameters);

        /// <summary>
        /// Attempts to resolve the dependency returning the default if failed
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <param name="name">
        /// The component name
        /// </param>
        /// <param name="arguments">
        /// The arguments
        /// </param>
        /// <returns>
        /// The resolved dependency or default
        /// </returns>
        T TryResolve<T>(string name, IDictionary<string, object> arguments);

        /// <summary>
        /// Attempts to resolve the dependency
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <returns>
        /// The resolved dependency
        /// </returns>
        T Resolve<T>(IDictionary<string, object> parameters);

        /// <summary>
        /// Attempts to resolve the dependency returning the default if failed
        /// </summary>
        /// <typeparam name="T">
        /// The type to resolve
        /// </typeparam>
        /// <returns>
        /// The resolved dependency or default
        /// </returns>
        T TryResolve<T>(IDictionary<string, object> parameters);

        /// <summary>
        /// Gets the current adapter
        /// </summary>
        IContainerAdapter CurrentAdapter { get; }

        /// <summary>
        /// Resolves all instances of the given type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<T> ResolveAll<T>();
    }
}
