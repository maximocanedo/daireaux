# Org.OpenAPITools.Model.StockEntryEntryIdPutRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The amount to add - please note that when tare weight handling for the product is enabled, this needs to be the amount including the container weight (gross), the amount to be posted will be automatically calculated based on what is in stock and the defined tare weight | [optional] 
**BestBeforeDate** | **DateTime** | The due date of the product to add, when omitted, the current date is used | [optional] 
**Price** | **decimal** | The price per stock quantity unit in configured currency | [optional] 
**Open** | **bool** | If the stock entry was already opened or not | [optional] 
**LocationId** | **int** | If omitted, the default location of the product is used | [optional] 
**ShoppingLocationId** | **int** | If omitted, no store will be affected | [optional] 
**PurchasedDate** | **DateTime** | The date when this stock entry was purchased | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

