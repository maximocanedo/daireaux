# Org.OpenAPITools.Api.TasksApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TasksGet**](TasksApi.md#tasksget) | **GET** /tasks | Returns all tasks which are not done yet |
| [**TasksTaskIdCompletePost**](TasksApi.md#taskstaskidcompletepost) | **POST** /tasks/{taskId}/complete | Marks the given task as completed |
| [**TasksTaskIdUndoPost**](TasksApi.md#taskstaskidundopost) | **POST** /tasks/{taskId}/undo | Marks the given task as not completed |

<a id="tasksget"></a>
# **TasksGet**
> List&lt;CurrentTaskResponse&gt; TasksGet (List<string> query = null, string order = null, int limit = null, int offset = null)

Returns all tasks which are not done yet


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**List&lt;string&gt;**](string.md) | An array of filter conditions, each of them is a string in the form of &#x60;&lt;field&gt;&lt;condition&gt;&lt;value&gt;&#x60; where&lt;br&gt;&#x60;&lt;field&gt;&#x60; is a valid field name&lt;br&gt;&#x60;&lt;condition&gt;&#x60; is a comparison operator, one of&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&#x3D;&#x60; equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!&#x3D;&#x60; not equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;~&#x60; LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;!~&#x60; not LIKE&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x60; less&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x60; greater&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&lt;&#x3D;&#x60; less or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;&gt;&#x3D;&#x60; greater or equal&lt;br&gt;&amp;nbsp;&amp;nbsp;&#x60;§&#x60; regular expression&lt;br&gt;&#x60;&lt;value&gt;&#x60; is the value to search for | [optional]  |
| **order** | **string** | A valid field name by which the response should be ordered, use the separator &#x60;:&#x60; to specify the sort order (&#x60;asc&#x60; or &#x60;desc&#x60;, defaults to &#x60;asc&#x60; when omitted) | [optional]  |
| **limit** | **int** | The maximum number of objects to return | [optional]  |
| **offset** | **int** | The number of objects to skip | [optional]  |

### Return type

[**List&lt;CurrentTaskResponse&gt;**](CurrentTaskResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of CurrentTaskResponse objects |  -  |
| **500** | The operation was not successful (possible errors are invalid field names or conditions in filter parameters provided) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taskstaskidcompletepost"></a>
# **TasksTaskIdCompletePost**
> void TasksTaskIdCompletePost (int taskId, TasksTaskIdCompletePostRequest tasksTaskIdCompletePostRequest)

Marks the given task as completed


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **int** | A valid task id |  |
| **tasksTaskIdCompletePostRequest** | [**TasksTaskIdCompletePostRequest**](TasksTaskIdCompletePostRequest.md) |  |  |

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
| **400** | The operation was not successful (possible errors are: Not existing task) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taskstaskidundopost"></a>
# **TasksTaskIdUndoPost**
> void TasksTaskIdUndoPost (int taskId)

Marks the given task as not completed


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **int** | A valid task id |  |

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
| **400** | The operation was not successful (possible errors are: Not existing task) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

