// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The RequestLogging. </summary>
    internal partial class RequestLogging
    {
        /// <summary> Initializes a new instance of RequestLogging. </summary>
        public RequestLogging()
        {
            CaptureHeaders = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RequestLogging. </summary>
        /// <param name="captureHeaders"> For payload logging, we only collect payload by default. If customers also want to collect the specified headers, they can set them in captureHeaders so that backend will collect those headers along with payload. </param>
        internal RequestLogging(IList<string> captureHeaders)
        {
            CaptureHeaders = captureHeaders;
        }

        /// <summary> For payload logging, we only collect payload by default. If customers also want to collect the specified headers, they can set them in captureHeaders so that backend will collect those headers along with payload. </summary>
        public IList<string> CaptureHeaders { get; set; }
    }
}
