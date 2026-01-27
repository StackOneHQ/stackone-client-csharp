# ActionBuildDto


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     | Example                                                         |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectorKey`                                                  | *string*                                                        | :heavy_minus_sign:                                              | Specific connector key to rebuild embeddings for                | slack                                                           |
| `ForceRefresh`                                                  | *bool*                                                          | :heavy_minus_sign:                                              | Force refresh - clear all existing embeddings before rebuilding |                                                                 |