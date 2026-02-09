# GuideSectionMeta


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Title`                                                         | *string*                                                        | :heavy_check_mark:                                              | The title of the section                                        |
| `Content`                                                       | *string*                                                        | :heavy_check_mark:                                              | The content of the section, includes markdown formatting        |
| `List`                                                          | List<*string*>                                                  | :heavy_minus_sign:                                              | List items for the section                                      |
| `Steps`                                                         | List<[GuideStepMeta](../../Models/Components/GuideStepMeta.md)> | :heavy_minus_sign:                                              | Nested steps within the section                                 |