// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class MigrationItemCollection
    {
        internal static MigrationItemCollection DeserializeMigrationItemCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MigrationItemData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigrationItemData> array = new List<MigrationItemData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrationItemData.DeserializeMigrationItemData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MigrationItemCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
