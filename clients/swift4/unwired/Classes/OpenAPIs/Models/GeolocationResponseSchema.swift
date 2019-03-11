//
// GeolocationResponseSchema.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation


/** The response will be a JSON object. */

public struct GeolocationResponseSchema: Codable {

    /** If the request is successful, ok is returned. Otherwise error is returned */
    public var status: String?
    /** Any additional information from the server is returned here */
    public var message: String?
    /** This represents the remaining balance on the API token. Requests that return error are not charged and do not affect balance */
    public var balance: Int64?
    /** This represents the remaining balance of device slots. Requests that return error are not charged and do not affect balance. If -1 is returned, then observe it as an error while calculating slots balance. This element will only exist if you are on a device plan. */
    public var balanceSlots: Int64?
    /** The latitude representing the location */
    public var lat: Double?
    /** The longitude representing the location */
    public var lon: Double?
    /** The accuracy of the position is returned in meters */
    public var accuracy: Int64?
    /** The physical address of the location */
    public var address: String?
    public var addressDetails: AddressDetailsSchema?
    /** Shown when the location is based on a single measurement or those older than 90 days or is an LAC fallback */
    public var aged: Int?
    public var fallback: FallbackSchema?

    public init(status: String?, message: String?, balance: Int64?, balanceSlots: Int64?, lat: Double?, lon: Double?, accuracy: Int64?, address: String?, addressDetails: AddressDetailsSchema?, aged: Int?, fallback: FallbackSchema?) {
        self.status = status
        self.message = message
        self.balance = balance
        self.balanceSlots = balanceSlots
        self.lat = lat
        self.lon = lon
        self.accuracy = accuracy
        self.address = address
        self.addressDetails = addressDetails
        self.aged = aged
        self.fallback = fallback
    }

    public enum CodingKeys: String, CodingKey { 
        case status
        case message
        case balance
        case balanceSlots = "balance_slots"
        case lat
        case lon
        case accuracy
        case address
        case addressDetails = "address_details"
        case aged
        case fallback
    }


}

