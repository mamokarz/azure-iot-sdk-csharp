﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    using Newtonsoft.Json;

    /// <summary>
    /// Used to describe the X509 attestation mechanism.
    /// </summary>
    public sealed class X509Attestation
    {
        /// <summary>
        /// Creates a new instance of <see cref="X509Attestation"/>
        /// </summary>
        public X509Attestation()
        {
        }

        /// <summary>
        /// Client certificates.
        /// </summary>
        [JsonProperty(PropertyName = "clientCertificates")]
        public X509Certificates ClientCertificates { get; set; }

        /// <summary>
        /// Signing certificates.
        /// </summary>
        [JsonProperty(PropertyName = "signingCertificates")]
        public X509Certificates SigningCertificates { get; set; }
    }
}
