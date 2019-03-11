=begin
#Location API

#Geolocation, Geocoding and Maps

OpenAPI spec version: 2.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 3.3.4

=end

require 'spec_helper'
require 'json'

# Unit tests for unwiredClient::GEOLOCATIONApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'GEOLOCATIONApi' do
  before do
    # run before each test
    @instance = unwiredClient::GEOLOCATIONApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of GEOLOCATIONApi' do
    it 'should create an instance of GEOLOCATIONApi' do
      expect(@instance).to be_instance_of(unwiredClient::GEOLOCATIONApi)
    end
  end

  # unit tests for geolocation
  # Geolocation
  # The Geolocation API helps developers locate IoT, M2M and other connected devices anywhere in the world without GPS. The device first sends the API data about which Cellular networks and WiFi networks it can see nearby. The API then uses Unwired Labs’ large datasets of Cell towers, WiFi networks backed by numerous algorithms to calculate and return the device’s location
  # @param geolocation_schema 
  # @param [Hash] opts the optional parameters
  # @return [Object]
  describe 'geolocation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
