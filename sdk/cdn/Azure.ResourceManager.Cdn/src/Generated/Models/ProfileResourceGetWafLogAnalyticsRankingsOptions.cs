// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ProfileResourceGetWafLogAnalyticsRankingsOptions. </summary>
    public partial class ProfileResourceGetWafLogAnalyticsRankingsOptions
    {
        /// <summary> Initializes a new instance of ProfileResourceGetWafLogAnalyticsRankingsOptions. </summary>
        /// <param name="metrics"> The ArrayOfWafMetric to use. </param>
        /// <param name="dateTimeBegin"> The DateTime to use. </param>
        /// <param name="dateTimeEnd"> The DateTime to use. </param>
        /// <param name="maxRanking"> The Integer to use. </param>
        /// <param name="rankings"> The ArrayOfWafRankingType to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metrics"/> or <paramref name="rankings"/> is null. </exception>
        public ProfileResourceGetWafLogAnalyticsRankingsOptions(IEnumerable<WafMetric> metrics, DateTimeOffset dateTimeBegin, DateTimeOffset dateTimeEnd, int maxRanking, IEnumerable<WafRankingType> rankings)
        {
            Argument.AssertNotNull(metrics, nameof(metrics));
            Argument.AssertNotNull(rankings, nameof(rankings));

            Metrics = metrics.ToList();
            DateTimeBegin = dateTimeBegin;
            DateTimeEnd = dateTimeEnd;
            MaxRanking = maxRanking;
            Rankings = rankings.ToList();
            Actions = new ChangeTrackingList<WafAction>();
            RuleTypes = new ChangeTrackingList<WafRuleType>();
        }

        /// <summary> The ArrayOfWafMetric to use. </summary>
        public IList<WafMetric> Metrics { get; }
        /// <summary> The DateTime to use. </summary>
        public DateTimeOffset DateTimeBegin { get; }
        /// <summary> The DateTime to use. </summary>
        public DateTimeOffset DateTimeEnd { get; }
        /// <summary> The Integer to use. </summary>
        public int MaxRanking { get; }
        /// <summary> The ArrayOfWafRankingType to use. </summary>
        public IList<WafRankingType> Rankings { get; }
        /// <summary> The ArrayOfWafAction to use. </summary>
        public IList<WafAction> Actions { get; }
        /// <summary> The ArrayOfWafRuleType to use. </summary>
        public IList<WafRuleType> RuleTypes { get; }
    }
}
