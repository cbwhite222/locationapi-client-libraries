#import <Foundation/Foundation.h>
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



@interface OAIBALANCEApi: NSObject <OAIApi>

extern NSString* kOAIBALANCEApiErrorDomain;
extern NSInteger kOAIBALANCEApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(OAIApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// balance
/// The Balance API provides a count of request credits left in the user's account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
///
/// 
///  code:200 message:"OK"
///
/// @return NSObject*
-(NSURLSessionTask*) balanceWithCompletionHandler: 
    (void (^)(NSObject* output, NSError* error)) handler;



@end
