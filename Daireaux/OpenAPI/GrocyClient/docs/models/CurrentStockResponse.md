# Org.OpenAPITools.Model.CurrentStockResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **int** |  | [optional] 
**Amount** | **decimal** |  | [optional] 
**AmountAggregated** | **decimal** |  | [optional] 
**AmountOpened** | **decimal** |  | [optional] 
**AmountOpenedAggregated** | **decimal** |  | [optional] 
**BestBeforeDate** | **DateTime** | The next due date for this product | [optional] 
**IsAggregatedAmount** | **bool** | Indicates wheter this product has sub-products or not / if the fields &#x60;amount_aggregated&#x60; and &#x60;amount_opened_aggregated&#x60; are filled | [optional] 
**Product** | [**ProductWithoutUserfields**](ProductWithoutUserfields.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

