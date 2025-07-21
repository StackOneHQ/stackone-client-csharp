# EmploymentJob

The job of employee


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `Id`                                                  | *string*                                              | :heavy_minus_sign:                                    | Unique identifier                                     | 8187e5da-dc77-475e-9949-af0f1fa4e4e3                  |
| `RemoteId`                                            | *string*                                              | :heavy_minus_sign:                                    | Provider's unique identifier                          | 8187e5da-dc77-475e-9949-af0f1fa4e4e3                  |
| `Title`                                               | *string*                                              | :heavy_minus_sign:                                    | Title of the job                                      | Software Engineer                                     |
| `Description`                                         | [Description](../../Models/Components/Description.md) | :heavy_minus_sign:                                    | The employee job description                          |                                                       |
| `OwnerId`                                             | *string*                                              | :heavy_minus_sign:                                    | The owner_id of the job                               | 5356                                                  |
| `ParentId`                                            | *string*                                              | :heavy_minus_sign:                                    | The parent_id of the job                              | 7577                                                  |