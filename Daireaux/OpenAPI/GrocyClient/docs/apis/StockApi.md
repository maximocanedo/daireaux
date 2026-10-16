# Org.OpenAPITools.Api.StockApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StockBarcodesExternalLookupBarcodeGet**](StockApi.md#stockbarcodesexternallookupbarcodeget) | **GET** /stock/barcodes/external-lookup/{barcode} | Executes an external barcode lookoup via the configured plugin with the given barcode |
| [**StockBookingsBookingIdGet**](StockApi.md#stockbookingsbookingidget) | **GET** /stock/bookings/{bookingId} | Returns the given stock booking |
| [**StockBookingsBookingIdUndoPost**](StockApi.md#stockbookingsbookingidundopost) | **POST** /stock/bookings/{bookingId}/undo | Undoes a booking |
| [**StockEntryEntryIdGet**](StockApi.md#stockentryentryidget) | **GET** /stock/entry/{entryId} | Returns details of the given stock |
| [**StockEntryEntryIdPrintlabelGet**](StockApi.md#stockentryentryidprintlabelget) | **GET** /stock/entry/{entryId}/printlabel | Prints the Grocycode / stock entry label of the given entry on the configured label printer |
| [**StockEntryEntryIdPut**](StockApi.md#stockentryentryidput) | **PUT** /stock/entry/{entryId} | Edits the stock entry |
| [**StockGet**](StockApi.md#stockget) | **GET** /stock | Returns all products which are currently in stock incl. the next due date per product |
| [**StockLocationsLocationIdEntriesGet**](StockApi.md#stocklocationslocationidentriesget) | **GET** /stock/locations/{locationId}/entries | Returns all stock entries of the given location |
| [**StockProductsProductIdAddPost**](StockApi.md#stockproductsproductidaddpost) | **POST** /stock/products/{productId}/add | Adds the given amount of the given product to stock |
| [**StockProductsProductIdConsumePost**](StockApi.md#stockproductsproductidconsumepost) | **POST** /stock/products/{productId}/consume | Removes the given amount of the given product from stock |
| [**StockProductsProductIdCopyPost**](StockApi.md#stockproductsproductidcopypost) | **POST** /stock/products/{productId}/copy | Copies a product |
| [**StockProductsProductIdEntriesGet**](StockApi.md#stockproductsproductidentriesget) | **GET** /stock/products/{productId}/entries | Returns all stock entries of the given product in order of next use (Opened first, then first due first, then first in first out) |
| [**StockProductsProductIdGet**](StockApi.md#stockproductsproductidget) | **GET** /stock/products/{productId} | Returns details of the given product |
| [**StockProductsProductIdInventoryPost**](StockApi.md#stockproductsproductidinventorypost) | **POST** /stock/products/{productId}/inventory | Inventories the given product (adds/removes based on the given new amount) |
| [**StockProductsProductIdLocationsGet**](StockApi.md#stockproductsproductidlocationsget) | **GET** /stock/products/{productId}/locations | Returns all locations where the given product currently has stock |
| [**StockProductsProductIdOpenPost**](StockApi.md#stockproductsproductidopenpost) | **POST** /stock/products/{productId}/open | Marks the given amount of the given product as opened |
| [**StockProductsProductIdPriceHistoryGet**](StockApi.md#stockproductsproductidpricehistoryget) | **GET** /stock/products/{productId}/price-history | Returns the price history of the given product |
| [**StockProductsProductIdPrintlabelGet**](StockApi.md#stockproductsproductidprintlabelget) | **GET** /stock/products/{productId}/printlabel | Prints the Grocycode label of the given product on the configured label printer |
| [**StockProductsProductIdToKeepMergeProductIdToRemovePost**](StockApi.md#stockproductsproductidtokeepmergeproductidtoremovepost) | **POST** /stock/products/{productIdToKeep}/merge/{productIdToRemove} | Merges two products into one |
| [**StockProductsProductIdTransferPost**](StockApi.md#stockproductsproductidtransferpost) | **POST** /stock/products/{productId}/transfer | Transfers the given amount of the given product from one location to another (this is currently not supported for tare weight handling enabled products) |
| [**StockShoppinglistAddExpiredProductsPost**](StockApi.md#stockshoppinglistaddexpiredproductspost) | **POST** /stock/shoppinglist/add-expired-products | Adds expired products to the given shopping list |
| [**StockShoppinglistAddMissingProductsPost**](StockApi.md#stockshoppinglistaddmissingproductspost) | **POST** /stock/shoppinglist/add-missing-products | Adds currently missing products (below defined min. stock amount) to the given shopping list |
| [**StockShoppinglistAddOverdueProductsPost**](StockApi.md#stockshoppinglistaddoverdueproductspost) | **POST** /stock/shoppinglist/add-overdue-products | Adds overdue products to the given shopping list |
| [**StockShoppinglistAddProductPost**](StockApi.md#stockshoppinglistaddproductpost) | **POST** /stock/shoppinglist/add-product | Adds the given amount of the given product to the given shopping list |
| [**StockShoppinglistClearPost**](StockApi.md#stockshoppinglistclearpost) | **POST** /stock/shoppinglist/clear | Removes all items from the given shopping list |
| [**StockShoppinglistRemoveProductPost**](StockApi.md#stockshoppinglistremoveproductpost) | **POST** /stock/shoppinglist/remove-product | Removes the given amount of the given product from the given shopping list, if it is on it |
| [**StockTransactionsTransactionIdGet**](StockApi.md#stocktransactionstransactionidget) | **GET** /stock/transactions/{transactionId} | Returns all stock bookings of the given transaction id |
| [**StockTransactionsTransactionIdUndoPost**](StockApi.md#stocktransactionstransactionidundopost) | **POST** /stock/transactions/{transactionId}/undo | Undoes a transaction |
| [**StockVolatileGet**](StockApi.md#stockvolatileget) | **GET** /stock/volatile | Returns all products which are due soon, overdue, expired or currently missing |

<a id="stockbarcodesexternallookupbarcodeget"></a>
# **StockBarcodesExternalLookupBarcodeGet**
> ExternalBarcodeLookupResponse StockBarcodesExternalLookupBarcodeGet (string barcode, bool add = null)

Executes an external barcode lookoup via the configured plugin with the given barcode


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | The barcode to lookup up |  |
| **add** | **bool** | When true, the product is added to the database on a successful lookup and the new product id is in included in the response | [optional] [default to false] |

### Return type

[**ExternalBarcodeLookupResponse**](ExternalBarcodeLookupResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An ExternalBarcodeLookupResponse object or null, when nothing was found for the given barcode |  -  |
| **400** | The operation was not successful (possible errors are: Plugin error) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockbookingsbookingidget"></a>
# **StockBookingsBookingIdGet**
> StockLogEntry StockBookingsBookingIdGet (int bookingId)

Returns the given stock booking


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bookingId** | **int** | A valid stock booking id |  |

### Return type

[**StockLogEntry**](StockLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A StockLogEntry object |  -  |
| **400** | The operation was not successful (possible errors are: Invalid stock booking id) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockbookingsbookingidundopost"></a>
# **StockBookingsBookingIdUndoPost**
> void StockBookingsBookingIdUndoPost (int bookingId)

Undoes a booking


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bookingId** | **int** | A valid stock booking id |  |

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

<a id="stockentryentryidget"></a>
# **StockEntryEntryIdGet**
> StockEntry StockEntryEntryIdGet (int entryId)

Returns details of the given stock


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entryId** | **int** | A valid stock entry id |  |

### Return type

[**StockEntry**](StockEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A StockEntry Response object |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockentryentryidprintlabelget"></a>
# **StockEntryEntryIdPrintlabelGet**
> Object StockEntryEntryIdPrintlabelGet (int entryId)

Prints the Grocycode / stock entry label of the given entry on the configured label printer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entryId** | **int** | A valid stock entry id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing stock entry, error on WebHook execution) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockentryentryidput"></a>
# **StockEntryEntryIdPut**
> List&lt;StockLogEntry&gt; StockEntryEntryIdPut (int entryId, StockEntryEntryIdPutRequest stockEntryEntryIdPutRequest)

Edits the stock entry


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entryId** | **int** | A valid stock entry id |  |
| **stockEntryEntryIdPutRequest** | [**StockEntryEntryIdPutRequest**](StockEntryEntryIdPutRequest.md) |  |  |

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

<a id="stockget"></a>
# **StockGet**
> List&lt;CurrentStockResponse&gt; StockGet ()

Returns all products which are currently in stock incl. the next due date per product


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;CurrentStockResponse&gt;**](CurrentStockResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of CurrentStockResponse objects |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stocklocationslocationidentriesget"></a>
# **StockLocationsLocationIdEntriesGet**
> List&lt;StockEntry&gt; StockLocationsLocationIdEntriesGet (int locationId, List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all stock entries of the given location


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | A valid location id |  |
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;StockEntry&gt;**](StockEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of StockEntry objects |  -  |
| **400** | The operation was not successful (possible errors are: Not existing location) |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidaddpost"></a>
# **StockProductsProductIdAddPost**
> List&lt;StockLogEntry&gt; StockProductsProductIdAddPost (int productId, StockProductsProductIdAddPostRequest stockProductsProductIdAddPostRequest)

Adds the given amount of the given product to stock


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |
| **stockProductsProductIdAddPostRequest** | [**StockProductsProductIdAddPostRequest**](StockProductsProductIdAddPostRequest.md) |  |  |

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

<a id="stockproductsproductidconsumepost"></a>
# **StockProductsProductIdConsumePost**
> List&lt;StockLogEntry&gt; StockProductsProductIdConsumePost (int productId, StockProductsProductIdConsumePostRequest stockProductsProductIdConsumePostRequest)

Removes the given amount of the given product from stock


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |
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

<a id="stockproductsproductidcopypost"></a>
# **StockProductsProductIdCopyPost**
> StockProductsProductIdCopyPost200Response StockProductsProductIdCopyPost (int productId)

Copies a product


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id of the product to copy |  |

### Return type

[**StockProductsProductIdCopyPost200Response**](StockProductsProductIdCopyPost200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Invalid product id) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidentriesget"></a>
# **StockProductsProductIdEntriesGet**
> List&lt;StockEntry&gt; StockProductsProductIdEntriesGet (int productId, bool includeSubProducts = null, List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all stock entries of the given product in order of next use (Opened first, then first due first, then first in first out)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |
| **includeSubProducts** | **bool** | If sub products should be included (if the given product is a parent product and in addition to the ones of the given product) | [optional]  |
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;StockEntry&gt;**](StockEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of StockEntry objects |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product) |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidget"></a>
# **StockProductsProductIdGet**
> ProductDetailsResponse StockProductsProductIdGet (int productId)

Returns details of the given product


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing product) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidinventorypost"></a>
# **StockProductsProductIdInventoryPost**
> List&lt;StockLogEntry&gt; StockProductsProductIdInventoryPost (int productId, StockProductsProductIdInventoryPostRequest stockProductsProductIdInventoryPostRequest)

Inventories the given product (adds/removes based on the given new amount)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |
| **stockProductsProductIdInventoryPostRequest** | [**StockProductsProductIdInventoryPostRequest**](StockProductsProductIdInventoryPostRequest.md) |  |  |

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

<a id="stockproductsproductidlocationsget"></a>
# **StockProductsProductIdLocationsGet**
> List&lt;StockLocation&gt; StockProductsProductIdLocationsGet (int productId, bool includeSubProducts = null, List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all locations where the given product currently has stock


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |
| **includeSubProducts** | **bool** | If sub product locations should be included (if the given product is a parent product and in addition to the ones of the given product) | [optional]  |
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;StockLocation&gt;**](StockLocation.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of StockLocation objects |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product) |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidopenpost"></a>
# **StockProductsProductIdOpenPost**
> List&lt;StockLogEntry&gt; StockProductsProductIdOpenPost (int productId, StockProductsProductIdOpenPostRequest stockProductsProductIdOpenPostRequest)

Marks the given amount of the given product as opened


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |
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

<a id="stockproductsproductidpricehistoryget"></a>
# **StockProductsProductIdPriceHistoryGet**
> List&lt;ProductPriceHistory&gt; StockProductsProductIdPriceHistoryGet (int productId)

Returns the price history of the given product


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |

### Return type

[**List&lt;ProductPriceHistory&gt;**](ProductPriceHistory.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of ProductPriceHistory objects |  -  |
| **400** | The operation was not successful (possible errors are: Not existing product) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidprintlabelget"></a>
# **StockProductsProductIdPrintlabelGet**
> Object StockProductsProductIdPrintlabelGet (int productId)

Prints the Grocycode label of the given product on the configured label printer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing product, error on WebHook execution) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidtokeepmergeproductidtoremovepost"></a>
# **StockProductsProductIdToKeepMergeProductIdToRemovePost**
> void StockProductsProductIdToKeepMergeProductIdToRemovePost (int productIdToKeep, int productIdToRemove)

Merges two products into one


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productIdToKeep** | **int** | A valid product id of the product to keep |  |
| **productIdToRemove** | **int** | A valid product id of the product to remove |  |

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
| **400** | The operation was not successful (possible errors are: Invalid product id) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockproductsproductidtransferpost"></a>
# **StockProductsProductIdTransferPost**
> List&lt;StockLogEntry&gt; StockProductsProductIdTransferPost (int productId, StockProductsProductIdTransferPostRequest stockProductsProductIdTransferPostRequest)

Transfers the given amount of the given product from one location to another (this is currently not supported for tare weight handling enabled products)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **int** | A valid product id |  |
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

<a id="stockshoppinglistaddexpiredproductspost"></a>
# **StockShoppinglistAddExpiredProductsPost**
> void StockShoppinglistAddExpiredProductsPost (StockShoppinglistAddMissingProductsPostRequest stockShoppinglistAddMissingProductsPostRequest = null)

Adds expired products to the given shopping list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stockShoppinglistAddMissingProductsPostRequest** | [**StockShoppinglistAddMissingProductsPostRequest**](StockShoppinglistAddMissingProductsPostRequest.md) |  | [optional]  |

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
| **400** | The operation was not successful (possible errors are: Not existing shopping list) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockshoppinglistaddmissingproductspost"></a>
# **StockShoppinglistAddMissingProductsPost**
> void StockShoppinglistAddMissingProductsPost (StockShoppinglistAddMissingProductsPostRequest stockShoppinglistAddMissingProductsPostRequest = null)

Adds currently missing products (below defined min. stock amount) to the given shopping list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stockShoppinglistAddMissingProductsPostRequest** | [**StockShoppinglistAddMissingProductsPostRequest**](StockShoppinglistAddMissingProductsPostRequest.md) |  | [optional]  |

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
| **400** | The operation was not successful (possible errors are: Not existing shopping list) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockshoppinglistaddoverdueproductspost"></a>
# **StockShoppinglistAddOverdueProductsPost**
> void StockShoppinglistAddOverdueProductsPost (StockShoppinglistAddMissingProductsPostRequest stockShoppinglistAddMissingProductsPostRequest = null)

Adds overdue products to the given shopping list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stockShoppinglistAddMissingProductsPostRequest** | [**StockShoppinglistAddMissingProductsPostRequest**](StockShoppinglistAddMissingProductsPostRequest.md) |  | [optional]  |

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
| **400** | The operation was not successful (possible errors are: Not existing shopping list) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockshoppinglistaddproductpost"></a>
# **StockShoppinglistAddProductPost**
> void StockShoppinglistAddProductPost (StockShoppinglistAddProductPostRequest stockShoppinglistAddProductPostRequest)

Adds the given amount of the given product to the given shopping list

If the product is already on the shopping list, the given amount will increase the amount of the already existing item, otherwise a new item will be added


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stockShoppinglistAddProductPostRequest** | [**StockShoppinglistAddProductPostRequest**](StockShoppinglistAddProductPostRequest.md) |  |  |

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
| **400** | The operation was not successful (possible errors are: Not existing shopping list, Invalid product id supplied) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockshoppinglistclearpost"></a>
# **StockShoppinglistClearPost**
> void StockShoppinglistClearPost (StockShoppinglistClearPostRequest stockShoppinglistClearPostRequest = null)

Removes all items from the given shopping list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stockShoppinglistClearPostRequest** | [**StockShoppinglistClearPostRequest**](StockShoppinglistClearPostRequest.md) |  | [optional]  |

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
| **400** | The operation was not successful (possible errors are: Not existing shopping list) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockshoppinglistremoveproductpost"></a>
# **StockShoppinglistRemoveProductPost**
> void StockShoppinglistRemoveProductPost (StockShoppinglistRemoveProductPostRequest stockShoppinglistRemoveProductPostRequest)

Removes the given amount of the given product from the given shopping list, if it is on it

If the resulting amount is <= 0, the item will be completely removed from the given list, otherwise the given amount will reduce the amount of the existing item


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stockShoppinglistRemoveProductPostRequest** | [**StockShoppinglistRemoveProductPostRequest**](StockShoppinglistRemoveProductPostRequest.md) |  |  |

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
| **400** | The operation was not successful (possible errors are: Not existing shopping list, Invalid product id supplied) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stocktransactionstransactionidget"></a>
# **StockTransactionsTransactionIdGet**
> List&lt;StockLogEntry&gt; StockTransactionsTransactionIdGet (string transactionId)

Returns all stock bookings of the given transaction id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | A valid stock transaction id |  |

### Return type

[**List&lt;StockLogEntry&gt;**](StockLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of StockLogEntry objects |  -  |
| **400** | The operation was not successful (possible errors are: Not existing transaction) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stocktransactionstransactionidundopost"></a>
# **StockTransactionsTransactionIdUndoPost**
> void StockTransactionsTransactionIdUndoPost (string transactionId)

Undoes a transaction


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | A valid stock transaction id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing transaction) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stockvolatileget"></a>
# **StockVolatileGet**
> CurrentVolatilStockResponse StockVolatileGet (int dueSoonDays = null)

Returns all products which are due soon, overdue, expired or currently missing


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dueSoonDays** | **int** | The number of days in which products are considered to be due soon | [optional] [default to 5] |

### Return type

[**CurrentVolatilStockResponse**](CurrentVolatilStockResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A CurrentVolatilStockResponse object |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

