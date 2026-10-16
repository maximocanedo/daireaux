# Org.OpenAPITools.Api.ChoresApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChoresChoreIdExecutePost**](ChoresApi.md#choreschoreidexecutepost) | **POST** /chores/{choreId}/execute | Tracks an execution of the given chore |
| [**ChoresChoreIdGet**](ChoresApi.md#choreschoreidget) | **GET** /chores/{choreId} | Returns details of the given chore |
| [**ChoresChoreIdPrintlabelGet**](ChoresApi.md#choreschoreidprintlabelget) | **GET** /chores/{choreId}/printlabel | Prints the Grocycode label of the given chore on the configured label printer |
| [**ChoresChoreIdToKeepMergeChoreIdToRemovePost**](ChoresApi.md#choreschoreidtokeepmergechoreidtoremovepost) | **POST** /chores/{choreIdToKeep}/merge/{choreIdToRemove} | Merges two chores into one |
| [**ChoresExecutionsCalculateNextAssignmentsPost**](ChoresApi.md#choresexecutionscalculatenextassignmentspost) | **POST** /chores/executions/calculate-next-assignments | (Re)calculates all next user assignments of all chores |
| [**ChoresExecutionsExecutionIdUndoPost**](ChoresApi.md#choresexecutionsexecutionidundopost) | **POST** /chores/executions/{executionId}/undo | Undoes a chore execution |
| [**ChoresGet**](ChoresApi.md#choresget) | **GET** /chores | Returns all chores incl. the next estimated execution time per chore |

<a id="choreschoreidexecutepost"></a>
# **ChoresChoreIdExecutePost**
> ChoreLogEntry ChoresChoreIdExecutePost (int choreId, ChoresChoreIdExecutePostRequest choresChoreIdExecutePostRequest)

Tracks an execution of the given chore


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **choreId** | **int** | A valid chore id |  |
| **choresChoreIdExecutePostRequest** | [**ChoresChoreIdExecutePostRequest**](ChoresChoreIdExecutePostRequest.md) |  |  |

### Return type

[**ChoreLogEntry**](ChoreLogEntry.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The operation was successful |  -  |
| **400** | The operation was not successful (possible errors are: Not existing chore) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="choreschoreidget"></a>
# **ChoresChoreIdGet**
> ChoreDetailsResponse ChoresChoreIdGet (int choreId)

Returns details of the given chore


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **choreId** | **int** | A valid chore id |  |

### Return type

[**ChoreDetailsResponse**](ChoreDetailsResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A ChoreDetailsResponse object |  -  |
| **400** | The operation was not successful (possible errors are: Not existing chore) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="choreschoreidprintlabelget"></a>
# **ChoresChoreIdPrintlabelGet**
> Object ChoresChoreIdPrintlabelGet (int choreId)

Prints the Grocycode label of the given chore on the configured label printer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **choreId** | **int** | A valid chore id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing chore, error on WebHook execution) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="choreschoreidtokeepmergechoreidtoremovepost"></a>
# **ChoresChoreIdToKeepMergeChoreIdToRemovePost**
> void ChoresChoreIdToKeepMergeChoreIdToRemovePost (int choreIdToKeep, int choreIdToRemove)

Merges two chores into one


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **choreIdToKeep** | **int** | A valid chore id of the chore to keep |  |
| **choreIdToRemove** | **int** | A valid chore id of the chore to remove |  |

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
| **400** | The operation was not successful (possible errors are: Invalid chore id) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="choresexecutionscalculatenextassignmentspost"></a>
# **ChoresExecutionsCalculateNextAssignmentsPost**
> void ChoresExecutionsCalculateNextAssignmentsPost (ChoresExecutionsCalculateNextAssignmentsPostRequest choresExecutionsCalculateNextAssignmentsPostRequest = null)

(Re)calculates all next user assignments of all chores


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **choresExecutionsCalculateNextAssignmentsPostRequest** | [**ChoresExecutionsCalculateNextAssignmentsPostRequest**](ChoresExecutionsCalculateNextAssignmentsPostRequest.md) |  | [optional]  |

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

<a id="choresexecutionsexecutionidundopost"></a>
# **ChoresExecutionsExecutionIdUndoPost**
> void ChoresExecutionsExecutionIdUndoPost (int executionId)

Undoes a chore execution


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **int** | A valid chore execution id |  |

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

<a id="choresget"></a>
# **ChoresGet**
> List&lt;CurrentChoreResponse&gt; ChoresGet (List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all chores incl. the next estimated execution time per chore


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;CurrentChoreResponse&gt;**](CurrentChoreResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of CurrentChoreResponse objects |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

