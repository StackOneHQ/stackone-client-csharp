# HrisListTimeOffPoliciesFilter

HRIS Time-Off Policies filters


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `UpdatedAfter`                                                                        | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Use a string with a date to only select results updated after that given date         | 2020-01-01T00:00:00.000Z                                                              |
| `Type`                                                                                | [HrisListTimeOffPoliciesType](../../Models/Requests/HrisListTimeOffPoliciesType.md)   | :heavy_minus_sign:                                                                    | Filter to select time-off policies by type                                            |                                                                                       |