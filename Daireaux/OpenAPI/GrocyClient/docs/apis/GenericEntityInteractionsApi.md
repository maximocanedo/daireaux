# Org.OpenAPITools.Api.GenericEntityInteractionsApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ObjectsEntityGet**](GenericEntityInteractionsApi.md#objectsentityget) | **GET** /objects/{entity} | Returns all objects of the given entity |
| [**ObjectsEntityObjectIdDelete**](GenericEntityInteractionsApi.md#objectsentityobjectiddelete) | **DELETE** /objects/{entity}/{objectId} | Deletes a single object of the given entity |
| [**ObjectsEntityObjectIdGet**](GenericEntityInteractionsApi.md#objectsentityobjectidget) | **GET** /objects/{entity}/{objectId} | Returns a single object of the given entity |
| [**ObjectsEntityObjectIdPut**](GenericEntityInteractionsApi.md#objectsentityobjectidput) | **PUT** /objects/{entity}/{objectId} | Edits the given object of the given entity |
| [**ObjectsEntityPost**](GenericEntityInteractionsApi.md#objectsentitypost) | **POST** /objects/{entity} | Adds a single object of the given entity |
| [**UserfieldsEntityObjectIdGet**](GenericEntityInteractionsApi.md#userfieldsentityobjectidget) | **GET** /userfields/{entity}/{objectId} | Returns all userfields with their values of the given object of the given entity |
| [**UserfieldsEntityObjectIdPut**](GenericEntityInteractionsApi.md#userfieldsentityobjectidput) | **PUT** /userfields/{entity}/{objectId} | Edits the given userfields of the given object of the given entity |

<a id="objectsentityget"></a>
# **ObjectsEntityGet**
> List&lt;ObjectsEntityGet200ResponseInner&gt; ObjectsEntityGet (ExposedEntityNotIncludingNotListable entity, List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all objects of the given entity


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | [**ExposedEntityNotIncludingNotListable**](ExposedEntityNotIncludingNotListable.md) | A valid entity name |  |
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;ObjectsEntityGet200ResponseInner&gt;**](ObjectsEntityGet200ResponseInner.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An entity object |  -  |
| **400** | The operation was not successful |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="objectsentityobjectiddelete"></a>
# **ObjectsEntityObjectIdDelete**
> void ObjectsEntityObjectIdDelete (ExposedEntityNotIncludingNotDeletable entity, int objectId)

Deletes a single object of the given entity


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | [**ExposedEntityNotIncludingNotDeletable**](ExposedEntityNotIncludingNotDeletable.md) | A valid entity name |  |
| **objectId** | **int** | A valid object id of the given entity |  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The operation was successful |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="objectsentityobjectidget"></a>
# **ObjectsEntityObjectIdGet**
> ObjectsEntityGet200ResponseInner ObjectsEntityObjectIdGet (ExposedEntityNotIncludingNotListable entity, int objectId)

Returns a single object of the given entity


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | [**ExposedEntityNotIncludingNotListable**](ExposedEntityNotIncludingNotListable.md) | A valid entity name |  |
| **objectId** | **int** | A valid object id of the given entity |  |

### Return type

[**ObjectsEntityGet200ResponseInner**](ObjectsEntityGet200ResponseInner.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An entity object |  -  |
| **400** | The operation was not successful |  -  |
| **404** | Object not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="objectsentityobjectidput"></a>
# **ObjectsEntityObjectIdPut**
> void ObjectsEntityObjectIdPut (ExposedEntityNotIncludingNotEditable entity, int objectId, ObjectsEntityGet200ResponseInner objectsEntityGet200ResponseInner)

Edits the given object of the given entity


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | [**ExposedEntityNotIncludingNotEditable**](ExposedEntityNotIncludingNotEditable.md) | A valid entity name |  |
| **objectId** | **int** | A valid object id of the given entity |  |
| **objectsEntityGet200ResponseInner** | [**ObjectsEntityGet200ResponseInner**](ObjectsEntityGet200ResponseInner.md) | A valid entity object of the entity specified in parameter *entity* |  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The operation was successful |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="objectsentitypost"></a>
# **ObjectsEntityPost**
> ObjectsEntityPost200Response ObjectsEntityPost (ExposedEntityNotIncludingNotEditable entity, ObjectsEntityGet200ResponseInner objectsEntityGet200ResponseInner)

Adds a single object of the given entity


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | [**ExposedEntityNotIncludingNotEditable**](ExposedEntityNotIncludingNotEditable.md) | A valid entity name |  |
| **objectsEntityGet200ResponseInner** | [**ObjectsEntityGet200ResponseInner**](ObjectsEntityGet200ResponseInner.md) | A valid entity object of the entity specified in parameter *entity* |  |

### Return type

[**ObjectsEntityPost200Response**](ObjectsEntityPost200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="userfieldsentityobjectidget"></a>
# **UserfieldsEntityObjectIdGet**
> Object UserfieldsEntityObjectIdGet (ExposedEntityIncludingUserEntities entity, string objectId)

Returns all userfields with their values of the given object of the given entity


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | [**ExposedEntityIncludingUserEntities**](ExposedEntityIncludingUserEntities.md) | A valid entity name |  |
| **objectId** | **string** | A valid object id of the given entity |  |

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Key/value pairs of userfields |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="userfieldsentityobjectidput"></a>
# **UserfieldsEntityObjectIdPut**
> void UserfieldsEntityObjectIdPut (ExposedEntityIncludingUserEntitiesNotIncludingNotEditable entity, string objectId, Object body)

Edits the given userfields of the given object of the given entity


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | [**ExposedEntityIncludingUserEntitiesNotIncludingNotEditable**](ExposedEntityIncludingUserEntitiesNotIncludingNotEditable.md) | A valid entity name |  |
| **objectId** | **string** | A valid object id of the given entity |  |
| **body** | **Object** | A valid entity object of the entity specified in parameter *entity* |  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The operation was successful |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

