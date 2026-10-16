# Org.OpenAPITools.Api.CalendarApi

All URIs are relative to *http://xxx*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalendarIcalGet**](CalendarApi.md#calendaricalget) | **GET** /calendar/ical | Returns the calendar in iCal format |
| [**CalendarIcalSharingLinkGet**](CalendarApi.md#calendaricalsharinglinkget) | **GET** /calendar/ical/sharing-link | Returns a (public) sharing link for the calendar in iCal format |

<a id="calendaricalget"></a>
# **CalendarIcalGet**
> string CalendarIcalGet ()

Returns the calendar in iCal format


### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/calendar, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The iCal file contents |  -  |
| **400** | The operation was not successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="calendaricalsharinglinkget"></a>
# **CalendarIcalSharingLinkGet**
> CalendarIcalSharingLinkGet200Response CalendarIcalSharingLinkGet ()

Returns a (public) sharing link for the calendar in iCal format


### Parameters
This endpoint does not need any parameter.
### Return type

[**CalendarIcalSharingLinkGet200Response**](CalendarIcalSharingLinkGet200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The (public) sharing link for the calendar in iCal format |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

