﻿using System.Collections.Generic;
using Lykke.MatchingEngine.Connector.Models.Common;

namespace Lykke.MatchingEngine.Connector.Models.Api
{
    /// <summary>
    /// Market order fee model.
    /// </summary>
    public class MarketOrderFeeModel
    {
        public FeeType Type { get; set; }

        public double Size { get; set; }

        public string SourceClientId { get; set; }

        public string TargetClientId { get; set; }

        public FeeSizeType SizeType { get; set; }

        public IReadOnlyList<string> AssetId { get; set; } = new List<string>(0);
    }
}
