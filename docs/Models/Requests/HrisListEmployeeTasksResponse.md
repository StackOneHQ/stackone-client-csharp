# HrisListEmployeeTasksResponse


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `HttpMeta`                                                                  | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)                     | :heavy_check_mark:                                                          | N/A                                                                         |
| `TasksPaginated`                                                            | [TasksPaginated](../../Models/Components/TasksPaginated.md)                 | :heavy_minus_sign:                                                          | The list of tasks for the employee with the given identifier was retrieved. |
| `Headers`                                                                   | Dictionary<String, List<*string*>>                                          | :heavy_check_mark:                                                          | N/A                                                                         |