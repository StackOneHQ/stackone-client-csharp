# ChannelsEnumValue

The Channels of the campaign.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ChannelsEnumValue.Email;

// Open enum: use .Of() to create instances from custom string values
var custom = ChannelsEnumValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Email`         | email           |
| `Sms`           | sms             |
| `WebPush`       | web_push        |
| `IosPush`       | ios_push        |
| `AndroidPush`   | android_push    |
| `Unknown`       | unknown         |
| `UnmappedValue` | unmapped_value  |