// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The hierarchy node which contains the instances matching the query
    /// based on the input. May be empty or null.
    /// </summary>
    public partial class HierarchyHit
    {
        /// <summary>
        /// Initializes a new instance of the HierarchyHit class.
        /// </summary>
        public HierarchyHit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HierarchyHit class.
        /// </summary>
        /// <param name="name">Name of the hierarchy node. May be empty, cannot
        /// be null.</param>
        /// <param name="cumulativeInstanceCount">Total number of instances
        /// that belong to this node and it's subtrees matching the
        /// query.</param>
        /// <param name="hierarchyNodes">Child hierarchy nodes of this node.
        /// May be empty or null.</param>
        public HierarchyHit(string name = default(string), int? cumulativeInstanceCount = default(int?), SearchHierarchyNodesResponse hierarchyNodes = default(SearchHierarchyNodesResponse))
        {
            Name = name;
            CumulativeInstanceCount = cumulativeInstanceCount;
            HierarchyNodes = hierarchyNodes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the hierarchy node. May be empty, cannot be null.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets total number of instances that belong to this node and it's
        /// subtrees matching the query.
        /// </summary>
        [JsonProperty(PropertyName = "cumulativeInstanceCount")]
        public int? CumulativeInstanceCount { get; private set; }

        /// <summary>
        /// Gets child hierarchy nodes of this node. May be empty or null.
        /// </summary>
        [JsonProperty(PropertyName = "hierarchyNodes")]
        public SearchHierarchyNodesResponse HierarchyNodes { get; private set; }

    }
}
