#import <Foundation/Foundation.h>
#import "OAIGeolocationSchema.h"
#import "OAIApi.h"

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



@interface OAIGEOLOCATIONApi: NSObject <OAIApi>

extern NSString* kOAIGEOLOCATIONApiErrorDomain;
extern NSInteger kOAIGEOLOCATIONApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(OAIApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// Geolocation
/// The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
///
/// @param geolocationSchema 
/// 
///  code:200 message:"OK"
///
/// @return NSObject*
-(NSURLSessionTask*) geolocationWithGeolocationSchema: (OAIGeolocationSchema*) geolocationSchema
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;



@end