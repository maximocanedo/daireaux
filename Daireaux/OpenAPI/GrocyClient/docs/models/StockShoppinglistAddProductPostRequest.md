# Org.OpenAPITools.Model.StockShoppinglistAddProductPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **int** | A valid product id of the product to be added | [optional] 
**QuId** | **int** | A valid quantity unit id (used only for display; the amount needs to be related to the products stock QU), when omitted, the products stock QU is used | [optional] 
**ListId** | **int** | A valid shopping list id, when omitted, the default shopping list (with id 1) is used | [optional] 
**ProductAmount** | **decimal** | The amount (related to the products stock QU) to add, when omitted, the default amount of 1 is used | [optional] 
**Note** | **string** | The note of the shopping list item | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

