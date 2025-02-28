// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Hold values properties, which is array of KubernetesVersion
    /// </summary>
    public partial class KubernetesVersionListResult
    {
        /// <summary>
        /// Initializes a new instance of the KubernetesVersionListResult
        /// class.
        /// </summary>
        public KubernetesVersionListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KubernetesVersionListResult
        /// class.
        /// </summary>
        /// <param name="values">Array of AKS supported Kubernetes
        /// versions.</param>
        public KubernetesVersionListResult(IList<KubernetesVersion> values = default(IList<KubernetesVersion>))
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of AKS supported Kubernetes versions.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<KubernetesVersion> Values { get; set; }

    }
}
