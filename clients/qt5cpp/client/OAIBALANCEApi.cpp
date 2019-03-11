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

#include "OAIBALANCEApi.h"
#include "OAIHelpers.h"
#include "OAIModelFactory.h"
#include "OAIQObjectWrapper.h"

#include <QJsonArray>
#include <QJsonDocument>

namespace OpenAPI {

OAIBALANCEApi::OAIBALANCEApi() {}

OAIBALANCEApi::~OAIBALANCEApi() {}

OAIBALANCEApi::OAIBALANCEApi(QString host, QString basePath) {
    this->host = host;
    this->basePath = basePath;
}

void
OAIBALANCEApi::balance() {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/balance.php");



    OAIHttpRequestWorker *worker = new OAIHttpRequestWorker();
    OAIHttpRequestInput input(fullPath, "GET");





    foreach(QString key, this->defaultHeaders.keys()) {
        input.headers.insert(key, this->defaultHeaders.value(key));
    }

    connect(worker,
            &OAIHttpRequestWorker::on_execution_finished,
            this,
            &OAIBALANCEApi::balanceCallback);

    worker->execute(&input);
}

void
OAIBALANCEApi::balanceCallback(OAIHttpRequestWorker * worker) {
    QString msg;
    QString error_str = worker->error_str;
    QNetworkReply::NetworkError error_type = worker->error_type;

    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    QString json(worker->response);
    OAIObject* output = static_cast<OAIObject*>(create(json, QString("OAIObject")));
    auto wrapper = new OAIQObjectWrapper<OAIObject*> (output);
    wrapper->deleteLater();
    worker->deleteLater();

    if (worker->error_type == QNetworkReply::NoError) {
        emit balanceSignal(output);
    } else {
        emit balanceSignalE(output, error_type, error_str);
        emit balanceSignalEFull(worker, error_type, error_str);
    }
}


}
