// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DatabaseFleetManager
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _databaseFleetFleetsClientDiagnostics;
        private FleetsRestOperations _databaseFleetFleetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DatabaseFleetFleetsClientDiagnostics => _databaseFleetFleetsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DatabaseFleetManager", DatabaseFleetResource.ResourceType.Namespace, Diagnostics);
        private FleetsRestOperations DatabaseFleetFleetsRestClient => _databaseFleetFleetsRestClient ??= new FleetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DatabaseFleetResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists fleets in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseFleetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseFleetResource> GetDatabaseFleetsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DatabaseFleetFleetsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DatabaseFleetFleetsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DatabaseFleetResource(Client, DatabaseFleetData.DeserializeDatabaseFleetData(e)), DatabaseFleetFleetsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDatabaseFleets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists fleets in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseFleetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseFleetResource> GetDatabaseFleets(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DatabaseFleetFleetsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DatabaseFleetFleetsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DatabaseFleetResource(Client, DatabaseFleetData.DeserializeDatabaseFleetData(e)), DatabaseFleetFleetsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDatabaseFleets", "value", "nextLink", cancellationToken);
        }
    }
}
