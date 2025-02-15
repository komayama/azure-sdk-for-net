// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> The updatable properties of the TagRule. </summary>
    public partial class DynatraceTagRulePatch
    {
        /// <summary> Initializes a new instance of DynatraceTagRulePatch. </summary>
        public DynatraceTagRulePatch()
        {
        }

        /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
        public DynatraceMonitorResourceLogRules LogRules { get; set; }
        /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
        internal DynatraceMonitorResourceMetricRules MetricRules { get; set; }
        /// <summary> List of filtering tags to be used for capturing metrics. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags. </summary>
        public IList<DynatraceMonitorResourceFilteringTag> MetricRulesFilteringTags
        {
            get
            {
                if (MetricRules is null)
                    MetricRules = new DynatraceMonitorResourceMetricRules();
                return MetricRules.FilteringTags;
            }
        }
    }
}
