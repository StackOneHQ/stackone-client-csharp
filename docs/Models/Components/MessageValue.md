# MessageValue

The unified message type.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = MessageValue.Email;

// Open enum: use .Of() to create instances from custom string values
var custom = MessageValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Email`         | email           |
| `Sms`           | sms             |
| `Push`          | push            |
| `WebPush`       | web_push        |
| `IosPush`       | ios_push        |
| `AndroidPush`   | android_push    |
| `AppPush`       | app_push        |
| `OmniChannel`   | omni_channel    |
| `ContentBlock`  | content_block   |
| `InApp`         | in_app          |
| `Unknown`       | unknown         |
| `UnmappedValue` | unmapped_value  |