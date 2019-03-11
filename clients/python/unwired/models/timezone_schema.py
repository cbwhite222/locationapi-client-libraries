# coding: utf-8

"""
    Location API

    Geolocation, Geocoding and Maps  # noqa: E501

    OpenAPI spec version: 2.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six


class TimezoneSchema(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'short_name': 'str',
        'offset_sec': 'float',
        'now_in_dst': 'str',
        'name': 'str'
    }

    attribute_map = {
        'short_name': 'short_name',
        'offset_sec': 'offset_sec',
        'now_in_dst': 'now_in_dst',
        'name': 'name'
    }

    def __init__(self, short_name=None, offset_sec=None, now_in_dst=None, name=None):  # noqa: E501
        """TimezoneSchema - a model defined in OpenAPI"""  # noqa: E501

        self._short_name = None
        self._offset_sec = None
        self._now_in_dst = None
        self._name = None
        self.discriminator = None

        if short_name is not None:
            self.short_name = short_name
        if offset_sec is not None:
            self.offset_sec = offset_sec
        if now_in_dst is not None:
            self.now_in_dst = now_in_dst
        if name is not None:
            self.name = name

    @property
    def short_name(self):
        """Gets the short_name of this TimezoneSchema.  # noqa: E501

        Short name of the Timezone  # noqa: E501

        :return: The short_name of this TimezoneSchema.  # noqa: E501
        :rtype: str
        """
        return self._short_name

    @short_name.setter
    def short_name(self, short_name):
        """Sets the short_name of this TimezoneSchema.

        Short name of the Timezone  # noqa: E501

        :param short_name: The short_name of this TimezoneSchema.  # noqa: E501
        :type: str
        """

        self._short_name = short_name

    @property
    def offset_sec(self):
        """Gets the offset_sec of this TimezoneSchema.  # noqa: E501

        The offset from UTC (in seconds) for the given location. Considers DST savings.  # noqa: E501

        :return: The offset_sec of this TimezoneSchema.  # noqa: E501
        :rtype: float
        """
        return self._offset_sec

    @offset_sec.setter
    def offset_sec(self, offset_sec):
        """Sets the offset_sec of this TimezoneSchema.

        The offset from UTC (in seconds) for the given location. Considers DST savings.  # noqa: E501

        :param offset_sec: The offset_sec of this TimezoneSchema.  # noqa: E501
        :type: float
        """

        self._offset_sec = offset_sec

    @property
    def now_in_dst(self):
        """Gets the now_in_dst of this TimezoneSchema.  # noqa: E501

        Represents whether the zone currently observing DST or not  # noqa: E501

        :return: The now_in_dst of this TimezoneSchema.  # noqa: E501
        :rtype: str
        """
        return self._now_in_dst

    @now_in_dst.setter
    def now_in_dst(self, now_in_dst):
        """Sets the now_in_dst of this TimezoneSchema.

        Represents whether the zone currently observing DST or not  # noqa: E501

        :param now_in_dst: The now_in_dst of this TimezoneSchema.  # noqa: E501
        :type: str
        """

        self._now_in_dst = now_in_dst

    @property
    def name(self):
        """Gets the name of this TimezoneSchema.  # noqa: E501

        Timezone name of the Location  # noqa: E501

        :return: The name of this TimezoneSchema.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this TimezoneSchema.

        Timezone name of the Location  # noqa: E501

        :param name: The name of this TimezoneSchema.  # noqa: E501
        :type: str
        """

        self._name = name

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, TimezoneSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
