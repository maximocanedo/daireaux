# Org.OpenAPITools.Api.UserManagementApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersGet**](UserManagementApi.md#usersget) | **GET** /users | Returns all users |
| [**UsersPost**](UserManagementApi.md#userspost) | **POST** /users | Creates a new user |
| [**UsersUserIdDelete**](UserManagementApi.md#usersuseriddelete) | **DELETE** /users/{userId} | Deletes the given user |
| [**UsersUserIdPermissionsGet**](UserManagementApi.md#usersuseridpermissionsget) | **GET** /users/{userId}/permissions | Returns the assigned permissions of the given user |
| [**UsersUserIdPermissionsPost**](UserManagementApi.md#usersuseridpermissionspost) | **POST** /users/{userId}/permissions | Adds a permission to the given user |
| [**UsersUserIdPermissionsPut**](UserManagementApi.md#usersuseridpermissionsput) | **PUT** /users/{userId}/permissions | Replaces the assigned permissions of the given user |
| [**UsersUserIdPut**](UserManagementApi.md#usersuseridput) | **PUT** /users/{userId} | Edits the given user |

<a id="usersget"></a>
# **UsersGet**
> List&lt;UserDto&gt; UsersGet (List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all users


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;UserDto&gt;**](UserDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of user objects |  -  |
| **400** | The operation was not successful |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="userspost"></a>
# **UsersPost**
> void UsersPost (User user)

Creates a new user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **user** | [**User**](User.md) | A valid user object |  |

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

<a id="usersuseriddelete"></a>
# **UsersUserIdDelete**
> void UsersUserIdDelete (int userId)

Deletes the given user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | A valid user id |  |

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

<a id="usersuseridpermissionsget"></a>
# **UsersUserIdPermissionsGet**
> List&lt;UsersUserIdPermissionsGet200ResponseInner&gt; UsersUserIdPermissionsGet (int userId)

Returns the assigned permissions of the given user

See \"GET /objects/permission_hierarchy\" for a permission name / id mapping


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | A valid user id |  |

### Return type

[**List&lt;UsersUserIdPermissionsGet200ResponseInner&gt;**](UsersUserIdPermissionsGet200ResponseInner.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of user permission objects |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersuseridpermissionspost"></a>
# **UsersUserIdPermissionsPost**
> void UsersUserIdPermissionsPost (int userId, UsersUserIdPermissionsPostRequest usersUserIdPermissionsPostRequest)

Adds a permission to the given user

See \"GET /objects/permission_hierarchy\" for a permission name / id mapping


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | A valid user id |  |
| **usersUserIdPermissionsPostRequest** | [**UsersUserIdPermissionsPostRequest**](UsersUserIdPermissionsPostRequest.md) |  |  |

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

<a id="usersuseridpermissionsput"></a>
# **UsersUserIdPermissionsPut**
> void UsersUserIdPermissionsPut (int userId, UsersUserIdPermissionsPutRequest usersUserIdPermissionsPutRequest)

Replaces the assigned permissions of the given user

See \"GET /objects/permission_hierarchy\" for a permission name / id mapping


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | A valid user id |  |
| **usersUserIdPermissionsPutRequest** | [**UsersUserIdPermissionsPutRequest**](UsersUserIdPermissionsPutRequest.md) |  |  |

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

<a id="usersuseridput"></a>
# **UsersUserIdPut**
> void UsersUserIdPut (int userId, User user)

Edits the given user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | A valid user id |  |
| **user** | [**User**](User.md) | A valid user object |  |

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

