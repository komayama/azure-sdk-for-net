// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> StringNotBeginsWith Filter. </summary>
    public partial class StringNotBeginsWithFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of StringNotBeginsWithFilter. </summary>
        public StringNotBeginsWithFilter()
        {
            Values = new ChangeTrackingList<string>();
            OperatorType = FilterOperatorType.StringNotBeginsWith;
        }

        /// <summary> Initializes a new instance of StringNotBeginsWithFilter. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="values"> The set of filter values. </param>
        internal StringNotBeginsWithFilter(FilterOperatorType operatorType, string key, IList<string> values) : base(operatorType, key)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        public IList<string> Values { get; }
    }
}
