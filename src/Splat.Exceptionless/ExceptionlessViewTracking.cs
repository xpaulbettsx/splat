﻿using System;
using System.Collections.Generic;
using System.Text;
using Exceptionless;
using Exceptionless.Plugins;

namespace Splat
{
    /// <summary>
    /// Exceptionless View Tracking integration.
    /// </summary>
    public sealed class ExceptionlessViewTracking
    {
        private readonly ExceptionlessClient _exceptionlessClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionlessViewTracking"/> class.
        /// </summary>
        /// <param name="exceptionlessClient">The exceptionless client to use.</param>
        public ExceptionlessViewTracking(ExceptionlessClient exceptionlessClient)
        {
            _exceptionlessClient = exceptionlessClient ?? throw new ArgumentNullException(nameof(exceptionlessClient));
        }

        /// <summary>
        /// Track a view navigation using just a name.
        /// </summary>
        /// <param name="name">Name of the view.</param>
        public void OnViewNavigation(string name)
        {
            // need to consider whether to just use feature event
            // and tag it with view specific properties.
            var eventBuilder = _exceptionlessClient
                .CreateEvent()
                .SetType("PageView")
                .SetMessage(name);

            eventBuilder.Submit();
        }
    }
}