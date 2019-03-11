# Location API
#
# Geolocation, Geocoding and Maps
#
# OpenAPI spec version: 2.0.0
# 
# Generated by: https://openapi-generator.tech


#' AllSchema Class
#'
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
AllSchema <- R6::R6Class(
  'AllSchema',
  public = list(
    initialize = function(){
    },
    toJSON = function() {
      AllSchemaObject <- list()

      AllSchemaObject
    },
    fromJSON = function(AllSchemaJson) {
      AllSchemaObject <- jsonlite::fromJSON(AllSchemaJson)
    },
    toJSONString = function() {
       sprintf(
        '{
        }',
      )
    },
    fromJSONString = function(AllSchemaJson) {
      AllSchemaObject <- jsonlite::fromJSON(AllSchemaJson)
    }
  )
)
