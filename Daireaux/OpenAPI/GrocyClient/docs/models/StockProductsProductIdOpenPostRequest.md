# Org.OpenAPITools.Model.StockProductsProductIdOpenPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The amount to mark as opened | [optional] 
**StockEntryId** | **string** | A specific stock entry id to open, if used, the amount has to be 1 | [optional] 
**AllowSubproductSubstitution** | **bool** | &#x60;true&#x60; when any in stock sub product should be used when the given product is a parent product and currently not in stock | [optional] 
**LocationId** | **int** | A valid location id (if supplied, only stock at the given location is considered, if ommitted, stock of any location is considered) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

