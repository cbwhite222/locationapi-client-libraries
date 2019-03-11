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
    /// The response will be a JSON object.
    /// </summary>
    [DataContract]
    public partial class GeolocationResponseSchema :  IEquatable<GeolocationResponseSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationResponseSchema" /> class.
        /// </summary>
        /// <param name="status">If the request is successful, ok is returned. Otherwise error is returned.</param>
        /// <param name="message">Any additional information from the server is returned here.</param>
        /// <param name="balance">This represents the remaining balance on the API token. Requests that return error are not charged and do not affect balance.</param>
        /// <param name="balanceSlots">This represents the remaining balance of device slots. Requests that return error are not charged and do not affect balance. If -1 is returned, then observe it as an error while calculating slots balance. This element will only exist if you are on a device plan..</param>
        /// <param name="lat">The latitude representing the location.</param>
        /// <param name="lon">The longitude representing the location.</param>
        /// <param name="accuracy">The accuracy of the position is returned in meters.</param>
        /// <param name="address">The physical address of the location.</param>
        /// <param name="addressDetails">addressDetails.</param>
        /// <param name="aged">Shown when the location is based on a single measurement or those older than 90 days or is an LAC fallback.</param>
        /// <param name="fallback">fallback.</param>
        public GeolocationResponseSchema(string status = default(string), string message = default(string), long? balance = default(long?), long? balanceSlots = default(long?), double? lat = default(double?), double? lon = default(double?), long? accuracy = default(long?), string address = default(string), AddressDetailsSchema addressDetails = default(AddressDetailsSchema), int? aged = default(int?), FallbackSchema fallback = default(FallbackSchema))
        {
            this.Status = status;
            this.Message = message;
            this.Balance = balance;
            this.BalanceSlots = balanceSlots;
            this.Lat = lat;
            this.Lon = lon;
            this.Accuracy = accuracy;
            this.Address = address;
            this.AddressDetails = addressDetails;
            this.Aged = aged;
            this.Fallback = fallback;
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
        /// This represents the remaining balance on the API token. Requests that return error are not charged and do not affect balance
        /// </summary>
        /// <value>This represents the remaining balance on the API token. Requests that return error are not charged and do not affect balance</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public long? Balance { get; set; }

        /// <summary>
        /// This represents the remaining balance of device slots. Requests that return error are not charged and do not affect balance. If -1 is returned, then observe it as an error while calculating slots balance. This element will only exist if you are on a device plan.
        /// </summary>
        /// <value>This represents the remaining balance of device slots. Requests that return error are not charged and do not affect balance. If -1 is returned, then observe it as an error while calculating slots balance. This element will only exist if you are on a device plan.</value>
        [DataMember(Name="balance_slots", EmitDefaultValue=false)]
        public long? BalanceSlots { get; set; }

        /// <summary>
        /// The latitude representing the location
        /// </summary>
        /// <value>The latitude representing the location</value>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        public double? Lat { get; set; }

        /// <summary>
        /// The longitude representing the location
        /// </summary>
        /// <value>The longitude representing the location</value>
        [DataMember(Name="lon", EmitDefaultValue=false)]
        public double? Lon { get; set; }

        /// <summary>
        /// The accuracy of the position is returned in meters
        /// </summary>
        /// <value>The accuracy of the position is returned in meters</value>
        [DataMember(Name="accuracy", EmitDefaultValue=false)]
        public long? Accuracy { get; set; }

        /// <summary>
        /// The physical address of the location
        /// </summary>
        /// <value>The physical address of the location</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AddressDetails
        /// </summary>
        [DataMember(Name="address_details", EmitDefaultValue=false)]
        public AddressDetailsSchema AddressDetails { get; set; }

        /// <summary>
        /// Shown when the location is based on a single measurement or those older than 90 days or is an LAC fallback
        /// </summary>
        /// <value>Shown when the location is based on a single measurement or those older than 90 days or is an LAC fallback</value>
        [DataMember(Name="aged", EmitDefaultValue=false)]
        public int? Aged { get; set; }

        /// <summary>
        /// Gets or Sets Fallback
        /// </summary>
        [DataMember(Name="fallback", EmitDefaultValue=false)]
        public FallbackSchema Fallback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeolocationResponseSchema {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BalanceSlots: ").Append(BalanceSlots).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressDetails: ").Append(AddressDetails).Append("\n");
            sb.Append("  Aged: ").Append(Aged).Append("\n");
            sb.Append("  Fallback: ").Append(Fallback).Append("\n");
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
            return this.Equals(input as GeolocationResponseSchema);
        }

        /// <summary>
        /// Returns true if GeolocationResponseSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of GeolocationResponseSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeolocationResponseSchema input)
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
                ) && 
                (
                    this.BalanceSlots == input.BalanceSlots ||
                    (this.BalanceSlots != null &&
                    this.BalanceSlots.Equals(input.BalanceSlots))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lon == input.Lon ||
                    (this.Lon != null &&
                    this.Lon.Equals(input.Lon))
                ) && 
                (
                    this.Accuracy == input.Accuracy ||
                    (this.Accuracy != null &&
                    this.Accuracy.Equals(input.Accuracy))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressDetails == input.AddressDetails ||
                    (this.AddressDetails != null &&
                    this.AddressDetails.Equals(input.AddressDetails))
                ) && 
                (
                    this.Aged == input.Aged ||
                    (this.Aged != null &&
                    this.Aged.Equals(input.Aged))
                ) && 
                (
                    this.Fallback == input.Fallback ||
                    (this.Fallback != null &&
                    this.Fallback.Equals(input.Fallback))
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
                if (this.BalanceSlots != null)
                    hashCode = hashCode * 59 + this.BalanceSlots.GetHashCode();
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
                if (this.Lon != null)
                    hashCode = hashCode * 59 + this.Lon.GetHashCode();
                if (this.Accuracy != null)
                    hashCode = hashCode * 59 + this.Accuracy.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressDetails != null)
                    hashCode = hashCode * 59 + this.AddressDetails.GetHashCode();
                if (this.Aged != null)
                    hashCode = hashCode * 59 + this.Aged.GetHashCode();
                if (this.Fallback != null)
                    hashCode = hashCode * 59 + this.Fallback.GetHashCode();
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
