# ACRON REST API
The ACRON REST API is a programming interface that exposes a subset of ACRON functions to third-party applications.  
Details on configuration and usage can be found in the API developer documentation or the ACRON users guide included in your ACRON install.

## Demo Client

The Demo Client is provided as is, both as an example of how to access the Acron Rest API as well as providing a robust set of classes and methods for easy automation and extension.

## Overview

This repository aims to provide a starting point for developers working on a client application utilizing the ACRON REST API.

It contains four projects:
- **Acron.RestApi.Client** which implements a comprehensive client and a robust set of extendable Methods for specific API calls as well as error handling and deserialisation of the responses.
- **Acron.RestApi.FrontEnd** which implements an example Graphical User Interface in which a subset of commands can be tested and the results visualized.
- **Acron.RestApi.DataContracts** which contains all objects which are either serialized or deserialized when sending or receiving data to/from the ACRON REST API.
- **Acron.RestApi.Interfaces** which provides interfaces that may be implemented when creating the objects in **Acron.RestApi.DataContracts** yourself.

## Getting Started

All Methods created in the Graphical User Interface and the Programmatic Examples are created based on the Demo Plant and require the API to be started and correctly set up using the Acron Admin Tool
This sections concerns itself with how to get started using the provided **Acron.RestApi.Client**

1. **Initialise a client**  
    The Constructor of a RestClient takes several arguments:
	
	| Required | Name | Type | Description |
	|------------|-----------|-----------|-----------------------------|
	| **required** | *pRestClientName* | **string** | Defines the name of the instantiated client. |
	| **required** | *pHostName* | **string** | Sets the host-name of the target API for the client. |
	| **required** | *pPort* | **uint** | Sets the port of the target API for the client. |
	| **required** | *pVersion* | **float** | Sets the API version the client is targetting. |
	| **required** | *accessTokenLoginResource* | **AccessTokenLoginResource** | Contains the application level login data AppName and **Password**.
	| **required** | *userTokenLoginResource* | **UserTokenLoginResource** |Contains the user level login data Username: **AcronUser**, Password: **Password**, UserClientName: **ClientName**, User HostName or IP-Address: **HostOrIP**, Outgoing Port: **Port** and Self-defined **SessionId** |
	| **optional** | *pKeepAlive* | **bool** | Sets whether the client should automatically refresh its authorization tokens. Default value is true. |
		
	At time of creation the client fetches initial Authorisation tokens based on the provided **AccessTokenLoginResource** and **UserTokenLoginResource**
	
2. **Create a Request**  
	Each Request requires passing in a RestClient in the constructor.  
	Once created the specific request class has access to predefined Methods, that call API functions using the correct method and parameters.  
	As an example we create a **ConfigurationGeneralRequest**.
	
3. **Working with a Request**  
	The instantiated **ConfigurationGeneralRequest** has several defined Methods, some of which require Ressource Objects to be provided as parameters and some that don't.  
	Each method returns a 4-element tuple consisting of a boolean flag HasError, an ErrorText string, a generic ResponseClass as well as the specific Result.
    The ResponseClass can be pattern matched with the different Responses such **AcOkResponse** or **AcBadRequestResponse** among others.  
	The Result of each Method is specific.
	
	Using the *HasAccess()* method on an unused Plant will return a **AcOkResponse** with the **ApiActionResult** Property set to *ConfigAccessNobody* and a Result object with the boolean property *accessByMe* set to false.
	
	Trying to use *ReleaseAccess()* at this point will return a **AcBadRequestResponse** with the **ApiActionResult** Property set to *ConfigAccessResetIamNotOwner*, a HTTP Status Code of 400 and a Result of null.
	
	Using the *CreateAccess()* method on an unused Plant will return a **AcOkResponse** with the **ApiActionResult** Property set to *Ok* and a Result object with the boolean property *accessByMe* set to true.
	
	To use a method with an input parameter such as *ObjectInfo(ObjectInfoRequestResource objectInfoRequestResource)* it is necessary to create a new instance of that class.  
	In this case the Resource only requires a single Property which is the **BaseObjectID** which has to be set to the ID of the object that should be queried.  
	The passed instance is converted to a json string and used as the body of a HTTP Post method.  
	
## Further Reading

The required Resources and Headers, as well as the detailed return types for all API requests can be found in the internal Swagger documentation of the API under  
[Static Documentation](https://api.dataforum.de/)
