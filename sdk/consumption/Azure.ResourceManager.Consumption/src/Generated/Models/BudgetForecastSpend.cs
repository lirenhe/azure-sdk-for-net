// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// The forecasted cost which is being tracked for a budget.
    /// Serialized Name: ForecastSpend
    /// </summary>
    public partial class BudgetForecastSpend
    {
        /// <summary> Initializes a new instance of BudgetForecastSpend. </summary>
        internal BudgetForecastSpend()
        {
        }

        /// <summary> Initializes a new instance of BudgetForecastSpend. </summary>
        /// <param name="amount">
        /// The forecasted cost for the total time period which is being tracked by the budget. This value is only provided if the budget contains a forecast alert type.
        /// Serialized Name: ForecastSpend.amount
        /// </param>
        /// <param name="unit">
        /// The unit of measure for the budget amount.
        /// Serialized Name: ForecastSpend.unit
        /// </param>
        internal BudgetForecastSpend(decimal? amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }

        /// <summary>
        /// The forecasted cost for the total time period which is being tracked by the budget. This value is only provided if the budget contains a forecast alert type.
        /// Serialized Name: ForecastSpend.amount
        /// </summary>
        public decimal? Amount { get; }
        /// <summary>
        /// The unit of measure for the budget amount.
        /// Serialized Name: ForecastSpend.unit
        /// </summary>
        public string Unit { get; }
    }
}
