/* 
 * Location API
 *
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = unwired.Client.OpenAPIDateConverter;

namespace unwired.Model
{
    /// <summary>
    /// GeolocationErrorSchema
    /// </summary>
    [DataContract]
    public partial class GeolocationErrorSchema :  IEquatable<GeolocationErrorSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationErrorSchema" /> class.
        /// </summary>
        /// <param name="status">If the request is successful, ok is returned. Otherwise error is returned.</param>
        /// <param name="message">Any additional information from the server is returned here.</param>
        /// <param name="balance">This represents the remaining balance on the API token. Requests that return error are not charged and do not affect balance..</param>
        public GeolocationErrorSchema(string status = default(string), string message = default(string), long? balance = default(long?))
        {
            this.Status = status;
            this.Message = message;
            this.Balance = balance;
        }
        
        /// <summary>
        /// If the request is successful, ok is returned. Otherwise error is returned
        /// </summary>
        /// <value>If the request is successful, ok is returned. Otherwise error is returned</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Any additional information from the server is returned here
        /// </summary>
        /// <value>Any additional information from the server is returned here</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// This represents the remaining balance on the API token. Requests that return error are not charged and do not affect balance.
        /// </summary>
        /// <value>This represents the remaining balance on the API token. Requests that return error are not charged and do not affect balance.</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public long? Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeolocationErrorSchema {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return this.Equals(input as GeolocationErrorSchema);
        }

        /// <summary>
        /// Returns true if GeolocationErrorSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of GeolocationErrorSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeolocationErrorSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
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
