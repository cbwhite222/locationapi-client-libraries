# Location API
#
# Geolocation, Geocoding and Maps
#
# OpenAPI spec version: 2.0.0
# 
# Generated by: https://openapi-generator.tech


#' WifiSchema Class
#'
#' @field bssid 
#' @field channel 
#' @field frequency 
#' @field signal 
#' @field signalToNoiseRatio 
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
WifiSchema <- R6::R6Class(
  'WifiSchema',
  public = list(
    `bssid` = NULL,
    `channel` = NULL,
    `frequency` = NULL,
    `signal` = NULL,
    `signalToNoiseRatio` = NULL,
    initialize = function(`bssid`, `channel`, `frequency`, `signal`, `signalToNoiseRatio`){
      if (!missing(`bssid`)) {
        stopifnot(is.character(`bssid`), length(`bssid`) == 1)
        self$`bssid` <- `bssid`
      }
      if (!missing(`channel`)) {
        stopifnot(is.numeric(`channel`), length(`channel`) == 1)
        self$`channel` <- `channel`
      }
      if (!missing(`frequency`)) {
        stopifnot(is.numeric(`frequency`), length(`frequency`) == 1)
        self$`frequency` <- `frequency`
      }
      if (!missing(`signal`)) {
        stopifnot(is.numeric(`signal`), length(`signal`) == 1)
        self$`signal` <- `signal`
      }
      if (!missing(`signalToNoiseRatio`)) {
        stopifnot(is.numeric(`signalToNoiseRatio`), length(`signalToNoiseRatio`) == 1)
        self$`signalToNoiseRatio` <- `signalToNoiseRatio`
      }
    },
    toJSON = function() {
      WifiSchemaObject <- list()
      if (!is.null(self$`bssid`)) {
        WifiSchemaObject[['bssid']] <- self$`bssid`
      }
      if (!is.null(self$`channel`)) {
        WifiSchemaObject[['channel']] <- self$`channel`
      }
      if (!is.null(self$`frequency`)) {
        WifiSchemaObject[['frequency']] <- self$`frequency`
      }
      if (!is.null(self$`signal`)) {
        WifiSchemaObject[['signal']] <- self$`signal`
      }
      if (!is.null(self$`signalToNoiseRatio`)) {
        WifiSchemaObject[['signalToNoiseRatio']] <- self$`signalToNoiseRatio`
      }

      WifiSchemaObject
    },
    fromJSON = function(WifiSchemaJson) {
      WifiSchemaObject <- jsonlite::fromJSON(WifiSchemaJson)
      if (!is.null(WifiSchemaObject$`bssid`)) {
        self$`bssid` <- WifiSchemaObject$`bssid`
      }
      if (!is.null(WifiSchemaObject$`channel`)) {
        self$`channel` <- WifiSchemaObject$`channel`
      }
      if (!is.null(WifiSchemaObject$`frequency`)) {
        self$`frequency` <- WifiSchemaObject$`frequency`
      }
      if (!is.null(WifiSchemaObject$`signal`)) {
        self$`signal` <- WifiSchemaObject$`signal`
      }
      if (!is.null(WifiSchemaObject$`signalToNoiseRatio`)) {
        self$`signalToNoiseRatio` <- WifiSchemaObject$`signalToNoiseRatio`
      }
    },
    toJSONString = function() {
       sprintf(
        '{
           "bssid": %s,
           "channel": %d,
           "frequency": %d,
           "signal": %d,
           "signalToNoiseRatio": %d
        }',
        self$`bssid`,
        self$`channel`,
        self$`frequency`,
        self$`signal`,
        self$`signalToNoiseRatio`
      )
    },
    fromJSONString = function(WifiSchemaJson) {
      WifiSchemaObject <- jsonlite::fromJSON(WifiSchemaJson)
      self$`bssid` <- WifiSchemaObject$`bssid`
      self$`channel` <- WifiSchemaObject$`channel`
      self$`frequency` <- WifiSchemaObject$`frequency`
      self$`signal` <- WifiSchemaObject$`signal`
      self$`signalToNoiseRatio` <- WifiSchemaObject$`signalToNoiseRatio`
    }
  )
)
