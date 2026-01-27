# ActionSearchResultDto


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `ActionName`                                         | *string*                                             | :heavy_check_mark:                                   | Unique action identifier                             |
| `ConnectorKey`                                       | *string*                                             | :heavy_check_mark:                                   | Connector key                                        |
| `SimilarityScore`                                    | *double*                                             | :heavy_check_mark:                                   | Cosine similarity score (0-1)                        |
| `Label`                                              | *string*                                             | :heavy_check_mark:                                   | Human-readable action label                          |
| `Description`                                        | *string*                                             | :heavy_check_mark:                                   | Action description                                   |
| `ProjectId`                                          | *string*                                             | :heavy_check_mark:                                   | Project ID of the action (global for shared actions) |