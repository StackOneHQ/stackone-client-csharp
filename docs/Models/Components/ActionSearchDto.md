# ActionSearchDto


## Fields

| Field                                      | Type                                       | Required                                   | Description                                | Example                                    |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `Query`                                    | *string*                                   | :heavy_check_mark:                         | Search query for finding connector actions | send a message                             |
| `Connector`                                | *string*                                   | :heavy_minus_sign:                         | Filter by connector key                    | slack                                      |
| `TopK`                                     | *double*                                   | :heavy_minus_sign:                         | Number of results to return                |                                            |