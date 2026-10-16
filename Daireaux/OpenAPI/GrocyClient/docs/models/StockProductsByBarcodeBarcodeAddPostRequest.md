# Org.OpenAPITools.Model.StockProductsByBarcodeBarcodeAddPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The amount to add - please note that when tare weight handling for the product is enabled, this needs to be the amount including the container weight (gross), the amount to be posted will be automatically calculated based on what is in stock and the defined tare weight | [optional] 
**BestBeforeDate** | **DateTime** | The due date of the product to add, when omitted, the current date is used | [optional] 
**TransactionType** | **StockTransactionType** |  | [optional] 
**Price** | **decimal** | The price per stock quantity unit in configured currency | [optional] 
**LocationId** | **int** | If omitted, the default location of the product is used | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

