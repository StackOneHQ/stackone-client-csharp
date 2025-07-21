# MarketingCreateSmsTemplateRequestDto


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Name`                                                      | *string*                                                    | :heavy_minus_sign:                                          | N/A                                                         |                                                             |
| `Tags`                                                      | List<*string*>                                              | :heavy_minus_sign:                                          | N/A                                                         |                                                             |
| `Messages`                                                  | List<[SmsMessages](../../Models/Components/SmsMessages.md)> | :heavy_minus_sign:                                          | N/A                                                         |                                                             |
| `Passthrough`                                               | Dictionary<String, *object*>                                | :heavy_minus_sign:                                          | Value to pass through to the provider                       | {<br/>"other_known_names": "John Doe"<br/>}                 |