<?php
/**
 * FallbackSchema
 *
 * PHP version 5
 *
 * @category Class
 * @package  unwired
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Location API
 *
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 3.3.4
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace unwired\Model;

use \ArrayAccess;
use \unwired\ObjectSerializer;

/**
 * FallbackSchema Class Doc Comment
 *
 * @category Class
 * @description An array of fallback options to enable or disable.
 * @package  unwired
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class FallbackSchema implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'fallback_schema';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'all' => '\unwired\Model\AllSchema',
        'ipf' => '\unwired\Model\IpfSchema',
        'lacf' => '\unwired\Model\LacfSchema',
        'scf' => '\unwired\Model\ScfSchema'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPIFormats = [
        'all' => null,
        'ipf' => null,
        'lacf' => null,
        'scf' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'all' => 'all',
        'ipf' => 'ipf',
        'lacf' => 'lacf',
        'scf' => 'scf'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'all' => 'setAll',
        'ipf' => 'setIpf',
        'lacf' => 'setLacf',
        'scf' => 'setScf'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'all' => 'getAll',
        'ipf' => 'getIpf',
        'lacf' => 'getLacf',
        'scf' => 'getScf'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }

    

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['all'] = isset($data['all']) ? $data['all'] : null;
        $this->container['ipf'] = isset($data['ipf']) ? $data['ipf'] : null;
        $this->container['lacf'] = isset($data['lacf']) ? $data['lacf'] : null;
        $this->container['scf'] = isset($data['scf']) ? $data['scf'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets all
     *
     * @return \unwired\Model\AllSchema|null
     */
    public function getAll()
    {
        return $this->container['all'];
    }

    /**
     * Sets all
     *
     * @param \unwired\Model\AllSchema|null $all all
     *
     * @return $this
     */
    public function setAll($all)
    {
        $this->container['all'] = $all;

        return $this;
    }

    /**
     * Gets ipf
     *
     * @return \unwired\Model\IpfSchema|null
     */
    public function getIpf()
    {
        return $this->container['ipf'];
    }

    /**
     * Sets ipf
     *
     * @param \unwired\Model\IpfSchema|null $ipf ipf
     *
     * @return $this
     */
    public function setIpf($ipf)
    {
        $this->container['ipf'] = $ipf;

        return $this;
    }

    /**
     * Gets lacf
     *
     * @return \unwired\Model\LacfSchema|null
     */
    public function getLacf()
    {
        return $this->container['lacf'];
    }

    /**
     * Sets lacf
     *
     * @param \unwired\Model\LacfSchema|null $lacf lacf
     *
     * @return $this
     */
    public function setLacf($lacf)
    {
        $this->container['lacf'] = $lacf;

        return $this;
    }

    /**
     * Gets scf
     *
     * @return \unwired\Model\ScfSchema|null
     */
    public function getScf()
    {
        return $this->container['scf'];
    }

    /**
     * Sets scf
     *
     * @param \unwired\Model\ScfSchema|null $scf scf
     *
     * @return $this
     */
    public function setScf($scf)
    {
        $this->container['scf'] = $scf;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }
}


