# MessageMessageType

Stackone enum identifying the type of message associated with the content.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   | Example                                                                       |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Value`                                                                       | [MessageValue](../../Models/Components/MessageValue.md)                       | :heavy_minus_sign:                                                            | The unified message type.                                                     | email                                                                         |
| `SourceValue`                                                                 | [MessageSourceValueUnion](../../Models/Components/MessageSourceValueUnion.md) | :heavy_minus_sign:                                                            | The original value from the provider used to derive the unified message type. | Email                                                                         |