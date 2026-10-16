# Org.OpenAPITools.Model.ChoreDetailsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chore** | [**Chore**](Chore.md) |  | [optional] 
**LastTracked** | **DateTime** | When this chore was last tracked | [optional] 
**TrackCount** | **int** | How often this chore was tracked so far | [optional] 
**LastDoneBy** | [**UserDto**](UserDto.md) |  | [optional] 
**NextEstimatedExecutionTime** | **DateTime** |  | [optional] 
**NextExecutionAssignedUser** | [**UserDto**](UserDto.md) |  | [optional] 
**AverageExecutionFrequencyHours** | **int** | Contains the average past execution frequency in hours or &#x60;null&#x60;, when the chore was never executed before | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

