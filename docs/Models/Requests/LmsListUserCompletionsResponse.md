# LmsListUserCompletionsResponse


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `HttpMeta`                                                                   | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)                      | :heavy_check_mark:                                                           | N/A                                                                          |
| `CompletionsPaginated`                                                       | [CompletionsPaginated](../../Models/Components/CompletionsPaginated.md)      | :heavy_minus_sign:                                                           | The completions with for the users with the given identifier were retrieved. |
| `Headers`                                                                    | Dictionary<String, List<*string*>>                                           | :heavy_check_mark:                                                           | N/A                                                                          |