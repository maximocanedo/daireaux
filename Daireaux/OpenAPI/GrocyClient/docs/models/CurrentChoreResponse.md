# Org.OpenAPITools.Model.CurrentChoreResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChoreId** | **int** |  | [optional] 
**ChoreName** | **string** |  | [optional] 
**LastTrackedTime** | **DateTime** |  | [optional] 
**TrackDateOnly** | **bool** |  | [optional] 
**NextEstimatedExecutionTime** | **DateTime** | The next estimated execution time of this chore, 2999-12-31 23:59:59 when the given chore has a period_type of manually | [optional] 
**NextExecutionAssignedToUserId** | **int** |  | [optional] 
**IsRescheduled** | **bool** |  | [optional] 
**IsReassigned** | **bool** |  | [optional] 
**NextExecutionAssignedUser** | [**UserDto**](UserDto.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

