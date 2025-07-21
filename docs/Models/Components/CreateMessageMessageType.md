# CreateMessageMessageType

Stackone enum identifying the type of message associated with the content.


## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Value`                                                                                   | [CreateMessageValue](../../Models/Components/CreateMessageValue.md)                       | :heavy_minus_sign:                                                                        | The unified message type.                                                                 | email                                                                                     |
| `SourceValue`                                                                             | [CreateMessageSourceValueUnion](../../Models/Components/CreateMessageSourceValueUnion.md) | :heavy_minus_sign:                                                                        | The original value from the provider used to derive the unified message type.             | Email                                                                                     |