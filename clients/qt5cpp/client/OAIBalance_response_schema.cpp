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


#include "OAIBalance_response_schema.h"

#include "OAIHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace OpenAPI {

OAIBalance_response_schema::OAIBalance_response_schema(QString json) {
    init();
    this->fromJson(json);
}

OAIBalance_response_schema::OAIBalance_response_schema() {
    init();
}

OAIBalance_response_schema::~OAIBalance_response_schema() {
    this->cleanup();
}

void
OAIBalance_response_schema::init() {
    status = new QString("");
    m_status_isSet = false;
    balance_geolocation = 0L;
    m_balance_geolocation_isSet = false;
    balance_geocoding = 0L;
    m_balance_geocoding_isSet = false;
}

void
OAIBalance_response_schema::cleanup() {
    if(status != nullptr) { 
        delete status;
    }


}

OAIBalance_response_schema*
OAIBalance_response_schema::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
OAIBalance_response_schema::fromJsonObject(QJsonObject pJson) {
    ::OpenAPI::setValue(&status, pJson["status"], "QString", "QString");
    
    ::OpenAPI::setValue(&balance_geolocation, pJson["balance_geolocation"], "qint64", "");
    
    ::OpenAPI::setValue(&balance_geocoding, pJson["balance_geocoding"], "qint64", "");
    
}

QString
OAIBalance_response_schema::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
OAIBalance_response_schema::asJsonObject() {
    QJsonObject obj;
    if(status != nullptr && *status != QString("")){
        toJsonValue(QString("status"), status, obj, QString("QString"));
    }
    if(m_balance_geolocation_isSet){
        obj.insert("balance_geolocation", QJsonValue(balance_geolocation));
    }
    if(m_balance_geocoding_isSet){
        obj.insert("balance_geocoding", QJsonValue(balance_geocoding));
    }

    return obj;
}

QString*
OAIBalance_response_schema::getStatus() {
    return status;
}
void
OAIBalance_response_schema::setStatus(QString* status) {
    this->status = status;
    this->m_status_isSet = true;
}

qint64
OAIBalance_response_schema::getBalanceGeolocation() {
    return balance_geolocation;
}
void
OAIBalance_response_schema::setBalanceGeolocation(qint64 balance_geolocation) {
    this->balance_geolocation = balance_geolocation;
    this->m_balance_geolocation_isSet = true;
}

qint64
OAIBalance_response_schema::getBalanceGeocoding() {
    return balance_geocoding;
}
void
OAIBalance_response_schema::setBalanceGeocoding(qint64 balance_geocoding) {
    this->balance_geocoding = balance_geocoding;
    this->m_balance_geocoding_isSet = true;
}


bool
OAIBalance_response_schema::isSet(){
    bool isObjectUpdated = false;
    do{
        if(status != nullptr && *status != QString("")){ isObjectUpdated = true; break;}
        if(m_balance_geolocation_isSet){ isObjectUpdated = true; break;}
        if(m_balance_geocoding_isSet){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}
}

