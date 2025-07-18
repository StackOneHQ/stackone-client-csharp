<!-- Start SDK Example Usage [usage] -->
```csharp
using StackOne;
using StackOne.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneSDK(security: new Security() {
    Username = "",
    Password = "",
});

ConnectSessionCreate req = new ConnectSessionCreate() {
    Categories = new List<ConnectSessionCreateCategory>() {
        ConnectSessionCreateCategory.Ats,
        ConnectSessionCreateCategory.Hris,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Crm,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Marketing,
        ConnectSessionCreateCategory.Lms,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Documents,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Screening,
        ConnectSessionCreateCategory.Messaging,
        ConnectSessionCreateCategory.Accounting,
    },
    OriginOwnerId = "<id>",
    OriginOwnerName = "<value>",
};

var res = await sdk.ConnectSessions.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->