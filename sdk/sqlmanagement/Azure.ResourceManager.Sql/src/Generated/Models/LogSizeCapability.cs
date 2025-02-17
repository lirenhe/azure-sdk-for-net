// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The log size capability. </summary>
    public partial class LogSizeCapability
    {
        /// <summary> Initializes a new instance of LogSizeCapability. </summary>
        internal LogSizeCapability()
        {
        }

        /// <summary> Initializes a new instance of LogSizeCapability. </summary>
        /// <param name="limit"> The log size limit (see 'unit' for the units). </param>
        /// <param name="unit"> The units that the limit is expressed in. </param>
        internal LogSizeCapability(int? limit, LogSizeUnit? unit)
        {
            Limit = limit;
            Unit = unit;
        }

        /// <summary> The log size limit (see 'unit' for the units). </summary>
        public int? Limit { get; }
        /// <summary> The units that the limit is expressed in. </summary>
        public LogSizeUnit? Unit { get; }
    }
}
