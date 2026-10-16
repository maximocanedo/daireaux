# Org.OpenAPITools.Api.BatteriesApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatteriesBatteryIdChargePost**](BatteriesApi.md#batteriesbatteryidchargepost) | **POST** /batteries/{batteryId}/charge | Tracks a charge cycle of the given battery |
| [**BatteriesBatteryIdGet**](BatteriesApi.md#batteriesbatteryidget) | **GET** /batteries/{batteryId} | Returns details of the given battery |
| [**BatteriesBatteryIdPrintlabelGet**](BatteriesApi.md#batteriesbatteryidprintlabelget) | **GET** /batteries/{batteryId}/printlabel | Prints the Grocycode label of the given battery on the configured label printer |
| [**BatteriesChargeCyclesChargeCycleIdUndoPost**](BatteriesApi.md#batterieschargecycleschargecycleidundopost) | **POST** /batteries/charge-cycles/{chargeCycleId}/undo | Undoes a battery charge cycle |
| [**BatteriesGet**](BatteriesApi.md#batteriesget) | **GET** /batteries | Returns all batteries incl. the next estimated charge time per battery |

<a id="batteriesbatteryidchargepost"></a>
# **BatteriesBatteryIdChargePost**
> BatteryChargeCycleEntry BatteriesBatteryIdChargePost (int batteryId, BatteriesBatteryIdChargePostRequest batteriesBatteryIdChargePostRequest)

Tracks a charge cycle of the given battery


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batteryId** | **int** | A valid battery id |  |
| **batteriesBatteryIdChargePostRequest** | [**BatteriesBatteryIdChargePostRequest**](BatteriesBatteryIdChargePostRequest.md) |  |  |

### Return type

[**BatteryChargeCycleEntry**](BatteryChargeCycleEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Not existing battery) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="batteriesbatteryidget"></a>
# **BatteriesBatteryIdGet**
> BatteryDetailsResponse BatteriesBatteryIdGet (int batteryId)

Returns details of the given battery


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batteryId** | **int** | A valid battery id |  |

### Return type

[**BatteryDetailsResponse**](BatteryDetailsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A BatteryDetailsResponse object |  -  |
| **400** | The operation was not successful (possible errors are: Not existing battery) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="batteriesbatteryidprintlabelget"></a>
# **BatteriesBatteryIdPrintlabelGet**
> Object BatteriesBatteryIdPrintlabelGet (int batteryId)

Prints the Grocycode label of the given battery on the configured label printer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batteryId** | **int** | A valid battery id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing battery, error on WebHook execution) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="batterieschargecycleschargecycleidundopost"></a>
# **BatteriesChargeCyclesChargeCycleIdUndoPost**
> void BatteriesChargeCyclesChargeCycleIdUndoPost (int chargeCycleId)

Undoes a battery charge cycle


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chargeCycleId** | **int** | A valid charge cycle id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing booking) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="batteriesget"></a>
# **BatteriesGet**
> List&lt;CurrentBatteryResponse&gt; BatteriesGet (List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all batteries incl. the next estimated charge time per battery


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;CurrentBatteryResponse&gt;**](CurrentBatteryResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of CurrentBatteryResponse objects |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

