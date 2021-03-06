# locationapi-client-libraries
This repository contains LocationAPI definition written in OpenAPI (v3) and the client libraries generated using (openapi generator)[https://openapi-generator.tech/] and samples.

## Client libraries generated for:

language  |  tested?| 
:---------|:--------|
clojure   |  no     |
csharp    |  no     |
dart      |  no     |
go        |  no     |
haskell   |  no     |
java      |  yes    | 
kotlin	  |  no     |
objc      |  no     |
perl      |  no     |
php       |  yes    |
python    |  yes    |
qt5cpp    |  no     |
r         |  no     |
ruby      |  no     |
rust      |  no     |
scala     |  no     |
swift4    |  no     |

## Supported APIs

Currently the following APIs are supported

 * Geolocation API 
 * Geocoding API 
 * Timezone API
 * Balance API


 ## Specification file:
The `ul_api_spec_openapi3_v2_0_0` contains the specifiation of LocationAPI. It is written in OpenAPI 3.0.


 ## Generate libraries:
The script `generate.sh` is compiled with necessary options to help build a client library for LocationAPI.
* To generate client libraires for all the [listed](#client-libraries-generated-for:) languages: `./generate.sh`
* To generate a single client library for any particular language: `./generate.sh <language>`

    




