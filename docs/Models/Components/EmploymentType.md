# EmploymentType

The type of employment


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_minus_sign:                                                  | Unique identifier                                                   | 8187e5da-dc77-475e-9949-af0f1fa4e4e3                                |
| `RemoteId`                                                          | *string*                                                            | :heavy_minus_sign:                                                  | Provider's unique identifier                                        | 8187e5da-dc77-475e-9949-af0f1fa4e4e3                                |
| `Label`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | The label of the employment type                                    | Permanent                                                           |
| `Type`                                                              | [EmploymentTypeType](../../Models/Components/EmploymentTypeType.md) | :heavy_minus_sign:                                                  | The type of employment (e.g., contractor, permanent)                | permanent                                                           |