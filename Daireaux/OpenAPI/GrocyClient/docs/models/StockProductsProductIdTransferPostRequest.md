# Org.OpenAPITools.Model.StockProductsProductIdTransferPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The amount to transfer - please note that when tare weight handling for the product is enabled, this needs to be the amount including the container weight (gross), the amount to be posted will be automatically calculated based on what is in stock and the defined tare weight | [optional] 
**LocationIdFrom** | **int** | A valid location id, the location from where the product should be transfered | [optional] 
**LocationIdTo** | **int** | A valid location id, the location to where the product should be transfered | [optional] 
**StockEntryId** | **string** | A specific stock entry id to transfer, if used, the amount has to be 1 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

