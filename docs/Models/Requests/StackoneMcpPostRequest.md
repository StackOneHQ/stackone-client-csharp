# StackoneMcpPostRequest


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `XAccountId`                                                      | *string*                                                          | :heavy_check_mark:                                                | Account secure id for the target provider account                 |
| `McpSessionId`                                                    | *string*                                                          | :heavy_minus_sign:                                                | Session id; omit for initialize, include for subsequent calls     |
| `JsonRpcMessageDto`                                               | [JsonRpcMessageDto](../../Models/Components/JsonRpcMessageDto.md) | :heavy_check_mark:                                                | JSON-RPC 2.0 message                                              |