=begin comment

Location API

Geolocation, Geocoding and Maps

OpenAPI spec version: 2.0.0

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# Do not edit the class manually.
# Ref: https://openapi-generator.tech
#
package WWW::OpenAPIClient::Object::CellSchema;

require 5.6.0;
use strict;
use warnings;
use utf8;
use JSON qw(decode_json);
use Data::Dumper;
use Module::Runtime qw(use_module);
use Log::Any qw($log);
use Date::Parse;
use DateTime;

use WWW::OpenAPIClient::Object::RadioSchema;

use base ("Class::Accessor", "Class::Data::Inheritable");


#
#You can send 1 to 7 cell ID objects. If your device supports scanning for more than 7 cell objects, reach out to us and we’ll increase this limit on your account. The first cell object has to be that of the serving cell, i.e. the tower the device is connected to. The others are neighbouring cell objects that are visible to the device. Except lac and cid all other parameters mentioned below are optional. Parameters vary depending on the radio type. Supported radio types and their corresponding parameters are
#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech). Do not edit the class manually.
# REF: https://openapi-generator.tech
#

=begin comment

Location API

Geolocation, Geocoding and Maps

OpenAPI spec version: 2.0.0

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# Do not edit the class manually.
# Ref: https://openapi-generator.tech
#
__PACKAGE__->mk_classdata('attribute_map' => {});
__PACKAGE__->mk_classdata('openapi_types' => {});
__PACKAGE__->mk_classdata('method_documentation' => {}); 
__PACKAGE__->mk_classdata('class_documentation' => {});

# new object
sub new { 
    my ($class, %args) = @_; 

	my $self = bless {}, $class;
	
	foreach my $attribute (keys %{$class->attribute_map}) {
		my $args_key = $class->attribute_map->{$attribute};
		$self->$attribute( $args{ $args_key } );
	}
	
	return $self;
}  

# return perl hash
sub to_hash {
    return decode_json(JSON->new->convert_blessed->encode( shift ));
}

# used by JSON for serialization
sub TO_JSON { 
    my $self = shift;
    my $_data = {};
    foreach my $_key (keys %{$self->attribute_map}) {
        if (defined $self->{$_key}) {
            $_data->{$self->attribute_map->{$_key}} = $self->{$_key};
        }
    }
    return $_data;
}

# from Perl hashref
sub from_hash {
    my ($self, $hash) = @_;

    # loop through attributes and use openapi_types to deserialize the data
    while ( my ($_key, $_type) = each %{$self->openapi_types} ) {
    	my $_json_attribute = $self->attribute_map->{$_key}; 
        if ($_type =~ /^array\[/i) { # array
            my $_subclass = substr($_type, 6, -1);
            my @_array = ();
            foreach my $_element (@{$hash->{$_json_attribute}}) {
                push @_array, $self->_deserialize($_subclass, $_element);
            }
            $self->{$_key} = \@_array;
        } elsif (exists $hash->{$_json_attribute}) { #hash(model), primitive, datetime
            $self->{$_key} = $self->_deserialize($_type, $hash->{$_json_attribute});
        } else {
        	$log->debugf("Warning: %s (%s) does not exist in input hash\n", $_key, $_json_attribute);
        }
    }
  
    return $self;
}

# deserialize non-array data
sub _deserialize {
    my ($self, $type, $data) = @_;
    $log->debugf("deserializing %s with %s",Dumper($data), $type);
        
    if ($type eq 'DateTime') {
        return DateTime->from_epoch(epoch => str2time($data));
    } elsif ( grep( /^$type$/, ('int', 'double', 'string', 'boolean'))) {
        return $data;
    } else { # hash(model)
        my $_instance = eval "WWW::OpenAPIClient::Object::$type->new()";
        return $_instance->from_hash($data);
    }
}



__PACKAGE__->class_documentation({description => 'You can send 1 to 7 cell ID objects. If your device supports scanning for more than 7 cell objects, reach out to us and we’ll increase this limit on your account. The first cell object has to be that of the serving cell, i.e. the tower the device is connected to. The others are neighbouring cell objects that are visible to the device. Except lac and cid all other parameters mentioned below are optional. Parameters vary depending on the radio type. Supported radio types and their corresponding parameters are',
                                  class => 'CellSchema',
                                  required => [], # TODO
}                                 );

__PACKAGE__->method_documentation({
    'lac' => {
    	datatype => 'int',
    	base_name => 'lac',
    	description => 'the Location Area Code of your operator’s network.',
    	format => '',
    	read_only => '',
    		},
    'cid' => {
    	datatype => 'int',
    	base_name => 'cid',
    	description => 'Cell ID',
    	format => '',
    	read_only => '',
    		},
    'radio' => {
    	datatype => 'RadioSchema',
    	base_name => 'radio',
    	description => '',
    	format => '',
    	read_only => '',
    		},
    'mcc' => {
    	datatype => 'int',
    	base_name => 'mcc',
    	description => '\&quot;Mobile Country Code of your operator’s network represented by an integer (Optional). Range: 0 to 999.\&quot;',
    	format => '',
    	read_only => '',
    		},
    'mnc' => {
    	datatype => 'int',
    	base_name => 'mnc',
    	description => 'Mobile Network Code of your operator’s network represented by an integer (Optional). Range: 0 to 999. On CDMA, provide the System ID or SID, with range: 1 to 32767.',
    	format => '',
    	read_only => '',
    		},
    'signal' => {
    	datatype => 'int',
    	base_name => 'signal',
    	description => 'Signal Strength (RSSI)',
    	format => '',
    	read_only => '',
    		},
    'psc' => {
    	datatype => 'int',
    	base_name => 'psc',
    	description => 'Primary Scrambling Code',
    	format => '',
    	read_only => '',
    		},
    'asu' => {
    	datatype => 'int',
    	base_name => 'asu',
    	description => 'Arbitrary Strength Unit',
    	format => '',
    	read_only => '',
    		},
    'ta' => {
    	datatype => 'int',
    	base_name => 'ta',
    	description => 'Timing Advance',
    	format => '',
    	read_only => '',
    		},
});

__PACKAGE__->openapi_types( {
    'lac' => 'int',
    'cid' => 'int',
    'radio' => 'RadioSchema',
    'mcc' => 'int',
    'mnc' => 'int',
    'signal' => 'int',
    'psc' => 'int',
    'asu' => 'int',
    'ta' => 'int'
} );

__PACKAGE__->attribute_map( {
    'lac' => 'lac',
    'cid' => 'cid',
    'radio' => 'radio',
    'mcc' => 'mcc',
    'mnc' => 'mnc',
    'signal' => 'signal',
    'psc' => 'psc',
    'asu' => 'asu',
    'ta' => 'ta'
} );

__PACKAGE__->mk_accessors(keys %{__PACKAGE__->attribute_map});


1;
