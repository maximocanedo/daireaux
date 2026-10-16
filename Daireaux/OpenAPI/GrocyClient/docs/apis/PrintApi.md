# Org.OpenAPITools.Api.PrintApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PrintShoppinglistThermalGet**](PrintApi.md#printshoppinglistthermalget) | **GET** /print/shoppinglist/thermal | Prints the shoppinglist with a thermal printer |

<a id="printshoppinglistthermalget"></a>
# **PrintShoppinglistThermalGet**
> PrintShoppinglistThermalGet200Response PrintShoppinglistThermalGet (int list = null, bool printHeader = null)

Prints the shoppinglist with a thermal printer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **list** | **int** | Shopping list id | [optional] [default to 1] |
| **printHeader** | **bool** | Prints Grocy logo if true | [optional] [default to true] |

### Return type

[**PrintShoppinglistThermalGet200Response**](PrintShoppinglistThermalGet200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns OK if the printing was successful |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

