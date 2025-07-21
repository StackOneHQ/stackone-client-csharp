# LmsListUserAssignmentsResponse


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `HttpMeta`                                                                        | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)                           | :heavy_check_mark:                                                                | N/A                                                                               |
| `AssignmentsPaginated`                                                            | [AssignmentsPaginated](../../Models/Components/AssignmentsPaginated.md)           | :heavy_minus_sign:                                                                | The assignments related to the employee with the given identifier were retrieved. |
| `Headers`                                                                         | Dictionary<String, List<*string*>>                                                | :heavy_check_mark:                                                                | N/A                                                                               |