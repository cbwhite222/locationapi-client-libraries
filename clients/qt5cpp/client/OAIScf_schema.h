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

/*
 * OAIScf_schema.h
 *
 * Enable Short CID fallback. Adds support for devices that can only see 16-bit (short) CID of an UMTS 28-bit UTRAN CID.
 */

#ifndef OAIScf_schema_H_
#define OAIScf_schema_H_

#include <QJsonObject>



#include "OAIObject.h"

namespace OpenAPI {

class OAIScf_schema: public OAIObject {
public:
    OAIScf_schema();
    OAIScf_schema(QString json);
    ~OAIScf_schema();
    void init();
    void cleanup();

    QString asJson () override;
    QJsonObject asJsonObject() override;
    void fromJsonObject(QJsonObject json) override;
    OAIScf_schema* fromJson(QString jsonString) override;


    virtual bool isSet() override;

private:
};

}

#endif /* OAIScf_schema_H_ */
