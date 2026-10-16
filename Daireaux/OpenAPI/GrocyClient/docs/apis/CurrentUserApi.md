# Org.OpenAPITools.Api.CurrentUserApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserGet**](CurrentUserApi.md#userget) | **GET** /user | Returns the currently authenticated user |
| [**UserSettingsGet**](CurrentUserApi.md#usersettingsget) | **GET** /user/settings | Returns all settings of the currently logged in user |
| [**UserSettingsSettingKeyDelete**](CurrentUserApi.md#usersettingssettingkeydelete) | **DELETE** /user/settings/{settingKey} | Deletes the given setting of the currently logged in user |
| [**UserSettingsSettingKeyGet**](CurrentUserApi.md#usersettingssettingkeyget) | **GET** /user/settings/{settingKey} | Returns the given setting of the currently logged in user |
| [**UserSettingsSettingKeyPut**](CurrentUserApi.md#usersettingssettingkeyput) | **PUT** /user/settings/{settingKey} | Sets the given setting of the currently logged in user |

<a id="userget"></a>
# **UserGet**
> Object UserGet ()

Returns the currently authenticated user


### Parameters
This endpoint does not need any parameter.
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
| **200** | A user object |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersettingsget"></a>
# **UserSettingsGet**
> Object UserSettingsGet ()

Returns all settings of the currently logged in user


### Parameters
This endpoint does not need any parameter.
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
| **200** | Key/value pairs of user settings |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersettingssettingkeydelete"></a>
# **UserSettingsSettingKeyDelete**
> void UserSettingsSettingKeyDelete (string settingKey)

Deletes the given setting of the currently logged in user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingKey** | **string** | The key of the user setting |  |

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

<a id="usersettingssettingkeyget"></a>
# **UserSettingsSettingKeyGet**
> UserSetting UserSettingsSettingKeyGet (string settingKey)

Returns the given setting of the currently logged in user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingKey** | **string** | The key of the user setting |  |

### Return type

[**UserSetting**](UserSetting.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A UserSetting object |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usersettingssettingkeyput"></a>
# **UserSettingsSettingKeyPut**
> void UserSettingsSettingKeyPut (string settingKey, UserSetting userSetting)

Sets the given setting of the currently logged in user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingKey** | **string** | The key of the user setting |  |
| **userSetting** | [**UserSetting**](UserSetting.md) | A valid UserSetting object |  |

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

