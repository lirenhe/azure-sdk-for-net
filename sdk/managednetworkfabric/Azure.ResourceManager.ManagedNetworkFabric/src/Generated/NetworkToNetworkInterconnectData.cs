// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkToNetworkInterconnect data model.
    /// The NetworkToNetworkInterconnect resource definition.
    /// </summary>
    public partial class NetworkToNetworkInterconnectData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkToNetworkInterconnectData. </summary>
        public NetworkToNetworkInterconnectData()
        {
        }

        /// <summary> Initializes a new instance of NetworkToNetworkInterconnectData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administrativeState"> Gets the administrativeState of the resource. Example -Enabled/Disabled. </param>
        /// <param name="isManagementType"> Configuration to use NNI for Infrastructure Management. Example: True/False. </param>
        /// <param name="useOptionB"> Based on this parameter the layer2/layer3 is made as mandatory. Example: True/False. </param>
        /// <param name="layer2Configuration"> Common properties for Layer2Configuration. </param>
        /// <param name="layer3Configuration"> Common properties for Layer3Configuration. </param>
        /// <param name="provisioningState"> Gets the provisioning state of the resource. </param>
        internal NetworkToNetworkInterconnectData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EnabledDisabledState? administrativeState, BooleanEnumProperty? isManagementType, BooleanEnumProperty? useOptionB, NetworkToNetworkInterconnectPropertiesLayer2Configuration layer2Configuration, Layer3Configuration layer3Configuration, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            AdministrativeState = administrativeState;
            IsManagementType = isManagementType;
            UseOptionB = useOptionB;
            Layer2Configuration = layer2Configuration;
            Layer3Configuration = layer3Configuration;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets the administrativeState of the resource. Example -Enabled/Disabled. </summary>
        public EnabledDisabledState? AdministrativeState { get; }
        /// <summary> Configuration to use NNI for Infrastructure Management. Example: True/False. </summary>
        public BooleanEnumProperty? IsManagementType { get; set; }
        /// <summary> Based on this parameter the layer2/layer3 is made as mandatory. Example: True/False. </summary>
        public BooleanEnumProperty? UseOptionB { get; set; }
        /// <summary> Common properties for Layer2Configuration. </summary>
        public NetworkToNetworkInterconnectPropertiesLayer2Configuration Layer2Configuration { get; set; }
        /// <summary> Common properties for Layer3Configuration. </summary>
        public Layer3Configuration Layer3Configuration { get; set; }
        /// <summary> Gets the provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
