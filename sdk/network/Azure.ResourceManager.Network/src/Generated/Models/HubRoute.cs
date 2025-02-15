// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> RouteTable route. </summary>
    public partial class HubRoute
    {
        /// <summary> Initializes a new instance of HubRoute. </summary>
        /// <param name="name"> The name of the Route that is unique within a RouteTable. This name can be used to access this route. </param>
        /// <param name="destinationType"> The type of destinations (eg: CIDR, ResourceId, Service). </param>
        /// <param name="destinations"> List of all destinations. </param>
        /// <param name="nextHopType"> The type of next hop (eg: ResourceId). </param>
        /// <param name="nextHop"> NextHop resource ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="destinationType"/>, <paramref name="destinations"/>, <paramref name="nextHopType"/> or <paramref name="nextHop"/> is null. </exception>
        public HubRoute(string name, string destinationType, IEnumerable<string> destinations, string nextHopType, string nextHop)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(destinationType, nameof(destinationType));
            Argument.AssertNotNull(destinations, nameof(destinations));
            Argument.AssertNotNull(nextHopType, nameof(nextHopType));
            Argument.AssertNotNull(nextHop, nameof(nextHop));

            Name = name;
            DestinationType = destinationType;
            Destinations = destinations.ToList();
            NextHopType = nextHopType;
            NextHop = nextHop;
        }

        /// <summary> Initializes a new instance of HubRoute. </summary>
        /// <param name="name"> The name of the Route that is unique within a RouteTable. This name can be used to access this route. </param>
        /// <param name="destinationType"> The type of destinations (eg: CIDR, ResourceId, Service). </param>
        /// <param name="destinations"> List of all destinations. </param>
        /// <param name="nextHopType"> The type of next hop (eg: ResourceId). </param>
        /// <param name="nextHop"> NextHop resource ID. </param>
        internal HubRoute(string name, string destinationType, IList<string> destinations, string nextHopType, string nextHop)
        {
            Name = name;
            DestinationType = destinationType;
            Destinations = destinations;
            NextHopType = nextHopType;
            NextHop = nextHop;
        }

        /// <summary> The name of the Route that is unique within a RouteTable. This name can be used to access this route. </summary>
        public string Name { get; set; }
        /// <summary> The type of destinations (eg: CIDR, ResourceId, Service). </summary>
        public string DestinationType { get; set; }
        /// <summary> List of all destinations. </summary>
        public IList<string> Destinations { get; }
        /// <summary> The type of next hop (eg: ResourceId). </summary>
        public string NextHopType { get; set; }
        /// <summary> NextHop resource ID. </summary>
        public string NextHop { get; set; }
    }
}
