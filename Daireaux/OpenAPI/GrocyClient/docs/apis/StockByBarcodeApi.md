# Org.OpenAPITools.Api.StockByBarcodeApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StockProductsByBarcodeBarcodeAddPost**](StockByBarcodeApi.md#stockproductsbybarcodebarcodeaddpost) | **POST** /stock/products/by-barcode/{barcode}/add | Adds the given amount of the by its barcode given product to stock |
| [**StockProductsByBarcodeBarcodeConsumePost**](StockByBarcodeApi.md#stockproductsbybarcodebarcodeconsumepost) | **POST** /stock/products/by-barcode/{barcode}/consume | Removes the given amount of the by its barcode given product from stock |
| [**StockProductsByBarcodeBarcodeGet**](StockByBarcodeApi.md#stockproductsbybarcodebarcodeget) | **GET** /stock/products/by-barcode/{barcode} | Returns details of the given product by its barcode |
| [**StockProductsByBarcodeBarcodeInventoryPost**](StockByBarcodeApi.md#stockproductsbybarcodebarcodeinventorypost) | **POST** /stock/products/by-barcode/{barcode}/inventory | Inventories the by its barcode given product (adds/removes based on the given new amount) |
| [**StockProductsByBarcodeBarcodeOpenPost**](StockByBarcodeApi.md#stockproductsbybarcodebarcodeopenpost) | **POST** /stock/products/by-barcode/{barcode}/open | Marks the given amount of the by its barcode given product as opened |
| [**StockProductsByBarcodeBarcodeTransferPost**](StockByBarcodeApi.md#stockproductsbybarcodebarcodetransferpost) | **POST** /stock/products/by-barcode/{barcode}/transfer | Transfers the given amount of the by its barcode given product from one location to another (this is currently not supported for tare weight handling enabled products) |

<a id="stockproductsbybarcodebarcodeaddpost"></a>
# **StockProductsByBarcodeBarcodeAddPost**
> List&lt;StockLogEntry&gt; StockProductsByBarcodeBarcodeAddPost (string barcode, StockProductsByBarcodeBarcodeAddPostRequest stockProductsByBarcodeBarcodeAddPostRequest)

Adds the given amount of the by its barcode given product to stock


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | Barcode |  |
| **stockProductsByBarcodeBarcodeAddPostRequest** | [**StockProductsByBarcodeBarcodeAddPostRequest**](StockProductsByBarcodeBarcodeAddPostRequest.md) |  |  |

### Return type

[**List&lt;StockLogEntry&gt;**](StockLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product, invalid transaction type) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsbybarcodebarcodeconsumepost"></a>
# **StockProductsByBarcodeBarcodeConsumePost**
> List&lt;StockLogEntry&gt; StockProductsByBarcodeBarcodeConsumePost (string barcode, StockProductsProductIdConsumePostRequest stockProductsProductIdConsumePostRequest)

Removes the given amount of the by its barcode given product from stock


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | Barcode |  |
| **stockProductsProductIdConsumePostRequest** | [**StockProductsProductIdConsumePostRequest**](StockProductsProductIdConsumePostRequest.md) |  |  |

### Return type

[**List&lt;StockLogEntry&gt;**](StockLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product, invalid transaction type, given amount &gt; current stock amount) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsbybarcodebarcodeget"></a>
# **StockProductsByBarcodeBarcodeGet**
> ProductDetailsResponse StockProductsByBarcodeBarcodeGet (string barcode)

Returns details of the given product by its barcode


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | Barcode |  |

### Return type

[**ProductDetailsResponse**](ProductDetailsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A ProductDetailsResponse object |  -  |
| **400** | The operation was not successful (possible errors are: Unknown barcode) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsbybarcodebarcodeinventorypost"></a>
# **StockProductsByBarcodeBarcodeInventoryPost**
> List&lt;StockLogEntry&gt; StockProductsByBarcodeBarcodeInventoryPost (string barcode, StockProductsByBarcodeBarcodeInventoryPostRequest stockProductsByBarcodeBarcodeInventoryPostRequest)

Inventories the by its barcode given product (adds/removes based on the given new amount)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | Barcode |  |
| **stockProductsByBarcodeBarcodeInventoryPostRequest** | [**StockProductsByBarcodeBarcodeInventoryPostRequest**](StockProductsByBarcodeBarcodeInventoryPostRequest.md) |  |  |

### Return type

[**List&lt;StockLogEntry&gt;**](StockLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsbybarcodebarcodeopenpost"></a>
# **StockProductsByBarcodeBarcodeOpenPost**
> List&lt;StockLogEntry&gt; StockProductsByBarcodeBarcodeOpenPost (string barcode, StockProductsProductIdOpenPostRequest stockProductsProductIdOpenPostRequest)

Marks the given amount of the by its barcode given product as opened


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | Barcode |  |
| **stockProductsProductIdOpenPostRequest** | [**StockProductsProductIdOpenPostRequest**](StockProductsProductIdOpenPostRequest.md) |  |  |

### Return type

[**List&lt;StockLogEntry&gt;**](StockLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product, given amount &gt; current unopened stock amount) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsbybarcodebarcodetransferpost"></a>
# **StockProductsByBarcodeBarcodeTransferPost**
> List&lt;StockLogEntry&gt; StockProductsByBarcodeBarcodeTransferPost (string barcode, StockProductsProductIdTransferPostRequest stockProductsProductIdTransferPostRequest)

Transfers the given amount of the by its barcode given product from one location to another (this is currently not supported for tare weight handling enabled products)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | Barcode |  |
| **stockProductsProductIdTransferPostRequest** | [**StockProductsProductIdTransferPostRequest**](StockProductsProductIdTransferPostRequest.md) |  |  |

### Return type

[**List&lt;StockLogEntry&gt;**](StockLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product, no existing from or to location, given amount &gt; current stock amount at the source location) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

