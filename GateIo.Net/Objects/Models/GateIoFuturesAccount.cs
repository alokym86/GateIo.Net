﻿using System.Text.Json.Serialization;

namespace GateIo.Net.Objects.Models
{
    /// <summary>
    /// Futures account
    /// </summary>
    public record GateIoFuturesAccount
    {
        /// <summary>
        /// User id
        /// </summary>
        [JsonPropertyName("user")]
        public long UserId { get; set; }
        /// <summary>
        /// Asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// The balance after the user's accumulated deposit, withdraw, profit and loss
        /// </summary>
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
        /// <summary>
        /// Unrealized profit and loss
        /// </summary>
        [JsonPropertyName("unrealised_pnl")]
        public decimal UnrealisedPnl { get; set; }
        /// <summary>
        /// Position margin
        /// </summary>
        [JsonPropertyName("position_margin")]
        public decimal PositionMargin { get; set; }
        /// <summary>
        /// Order margin
        /// </summary>
        [JsonPropertyName("order_margin")]
        public decimal OrderMargin { get; set; }
        /// <summary>
        /// Available
        /// </summary>
        [JsonPropertyName("available")]
        public decimal Available { get; set; }
        /// <summary>
        /// Point quantity
        /// </summary>
        [JsonPropertyName("point")]
        public decimal PointQuantity { get; set; }
        /// <summary>
        /// Perpetual Contract Bonus
        /// </summary>
        [JsonPropertyName("bonus")]
        public decimal Bonus { get; set; }
        /// <summary>
        /// Dual mode
        /// </summary>
        [JsonPropertyName("in_dual_mode")]
        public bool DualMode { get; set; }
        /// <summary>
        /// Classic account margin mode
        /// </summary>
        [JsonPropertyName("enable_evolved_classic")]
        public bool ClassicMarginMode { get; set; }
        /// <summary>
        /// Total history
        /// </summary>
        [JsonPropertyName("history")]
        public GateIoFuturesAccountHistory Totals { get; set; } = null!;
    }

    /// <summary>
    /// Account history
    /// </summary>
    public record GateIoFuturesAccountHistory
    {
        /// <summary>
        /// Total amount of deposit and withdraw
        /// </summary>
        [JsonPropertyName("dnw")]
        public decimal DepositWithdrawalQuantity { get; set; }
        /// <summary>
        /// Total Profit and loss
        /// </summary>
        [JsonPropertyName("pnl")]
        public decimal TotalProfitAndLoss { get; set; }
        /// <summary>
        /// Total amount of fee paid
        /// </summary>
        [JsonPropertyName("fee")]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// Total amount of referrer rebates
        /// </summary>
        [JsonPropertyName("refr")]
        public decimal TotalReferenceRebate { get; set; }
        /// <summary>
        /// Total amount of funding costs
        /// </summary>
        [JsonPropertyName("fund")]
        public decimal TotalFundingCosts { get; set; }
        /// <summary>
        /// Total amount of point deposit and withdraw
        /// </summary>
        [JsonPropertyName("point_dnw")]
        public decimal TotalPointDepositWithdrawal { get; set; }
        /// <summary>
        /// Total amount of point fee
        /// </summary>
        [JsonPropertyName("point_fee")]
        public decimal TotalPointFee { get; set; }
        /// <summary>
        /// Total amountof point referrer rebates
        /// </summary>
        [JsonPropertyName("point_refr")]
        public decimal TotalPointReferenceRebate { get; set; }
        /// <summary>
        /// Total amount of perpetual contract bonus transfer
        /// </summary>
        [JsonPropertyName("bonus_dnw")]
        public decimal TotalBonusDepositAndWithdrawal { get; set; }
        /// <summary>
        /// Total amount of perpetual contract bonus deduction
        /// </summary>
        [JsonPropertyName("bonus_offset")]
        public decimal TotalBonusDeduction { get; set; }
    }
}
