﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using Microsoft.AspNet.Hosting;

namespace Microsoft.AspNet.Server.KestrelTests
{
    public class ShutdownNotImplemented : IApplicationLifetime
    {
        public CancellationToken ApplicationStarted
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CancellationToken ApplicationStopped
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CancellationToken ApplicationStopping
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CancellationToken ShutdownRequested
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void RequestShutdown()
        {
            throw new NotImplementedException();
        }
    }
}
