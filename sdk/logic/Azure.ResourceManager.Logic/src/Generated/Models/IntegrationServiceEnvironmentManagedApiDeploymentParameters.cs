// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration service environment managed api deployment parameters. </summary>
    internal partial class IntegrationServiceEnvironmentManagedApiDeploymentParameters
    {
        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentManagedApiDeploymentParameters. </summary>
        public IntegrationServiceEnvironmentManagedApiDeploymentParameters()
        {
        }

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentManagedApiDeploymentParameters. </summary>
        /// <param name="contentLinkDefinition"> The integration service environment managed api content link for deployment. </param>
        internal IntegrationServiceEnvironmentManagedApiDeploymentParameters(LogicContentLink contentLinkDefinition)
        {
            ContentLinkDefinition = contentLinkDefinition;
        }

        /// <summary> The integration service environment managed api content link for deployment. </summary>
        public LogicContentLink ContentLinkDefinition { get; set; }
    }
}
