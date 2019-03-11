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


#include "OAIError_schema.h"

#include "OAIHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace OpenAPI {

OAIError_schema::OAIError_schema(QString json) {
    init();
    this->fromJson(json);
}

OAIError_schema::OAIError_schema() {
    init();
}

OAIError_schema::~OAIError_schema() {
    this->cleanup();
}

void
OAIError_schema::init() {
    status = new QString("");
    m_status_isSet = false;
    message = new QString("");
    m_message_isSet = false;
}

void
OAIError_schema::cleanup() {
    if(status != nullptr) { 
        delete status;
    }
    if(message != nullptr) { 
        delete message;
    }
}

OAIError_schema*
OAIError_schema::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
OAIError_schema::fromJsonObject(QJsonObject pJson) {
    ::OpenAPI::setValue(&status, pJson["status"], "QString", "QString");
    
    ::OpenAPI::setValue(&message, pJson["message"], "QString", "QString");
    
}

QString
OAIError_schema::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
OAIError_schema::asJsonObject() {
    QJsonObject obj;
    if(status != nullptr && *status != QString("")){
        toJsonValue(QString("status"), status, obj, QString("QString"));
    }
    if(message != nullptr && *message != QString("")){
        toJsonValue(QString("message"), message, obj, QString("QString"));
    }

    return obj;
}

QString*
OAIError_schema::getStatus() {
    return status;
}
void
OAIError_schema::setStatus(QString* status) {
    this->status = status;
    this->m_status_isSet = true;
}

QString*
OAIError_schema::getMessage() {
    return message;
}
void
OAIError_schema::setMessage(QString* message) {
    this->message = message;
    this->m_message_isSet = true;
}


bool
OAIError_schema::isSet(){
    bool isObjectUpdated = false;
    do{
        if(status != nullptr && *status != QString("")){ isObjectUpdated = true; break;}
        if(message != nullptr && *message != QString("")){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}
}

