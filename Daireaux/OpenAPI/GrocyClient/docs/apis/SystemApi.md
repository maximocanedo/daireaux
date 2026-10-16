# Org.OpenAPITools.Api.SystemApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SystemConfigGet**](SystemApi.md#systemconfigget) | **GET** /system/config | Returns all config settings |
| [**SystemDbChangedTimeGet**](SystemApi.md#systemdbchangedtimeget) | **GET** /system/db-changed-time | Returns the time when the database was last changed |
| [**SystemInfoGet**](SystemApi.md#systeminfoget) | **GET** /system/info | Returns information about the installed Grocy version, PHP runtime and OS |
| [**SystemLocalizationStringsGet**](SystemApi.md#systemlocalizationstringsget) | **GET** /system/localization-strings | Returns all localization strings (in the by the user desired language) |
| [**SystemLogMissingLocalizationPost**](SystemApi.md#systemlogmissinglocalizationpost) | **POST** /system/log-missing-localization | Logs a missing localization string |
| [**SystemTimeGet**](SystemApi.md#systemtimeget) | **GET** /system/time | Returns the current server time |

<a id="systemconfigget"></a>
# **SystemConfigGet**
> Object SystemConfigGet ()

Returns all config settings


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
| **200** | Key/value pairs of config settings |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="systemdbchangedtimeget"></a>
# **SystemDbChangedTimeGet**
> DbChangedTimeResponse SystemDbChangedTimeGet ()

Returns the time when the database was last changed


### Parameters
This endpoint does not need any parameter.
### Return type

[**DbChangedTimeResponse**](DbChangedTimeResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An DbChangedTimeResponse object |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="systeminfoget"></a>
# **SystemInfoGet**
> SystemInfoGet200Response SystemInfoGet ()

Returns information about the installed Grocy version, PHP runtime and OS


### Parameters
This endpoint does not need any parameter.
### Return type

[**SystemInfoGet200Response**](SystemInfoGet200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An DbChangedTimeResponse object |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="systemlocalizationstringsget"></a>
# **SystemLocalizationStringsGet**
> Object SystemLocalizationStringsGet ()

Returns all localization strings (in the by the user desired language)


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
| **200** | The operation was successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="systemlogmissinglocalizationpost"></a>
# **SystemLogMissingLocalizationPost**
> void SystemLogMissingLocalizationPost (MissingLocalizationRequest missingLocalizationRequest)

Logs a missing localization string

Only when MODE == 'dev', so should only be called then


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **missingLocalizationRequest** | [**MissingLocalizationRequest**](MissingLocalizationRequest.md) | A valid MissingLocalizationRequest object |  |

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

<a id="systemtimeget"></a>
# **SystemTimeGet**
> TimeResponse SystemTimeGet (int offset = null)

Returns the current server time


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Offset of timestamp in seconds. Can be positive or negative. | [optional]  |

### Return type

[**TimeResponse**](TimeResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A TimeResponse object |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

