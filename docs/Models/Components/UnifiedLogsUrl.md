# UnifiedLogsUrl

The request URL data


## Fields

| Field                               | Type                                | Required                            | Description                         | Example                             |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `Url`                               | *string*                            | :heavy_minus_sign:                  | The request URL                     | https://example.com/api/v1/resource |
| `Hostname`                          | *string*                            | :heavy_minus_sign:                  | The request URL hostname            | example.com                         |
| `Path`                              | *string*                            | :heavy_minus_sign:                  | The request path                    | /api/v1/resource                    |
| `QueryParams`                       | Dictionary<String, *object*>        | :heavy_minus_sign:                  | The request query parameters        | {<br/>"page": 1,<br/>"limit": 10<br/>} |