// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ClusterPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AggregatorOrSingleRackDefinition))
            {
                writer.WritePropertyName("aggregatorOrSingleRackDefinition"u8);
                writer.WriteObjectValue(AggregatorOrSingleRackDefinition);
            }
            if (Optional.IsDefined(ClusterLocation))
            {
                writer.WritePropertyName("clusterLocation"u8);
                writer.WriteStringValue(ClusterLocation);
            }
            if (Optional.IsDefined(ClusterServicePrincipal))
            {
                writer.WritePropertyName("clusterServicePrincipal"u8);
                writer.WriteObjectValue(ClusterServicePrincipal);
            }
            if (Optional.IsDefined(ComputeDeploymentThreshold))
            {
                writer.WritePropertyName("computeDeploymentThreshold"u8);
                writer.WriteObjectValue(ComputeDeploymentThreshold);
            }
            if (Optional.IsCollectionDefined(ComputeRackDefinitions))
            {
                writer.WritePropertyName("computeRackDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in ComputeRackDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
