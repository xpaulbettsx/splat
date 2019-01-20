﻿// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using SimpleInjector;

namespace Splat.SimpleInjector
{
    /// <summary>
    /// Extension methods for the Autofac adapter.
    /// </summary>
    public static class SplatSimpleInjectorExtensions
    {
        /// <summary>
        /// Initializes an instance of <see cref="SimpleInjectorDependencyResolver"/> that overrides the default <see cref="Locator"/>.
        /// </summary>
        /// <param name="container">Simple Injector container.</param>
        public static void UseSimpleInjectorDependencyResolver(this Container container) =>
            Locator.Current = new SimpleInjectorDependencyResolver(container);
    }
}
