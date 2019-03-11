/* 
 * Location API
 *
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

/// RadioSchema : Radio type of the device. Supported values are ‘gsm’, ‘cdma’, ‘umts’ and ‘lte’. This field should be included for more accurate results.

#[allow(unused_imports)]
use serde_json::Value;

#[derive(Debug, Serialize, Deserialize)]
pub struct RadioSchema {
}

impl RadioSchema {
  /// Radio type of the device. Supported values are ‘gsm’, ‘cdma’, ‘umts’ and ‘lte’. This field should be included for more accurate results.
  pub fn new() -> RadioSchema {
    RadioSchema {
    }
  }

}

// TODO enum 
// List of radio_schema
//const (
//  
//  
//  
//)


