# ProxyRequestBody


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            | Example                                                |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `Url`                                                  | *string*                                               | :heavy_minus_sign:                                     | The base url of the request                            | https://api.sample-integration.com/v1                  |
| `Method`                                               | [Method](../../Models/Components/Method.md)            | :heavy_minus_sign:                                     | The method of the request                              |                                                        |
| `Path`                                                 | *string*                                               | :heavy_minus_sign:                                     | The path of the request including any query parameters | /employees/directory                                   |
| `Headers`                                              | Dictionary<String, *object*>                           | :heavy_minus_sign:                                     | The headers to send in the request                     | {<br/>"Content-Type": "application/json"<br/>}         |
| `Body`                                                 | Dictionary<String, *object*>                           | :heavy_minus_sign:                                     | The body of the request                                |                                                        |