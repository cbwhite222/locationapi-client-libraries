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
    /// Address object found for the search query
    /// </summary>
    [DataContract]
    public partial class AddressSchema :  IEquatable<AddressSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressSchema" /> class.
        /// </summary>
        /// <param name="lat">Latitude of the given location (decimal).</param>
        /// <param name="lon">Longitude of the given location (decimal).</param>
        /// <param name="displayName">Matched Address name for the given location.</param>
        /// <param name="houseNumber">House Number.</param>
        /// <param name="road">Road Name.</param>
        /// <param name="neighborhood">Neighbourhood.</param>
        /// <param name="suburb">Suburb.</param>
        /// <param name="city">City name (normalized form of city, town, village, hamlet).</param>
        /// <param name="county">County name (normalized form of county, state_district).</param>
        /// <param name="country">Country name.</param>
        /// <param name="countryCode">Country code.</param>
        /// <param name="postalCode">Postal code.</param>
        public AddressSchema(string lat = default(string), string lon = default(string), string displayName = default(string), string houseNumber = default(string), string road = default(string), string neighborhood = default(string), string suburb = default(string), string city = default(string), string county = default(string), string country = default(string), string countryCode = default(string), string postalCode = default(string))
        {
            this.Lat = lat;
            this.Lon = lon;
            this.DisplayName = displayName;
            this.HouseNumber = houseNumber;
            this.Road = road;
            this.Neighborhood = neighborhood;
            this.Suburb = suburb;
            this.City = city;
            this.County = county;
            this.Country = country;
            this.CountryCode = countryCode;
            this.PostalCode = postalCode;
        }
        
        /// <summary>
        /// Latitude of the given location (decimal)
        /// </summary>
        /// <value>Latitude of the given location (decimal)</value>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        public string Lat { get; set; }

        /// <summary>
        /// Longitude of the given location (decimal)
        /// </summary>
        /// <value>Longitude of the given location (decimal)</value>
        [DataMember(Name="lon", EmitDefaultValue=false)]
        public string Lon { get; set; }

        /// <summary>
        /// Matched Address name for the given location
        /// </summary>
        /// <value>Matched Address name for the given location</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// House Number
        /// </summary>
        /// <value>House Number</value>
        [DataMember(Name="house_number", EmitDefaultValue=false)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Road Name
        /// </summary>
        /// <value>Road Name</value>
        [DataMember(Name="road", EmitDefaultValue=false)]
        public string Road { get; set; }

        /// <summary>
        /// Neighbourhood
        /// </summary>
        /// <value>Neighbourhood</value>
        [DataMember(Name="neighborhood", EmitDefaultValue=false)]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Suburb
        /// </summary>
        /// <value>Suburb</value>
        [DataMember(Name="suburb", EmitDefaultValue=false)]
        public string Suburb { get; set; }

        /// <summary>
        /// City name (normalized form of city, town, village, hamlet)
        /// </summary>
        /// <value>City name (normalized form of city, town, village, hamlet)</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// County name (normalized form of county, state_district)
        /// </summary>
        /// <value>County name (normalized form of county, state_district)</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressSchema {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  Road: ").Append(Road).Append("\n");
            sb.Append("  Neighborhood: ").Append(Neighborhood).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as AddressSchema);
        }

        /// <summary>
        /// Returns true if AddressSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressSchema input)
        {
            if (input == null)
                return false;

            return 
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.HouseNumber == input.HouseNumber ||
                    (this.HouseNumber != null &&
                    this.HouseNumber.Equals(input.HouseNumber))
                ) && 
                (
                    this.Road == input.Road ||
                    (this.Road != null &&
                    this.Road.Equals(input.Road))
                ) && 
                (
                    this.Neighborhood == input.Neighborhood ||
                    (this.Neighborhood != null &&
                    this.Neighborhood.Equals(input.Neighborhood))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
                if (this.Lon != null)
                    hashCode = hashCode * 59 + this.Lon.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.HouseNumber != null)
                    hashCode = hashCode * 59 + this.HouseNumber.GetHashCode();
                if (this.Road != null)
                    hashCode = hashCode * 59 + this.Road.GetHashCode();
                if (this.Neighborhood != null)
                    hashCode = hashCode * 59 + this.Neighborhood.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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
