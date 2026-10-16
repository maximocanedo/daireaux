# Org.OpenAPITools.Api.FilesApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FilesGroupFileNameDelete**](FilesApi.md#filesgroupfilenamedelete) | **DELETE** /files/{group}/{fileName} | Deletes the given file |
| [**FilesGroupFileNameGet**](FilesApi.md#filesgroupfilenameget) | **GET** /files/{group}/{fileName} | Serves the given file |
| [**FilesGroupFileNamePut**](FilesApi.md#filesgroupfilenameput) | **PUT** /files/{group}/{fileName} | Uploads a single file |

<a id="filesgroupfilenamedelete"></a>
# **FilesGroupFileNameDelete**
> void FilesGroupFileNameDelete (FileGroups group, string fileName)

Deletes the given file


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **FileGroups** | The file group |  |
| **fileName** | **string** | The file name (including extension)&lt;br&gt;**BASE64 encoded** |  |

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

<a id="filesgroupfilenameget"></a>
# **FilesGroupFileNameGet**
> System.IO.Stream FilesGroupFileNameGet (FileGroups group, string fileName, string forceServeAs = null, decimal bestFitHeight = null, decimal bestFitWidth = null)

Serves the given file

With proper Content-Type header


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **FileGroups** | The file group |  |
| **fileName** | **string** | The file name (including extension)&lt;br&gt;**BASE64 encoded** |  |
| **forceServeAs** | **string** | Force the file to be served as the given type | [optional]  |
| **bestFitHeight** | **decimal** | Only when using &#x60;force_serve_as&#x60; &#x3D; &#x60;picture&#x60;: Downscale the picture to the given height while maintaining the aspect ratio | [optional]  |
| **bestFitWidth** | **decimal** | Only when using &#x60;force_serve_as&#x60; &#x3D; &#x60;picture&#x60;: Downscale the picture to the given width while maintaining the aspect ratio | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The binary file contents (Content-Type header is automatically set based on the file type) |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="filesgroupfilenameput"></a>
# **FilesGroupFileNamePut**
> void FilesGroupFileNamePut (FileGroups group, string fileName, System.IO.Stream body = null)

Uploads a single file

The file will be stored at /data/storage/{group}/{file_name} (you need to remember the group and file name to get or delete it again)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **FileGroups** | The file group |  |
| **fileName** | **string** | The file name (including extension)&lt;br&gt;**BASE64 encoded** |  |
| **body** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The operation was successful |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

