# AtsListJobApplicationStagesResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `HttpMeta`                                                                          | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)                             | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `ApplicationStagesPaginated`                                                        | [ApplicationStagesPaginated](../../Models/Components/ApplicationStagesPaginated.md) | :heavy_minus_sign:                                                                  | A list of all application stages that have been configured for the specified job.   |
| `Headers`                                                                           | Dictionary<String, List<*string*>>                                                  | :heavy_check_mark:                                                                  | N/A                                                                                 |