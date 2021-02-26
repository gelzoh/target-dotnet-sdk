// <auto-generated/>
/*
 * Copyright 2021 Adobe. All rights reserved.
 * This file is licensed to you under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a copy
 * of the License at http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
 * OF ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adobe.Target.Delivery.Client.OpenAPIDateConverter;

namespace Adobe.Target.Delivery.Model
{
    /// <summary>
    /// Mbox response object. 
    /// </summary>
    [DataContract(Name = "MboxResponse")]
    public partial class MboxResponse : IEquatable<MboxResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MboxResponse" /> class.
        /// </summary>
        /// <param name="index">Indicates that the response is for mbox with the same index, as was specified in the prefetch or execute request. .</param>
        /// <param name="name">The name of the mbox. Since the same mbox name can be specified multiple times in the request it should be used in conjunction with the index. .</param>
        /// <param name="options">The option that was matched for the current mbox. Cannot be an offer with templates or a visual offer. .</param>
        /// <param name="metrics">Click metrics..</param>
        /// <param name="analytics">analytics.</param>
        /// <param name="trace">The object containing all trace data for the request, only present if the trace token was provided in the request. .</param>
        public MboxResponse(int index = default(int), string name = default(string), List<Option> options = default(List<Option>), List<Metric> metrics = default(List<Metric>), AnalyticsResponse analytics = default(AnalyticsResponse), Dictionary<string, Object> trace = default(Dictionary<string, Object>))
        {
            this.Index = index;
            this.Name = name;
            this.Options = options;
            this.Metrics = metrics;
            this.Analytics = analytics;
            this.Trace = trace;
        }

        /// <summary>
        /// Indicates that the response is for mbox with the same index, as was specified in the prefetch or execute request. 
        /// </summary>
        /// <value>Indicates that the response is for mbox with the same index, as was specified in the prefetch or execute request. </value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// The name of the mbox. Since the same mbox name can be specified multiple times in the request it should be used in conjunction with the index. 
        /// </summary>
        /// <value>The name of the mbox. Since the same mbox name can be specified multiple times in the request it should be used in conjunction with the index. </value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The option that was matched for the current mbox. Cannot be an offer with templates or a visual offer. 
        /// </summary>
        /// <value>The option that was matched for the current mbox. Cannot be an offer with templates or a visual offer. </value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<Option> Options { get; set; }

        /// <summary>
        /// Click metrics.
        /// </summary>
        /// <value>Click metrics.</value>
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public List<Metric> Metrics { get; set; }

        /// <summary>
        /// Gets or Sets Analytics
        /// </summary>
        [DataMember(Name = "analytics", EmitDefaultValue = false)]
        public AnalyticsResponse Analytics { get; set; }

        /// <summary>
        /// The object containing all trace data for the request, only present if the trace token was provided in the request. 
        /// </summary>
        /// <value>The object containing all trace data for the request, only present if the trace token was provided in the request. </value>
        [DataMember(Name = "trace", EmitDefaultValue = false)]
        public Dictionary<string, Object> Trace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MboxResponse {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Analytics: ").Append(Analytics).Append("\n");
            sb.Append("  Trace: ").Append(Trace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MboxResponse);
        }

        /// <summary>
        /// Returns true if MboxResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MboxResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MboxResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.Analytics == input.Analytics ||
                    (this.Analytics != null &&
                    this.Analytics.Equals(input.Analytics))
                ) && 
                (
                    this.Trace == input.Trace ||
                    this.Trace != null &&
                    input.Trace != null &&
                    this.Trace.SequenceEqual(input.Trace)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.Analytics != null)
                    hashCode = hashCode * 59 + this.Analytics.GetHashCode();
                if (this.Trace != null)
                    hashCode = hashCode * 59 + this.Trace.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
