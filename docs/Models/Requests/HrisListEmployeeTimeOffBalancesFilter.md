# HrisListEmployeeTimeOffBalancesFilter

HRIS Time Off Balance filters


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `UpdatedAfter`                                                                        | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Use a string with a date to only select results updated after that given date         | 2020-01-01T00:00:00.000Z                                                              |
| `PolicyIds`                                                                           | List<*string*>                                                                        | :heavy_minus_sign:                                                                    | List of policy ids to filter time off balances by.                                    |                                                                                       |