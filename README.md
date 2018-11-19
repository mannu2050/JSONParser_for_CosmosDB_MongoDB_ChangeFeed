# JSONParser for Azure Cosmos DB MongoDB ChangeFeed
This project will help developers to read the document in Azure Functions when getting the changes received from Azure Cosmos DB Change Feed if they are using Mongo API.
JSON Sample is shared to provide view of the structure one can expect in the document object. All the logic is written into main method which needs to be pasted in Azure Functions. After moving delete the first line where StreamReader object is created and initiatlize the jsonContent from document object instead of streamreader object.

#Following is the document stored in Azure Cosmos DB collection:

```
{
  "StockName":"MSFT",
  "StockValue": 0.00,
  "StockValueAt": 112233445
}
```
