# Org.OpenAPITools.Api.RecipesApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RecipesFulfillmentGet**](RecipesApi.md#recipesfulfillmentget) | **GET** /recipes/fulfillment | Get stock fulfillment information for all recipe |
| [**RecipesRecipeIdAddNotFulfilledProductsToShoppinglistPost**](RecipesApi.md#recipesrecipeidaddnotfulfilledproductstoshoppinglistpost) | **POST** /recipes/{recipeId}/add-not-fulfilled-products-to-shoppinglist | Adds all missing products for the given recipe to the shopping list |
| [**RecipesRecipeIdConsumePost**](RecipesApi.md#recipesrecipeidconsumepost) | **POST** /recipes/{recipeId}/consume | Consumes all in stock ingredients of the given recipe (for ingredients that are only partially in stock, the in stock amount will be consumed) |
| [**RecipesRecipeIdCopyPost**](RecipesApi.md#recipesrecipeidcopypost) | **POST** /recipes/{recipeId}/copy | Copies a recipe |
| [**RecipesRecipeIdFulfillmentGet**](RecipesApi.md#recipesrecipeidfulfillmentget) | **GET** /recipes/{recipeId}/fulfillment | Get stock fulfillment information for the given recipe |
| [**RecipesRecipeIdPrintlabelGet**](RecipesApi.md#recipesrecipeidprintlabelget) | **GET** /recipes/{recipeId}/printlabel | Prints the Grocycode label of the given recipe on the configured label printer |

<a id="recipesfulfillmentget"></a>
# **RecipesFulfillmentGet**
> List&lt;RecipeFulfillmentResponse&gt; RecipesFulfillmentGet (List<string> query = null, string order = null, int limit = null, int offset = null)

Get stock fulfillment information for all recipe


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;RecipeFulfillmentResponse&gt;**](RecipeFulfillmentResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of RecipeFulfillmentResponse objects |  -  |
| **400** | The operation was not successful |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="recipesrecipeidaddnotfulfilledproductstoshoppinglistpost"></a>
# **RecipesRecipeIdAddNotFulfilledProductsToShoppinglistPost**
> void RecipesRecipeIdAddNotFulfilledProductsToShoppinglistPost (string recipeId, RecipesRecipeIdAddNotFulfilledProductsToShoppinglistPostRequest recipesRecipeIdAddNotFulfilledProductsToShoppinglistPostRequest = null)

Adds all missing products for the given recipe to the shopping list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipeId** | **string** | A valid recipe id |  |
| **recipesRecipeIdAddNotFulfilledProductsToShoppinglistPostRequest** | [**RecipesRecipeIdAddNotFulfilledProductsToShoppinglistPostRequest**](RecipesRecipeIdAddNotFulfilledProductsToShoppinglistPostRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The operation was successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="recipesrecipeidconsumepost"></a>
# **RecipesRecipeIdConsumePost**
> void RecipesRecipeIdConsumePost (string recipeId)

Consumes all in stock ingredients of the given recipe (for ingredients that are only partially in stock, the in stock amount will be consumed)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipeId** | **string** | A valid recipe id |  |

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
| **400** | The operation was not successful (possible errors are: Invalid recipe id, recipe need is not fulfilled) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="recipesrecipeidcopypost"></a>
# **RecipesRecipeIdCopyPost**
> RecipesRecipeIdCopyPost200Response RecipesRecipeIdCopyPost (int recipeId)

Copies a recipe


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipeId** | **int** | A valid recipe id of the recipe to copy |  |

### Return type

[**RecipesRecipeIdCopyPost200Response**](RecipesRecipeIdCopyPost200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Invalid recipe id) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="recipesrecipeidfulfillmentget"></a>
# **RecipesRecipeIdFulfillmentGet**
> RecipeFulfillmentResponse RecipesRecipeIdFulfillmentGet (string recipeId)

Get stock fulfillment information for the given recipe


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipeId** | **string** | A valid recipe id |  |

### Return type

[**RecipeFulfillmentResponse**](RecipeFulfillmentResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A RecipeFulfillmentResponse object |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="recipesrecipeidprintlabelget"></a>
# **RecipesRecipeIdPrintlabelGet**
> Object RecipesRecipeIdPrintlabelGet (int recipeId)

Prints the Grocycode label of the given recipe on the configured label printer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipeId** | **int** | A valid recipe id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing recipe, error on WebHook execution) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

