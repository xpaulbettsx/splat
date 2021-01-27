// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using NUnit.Framework;

namespace Splat.IntegrationTest.NUnit
{
    /// <summary>
    /// Tests for the Default Mode Detector.
    /// </summary>
    public static class DetectTestRunner
    {
        /// <summary>
        /// Integration Test for the InUnitTestRunner Method.
        /// </summary>
        public sealed class InUnitTestRunnerMethod
        {
            /// <summary>
            /// Makes sure the detector returns true for nunit.
            /// </summary>
            [Test]
            public void ReturnsTrue()
            {
                var modeDetector = new DefaultModeDetector();
                var result = modeDetector.InUnitTestRunner();
                Assert.True(result);
            }
        }
    }
}
