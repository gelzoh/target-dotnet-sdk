// <auto-generated/>
/*
 * Copyright 2020 Adobe. All rights reserved.
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
    /// Object that contains the identifiers for the visitor. If no id is provided in the first request, Target will generate a VisitorId with a tntId. The code that runs on the client side is then responsible for passing this tntId value on all subsequent calls.  Validation   * Either tntId, thirdPartyId or maketingCloudVisistorId required. 
    /// </summary>
    [DataContract(Name = "VisitorId")]
    public partial class VisitorId : IEquatable<VisitorId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorId" /> class.
        /// </summary>
        /// <param name="tntId">Tnt id - an unique identifier (UUID). If no visitor id is provided the TNT id will be generated by the TNT server. The TNT id retunred by the server may also contain the profile location hint, with the same format as for other endpoints (standard/ajax/json/..). Example 32440324234-2343423.23_41, in this example the 23_41 is the profile location hint. Tnt id retuned in the response (containting the profile location hint) should be used in the subsequent requests  Validation   * Should not contain a &#39;.&#39; (dot) unless the dot delimits the location hint. .</param>
        /// <param name="thirdPartyId">Third party id .</param>
        /// <param name="marketingCloudVisitorId">Marketing cloud visitor id .</param>
        /// <param name="customerIds">Along with the marketing cloud visitor id, you can associate additional customer ids  Validation   * No null elements. .</param>
        public VisitorId(string tntId = default(string), string thirdPartyId = default(string), string marketingCloudVisitorId = default(string), List<CustomerId> customerIds = default(List<CustomerId>))
        {
            this.TntId = tntId;
            this.ThirdPartyId = thirdPartyId;
            this.MarketingCloudVisitorId = marketingCloudVisitorId;
            this.CustomerIds = customerIds;
        }

        /// <summary>
        /// Tnt id - an unique identifier (UUID). If no visitor id is provided the TNT id will be generated by the TNT server. The TNT id retunred by the server may also contain the profile location hint, with the same format as for other endpoints (standard/ajax/json/..). Example 32440324234-2343423.23_41, in this example the 23_41 is the profile location hint. Tnt id retuned in the response (containting the profile location hint) should be used in the subsequent requests  Validation   * Should not contain a &#39;.&#39; (dot) unless the dot delimits the location hint. 
        /// </summary>
        /// <value>Tnt id - an unique identifier (UUID). If no visitor id is provided the TNT id will be generated by the TNT server. The TNT id retunred by the server may also contain the profile location hint, with the same format as for other endpoints (standard/ajax/json/..). Example 32440324234-2343423.23_41, in this example the 23_41 is the profile location hint. Tnt id retuned in the response (containting the profile location hint) should be used in the subsequent requests  Validation   * Should not contain a &#39;.&#39; (dot) unless the dot delimits the location hint. </value>
        [DataMember(Name = "tntId", EmitDefaultValue = false)]
        public string TntId { get; set; }

        /// <summary>
        /// Third party id 
        /// </summary>
        /// <value>Third party id </value>
        [DataMember(Name = "thirdPartyId", EmitDefaultValue = false)]
        public string ThirdPartyId { get; set; }

        /// <summary>
        /// Marketing cloud visitor id 
        /// </summary>
        /// <value>Marketing cloud visitor id </value>
        [DataMember(Name = "marketingCloudVisitorId", EmitDefaultValue = false)]
        public string MarketingCloudVisitorId { get; set; }

        /// <summary>
        /// Along with the marketing cloud visitor id, you can associate additional customer ids  Validation   * No null elements. 
        /// </summary>
        /// <value>Along with the marketing cloud visitor id, you can associate additional customer ids  Validation   * No null elements. </value>
        [DataMember(Name = "customerIds", EmitDefaultValue = false)]
        public List<CustomerId> CustomerIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VisitorId {\n");
            sb.Append("  TntId: ").Append(TntId).Append("\n");
            sb.Append("  ThirdPartyId: ").Append(ThirdPartyId).Append("\n");
            sb.Append("  MarketingCloudVisitorId: ").Append(MarketingCloudVisitorId).Append("\n");
            sb.Append("  CustomerIds: ").Append(CustomerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VisitorId);
        }

        /// <summary>
        /// Returns true if VisitorId instances are equal
        /// </summary>
        /// <param name="input">Instance of VisitorId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VisitorId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TntId == input.TntId ||
                    (this.TntId != null &&
                    this.TntId.Equals(input.TntId))
                ) && 
                (
                    this.ThirdPartyId == input.ThirdPartyId ||
                    (this.ThirdPartyId != null &&
                    this.ThirdPartyId.Equals(input.ThirdPartyId))
                ) && 
                (
                    this.MarketingCloudVisitorId == input.MarketingCloudVisitorId ||
                    (this.MarketingCloudVisitorId != null &&
                    this.MarketingCloudVisitorId.Equals(input.MarketingCloudVisitorId))
                ) && 
                (
                    this.CustomerIds == input.CustomerIds ||
                    this.CustomerIds != null &&
                    input.CustomerIds != null &&
                    this.CustomerIds.SequenceEqual(input.CustomerIds)
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
                if (this.TntId != null)
                    hashCode = hashCode * 59 + this.TntId.GetHashCode();
                if (this.ThirdPartyId != null)
                    hashCode = hashCode * 59 + this.ThirdPartyId.GetHashCode();
                if (this.MarketingCloudVisitorId != null)
                    hashCode = hashCode * 59 + this.MarketingCloudVisitorId.GetHashCode();
                if (this.CustomerIds != null)
                    hashCode = hashCode * 59 + this.CustomerIds.GetHashCode();
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
            // TntId (string) maxLength
            if(this.TntId != null && this.TntId.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TntId, length must be less than 128.", new [] { "TntId" });
            }

            // ThirdPartyId (string) maxLength
            if(this.ThirdPartyId != null && this.ThirdPartyId.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThirdPartyId, length must be less than 128.", new [] { "ThirdPartyId" });
            }

            // MarketingCloudVisitorId (string) maxLength
            if(this.MarketingCloudVisitorId != null && this.MarketingCloudVisitorId.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MarketingCloudVisitorId, length must be less than 128.", new [] { "MarketingCloudVisitorId" });
            }

            yield break;
        }
    }

}