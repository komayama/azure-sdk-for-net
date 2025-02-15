// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DatabaseMigrationSqlDBResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DatabaseMigrationSqlDBResources and their operations over a DatabaseMigrationSqlDBResource. </returns>
        public virtual DatabaseMigrationSqlDBCollection GetDatabaseMigrationSqlDBs()
        {
            return GetCachedClient(Client => new DatabaseMigrationSqlDBCollection(Client, Id));
        }

        /// <summary> Gets a collection of DatabaseMigrationSqlMIResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DatabaseMigrationSqlMIResources and their operations over a DatabaseMigrationSqlMIResource. </returns>
        public virtual DatabaseMigrationSqlMICollection GetDatabaseMigrationSqlMIs()
        {
            return GetCachedClient(Client => new DatabaseMigrationSqlMICollection(Client, Id));
        }

        /// <summary> Gets a collection of DatabaseMigrationSqlVmResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DatabaseMigrationSqlVmResources and their operations over a DatabaseMigrationSqlVmResource. </returns>
        public virtual DatabaseMigrationSqlVmCollection GetDatabaseMigrationSqlVms()
        {
            return GetCachedClient(Client => new DatabaseMigrationSqlVmCollection(Client, Id));
        }

        /// <summary> Gets a collection of SqlMigrationServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SqlMigrationServiceResources and their operations over a SqlMigrationServiceResource. </returns>
        public virtual SqlMigrationServiceCollection GetSqlMigrationServices()
        {
            return GetCachedClient(Client => new SqlMigrationServiceCollection(Client, Id));
        }

        /// <summary> Gets a collection of DataMigrationServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataMigrationServiceResources and their operations over a DataMigrationServiceResource. </returns>
        public virtual DataMigrationServiceCollection GetDataMigrationServices()
        {
            return GetCachedClient(Client => new DataMigrationServiceCollection(Client, Id));
        }
    }
}
