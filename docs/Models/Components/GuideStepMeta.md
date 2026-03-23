# GuideStepMeta


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Title`                                                             | *string*                                                            | :heavy_check_mark:                                                  | The title of the step                                               |
| `Content`                                                           | *string*                                                            | :heavy_check_mark:                                                  | The content of the step, includes markdown formatting               |
| `List`                                                              | List<*string*>                                                      | :heavy_minus_sign:                                                  | List items for the step                                             |
| `DisplayScopes`                                                     | *bool*                                                              | :heavy_minus_sign:                                                  | When true, the step should display scopes                           |
| `ApplicableScopes`                                                  | List<*string*>                                                      | :heavy_minus_sign:                                                  | The scopes for which this step is applicable                        |
| `Image`                                                             | [GuideStepMetaImage](../../Models/Components/GuideStepMetaImage.md) | :heavy_minus_sign:                                                  | An image for the step                                               |