# ActionsRpcRequestDto


## Fields

| Field                                     | Type                                      | Required                                  | Description                               | Example                                   |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `Action`                                  | *string*                                  | :heavy_check_mark:                        | The action to execute                     | create_employee                           |
| `Path`                                    | Dictionary<String, *object*>              | :heavy_minus_sign:                        | Path parameters for the action            | {<br/>"id": "123"<br/>}                   |
| `Query`                                   | [Query](../../Models/Components/Query.md) | :heavy_minus_sign:                        | Query parameters for the action           |                                           |
| `Headers`                                 | Dictionary<String, *object*>              | :heavy_minus_sign:                        | Headers for the action                    | {<br/>"Content-Type": "application/json"<br/>} |
| `Body`                                    | Dictionary<String, *object*>              | :heavy_minus_sign:                        | Request body for the action               | {<br/>"data": "example"<br/>}             |