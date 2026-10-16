# Org.OpenAPITools.Model.ProductDetailsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Product** | [**Product**](Product.md) |  | [optional] 
**ProductBarcodes** | [**List&lt;ProductBarcode&gt;**](ProductBarcode.md) |  | [optional] 
**QuantityUnitStock** | [**QuantityUnit**](QuantityUnit.md) |  | [optional] 
**DefaultQuantityUnitPurchase** | [**QuantityUnit**](QuantityUnit.md) |  | [optional] 
**DefaultQuantityUnitConsume** | [**QuantityUnit**](QuantityUnit.md) |  | [optional] 
**QuantityUnitPrice** | [**QuantityUnit**](QuantityUnit.md) |  | [optional] 
**LastPurchased** | **DateTime** |  | [optional] 
**LastUsed** | **DateTime** |  | [optional] 
**StockAmount** | **decimal** |  | [optional] 
**StockAmountOpened** | **decimal** |  | [optional] 
**NextDueDate** | **DateTime** |  | [optional] 
**LastPrice** | **decimal** | The price of the last purchase of the corresponding product | [optional] 
**AvgPrice** | **decimal** | The average price af all stock entries currently in stock of the corresponding product | [optional] 
**CurrentPrice** | **decimal** | The current price of the corresponding product, based on the stock entry to use next (defined by the default consume rule \&quot;Opened first, then first due first, then first in first out\&quot;) or on the last price if the product is currently not in stock | [optional] 
**OldestPrice** | **decimal** | This field is deprecated and will be removed in a future version (currently returns the same as &#x60;current_price&#x60;) | [optional] 
**LastShoppingLocationId** | **int** |  | [optional] 
**Location** | [**Location**](Location.md) |  | [optional] 
**AverageShelfLifeDays** | **decimal** |  | [optional] 
**SpoilRatePercent** | **decimal** |  | [optional] 
**HasChilds** | **bool** | True when the product is a parent product of others | [optional] 
**DefaultLocation** | [**Location**](Location.md) |  | [optional] 
**QuConversionFactorPurchaseToStock** | **decimal** | The conversion factor of the corresponding QU conversion from the product&#39;s qu_id_purchase to qu_id_stock | [optional] 
**QuConversionFactorPriceToStock** | **decimal** | The conversion factor of the corresponding QU conversion from the product&#39;s qu_id_price to qu_id_stock | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

