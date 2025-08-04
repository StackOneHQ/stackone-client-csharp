# AtsListApplicationChangesFilter

Filter parameters for application changes (supports created_after and change_type)


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CreatedAfter`                                                                        | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Use a string with a date to only select results created after that given date         | 2020-01-01T00:00:00.000Z                                                              |
| `ChangeType`                                                                          | [Models.Requests.ChangeType](../../Models/Requests/ChangeType.md)                     | :heavy_minus_sign:                                                                    | Filter by the type of change that occurred to the application                         |                                                                                       |