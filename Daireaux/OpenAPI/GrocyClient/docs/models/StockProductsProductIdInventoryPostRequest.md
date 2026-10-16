# Org.OpenAPITools.Model.StockProductsProductIdInventoryPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewAmount** | **decimal** | The new current amount for the given product - please note that when tare weight handling for the product is enabled, this needs to be the amount including the container weight (gross), the amount to be posted will be automatically calculated based on what is in stock and the defined tare weight | [optional] 
**BestBeforeDate** | **DateTime** | The due date which applies to added products | [optional] 
**ShoppingLocationId** | **int** | If omitted, no store will be affected | [optional] 
**LocationId** | **int** | If omitted, the default location of the product is used (only applies to added products) | [optional] 
**Price** | **decimal** | If omitted, the last price of the product is used (only applies to added products) | [optional] 
**StockLabelType** | **int** | &#x60;1&#x60; &#x3D; No label, &#x60;2&#x60; &#x3D; Single label, &#x60;3&#x60; &#x3D; Label per unit (only applies to added products) | [optional] 
**Note** | **string** | An optional note for the corresponding stock entry (only applies to added products) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

