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
    /// Regional mbox request.
    /// </summary>
    [DataContract(Name = "MboxRequest")]
    public partial class MboxRequest : IEquatable<MboxRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MboxRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MboxRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MboxRequest" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="parameters">Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. .</param>
        /// <param name="profileParameters">Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. .</param>
        /// <param name="order">order.</param>
        /// <param name="product">product.</param>
        /// <param name="index">An index for the mboxes to be executed or prefetched. Mbox index is used for correlation between the mbox request with the mbox response, for either prefetch or execute responses. Index should be unique in the mbox list.  (required).</param>
        /// <param name="name">The name of the regional mbox to be evaluated. .</param>
        public MboxRequest(Address address = default(Address), Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, string> profileParameters = default(Dictionary<string, string>), Order order = default(Order), Product product = default(Product), int index = default(int), string name = default(string))
        {
            this.Index = index;
            this.Address = address;
            this.Parameters = parameters;
            this.ProfileParameters = profileParameters;
            this.Order = order;
            this.Product = product;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. 
        /// </summary>
        /// <value>Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. </value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. 
        /// </summary>
        /// <value>Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. </value>
        [DataMember(Name = "profileParameters", EmitDefaultValue = false)]
        public Dictionary<string, string> ProfileParameters { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public Order Order { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public Product Product { get; set; }

        /// <summary>
        /// An index for the mboxes to be executed or prefetched. Mbox index is used for correlation between the mbox request with the mbox response, for either prefetch or execute responses. Index should be unique in the mbox list. 
        /// </summary>
        /// <value>An index for the mboxes to be executed or prefetched. Mbox index is used for correlation between the mbox request with the mbox response, for either prefetch or execute responses. Index should be unique in the mbox list. </value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// The name of the regional mbox to be evaluated. 
        /// </summary>
        /// <value>The name of the regional mbox to be evaluated. </value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MboxRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ProfileParameters: ").Append(ProfileParameters).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as MboxRequest);
        }

        /// <summary>
        /// Returns true if MboxRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MboxRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MboxRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.ProfileParameters == input.ProfileParameters ||
                    this.ProfileParameters != null &&
                    input.ProfileParameters != null &&
                    this.ProfileParameters.SequenceEqual(input.ProfileParameters)
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.ProfileParameters != null)
                    hashCode = hashCode * 59 + this.ProfileParameters.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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