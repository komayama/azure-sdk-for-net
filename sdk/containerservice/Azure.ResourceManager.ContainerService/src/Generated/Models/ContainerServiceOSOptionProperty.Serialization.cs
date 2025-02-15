// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceOSOptionProperty
    {
        internal static ContainerServiceOSOptionProperty DeserializeContainerServiceOSOptionProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string osType = default;
            bool enableFipsImage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("os-type"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enable-fips-image"u8))
                {
                    enableFipsImage = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ContainerServiceOSOptionProperty(osType, enableFipsImage);
        }
    }
}
