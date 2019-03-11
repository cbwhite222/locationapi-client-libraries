/**
* Location API
* Geolocation, Geocoding and Maps
*
* OpenAPI spec version: 2.0.0
* 
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/
package unwired.models


import com.squareup.moshi.Json

/**
* The physical address of the returned location
* Values: _0,_1,_2
*/
enum class GeolocationAddressSchema(val value: kotlin.Long){

    @Json(name = "0") _0(0),

    @Json(name = "1") _1(1),

    @Json(name = "2") _2(2);

}

