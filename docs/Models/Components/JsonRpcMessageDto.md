# JsonRpcMessageDto


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 | Example                                     |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Jsonrpc`                                   | *string*                                    | :heavy_check_mark:                          | JSON-RPC protocol version                   | 2.0                                         |
| `Method`                                    | *string*                                    | :heavy_check_mark:                          | JSON-RPC method name                        | initialize                                  |
| `Params`                                    | [Params](../../Models/Components/Params.md) | :heavy_minus_sign:                          | Method parameters (arbitrary JSON)          |                                             |
| `Id`                                        | [Id](../../Models/Components/Id.md)         | :heavy_minus_sign:                          | Request id (arbitrary JSON scalar)          |                                             |