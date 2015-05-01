﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Net;
using Org.Apache.REEF.Tang.Annotations;
using Org.Apache.REEF.Wake.Remote;
using Org.Apache.REEF.Wake.Remote.Impl;

namespace Org.Apache.REEF.Wake.Impl
{
    /// <summary>
    /// WritableRemoteManagerFactory for WritableRemoteManager.
    /// </summary>
    [Obsolete("Need to remove Iwritable and use IstreamingCodec. Please see Jira REEF-295 ", false)]
    public sealed class WritableRemoteManagerFactory
    {
        [Inject]
        private WritableRemoteManagerFactory()
        {
        }

        public IRemoteManager<T> GetInstance<T>(IPAddress localAddress, int port) where T : IWritable
        {
#pragma warning disable 618
// This is the one place allowed to call this constructor. Hence, disabling the warning is OK.
            return new WritableRemoteManager<T>(localAddress, port);
#pragma warning disable 618
        }

        public IRemoteManager<T> GetInstance<T>() where T : IWritable
        {
#pragma warning disable 618
// This is the one place allowed to call this constructor. Hence, disabling the warning is OK.
            return new WritableRemoteManager<T>();
#pragma warning disable 618
        }
    }
}