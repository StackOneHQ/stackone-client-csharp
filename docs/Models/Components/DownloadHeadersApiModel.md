# DownloadHeadersApiModel


## Fields

| Field                                   | Type                                    | Required                                | Description                             | Example                                 |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `ContentDisposition`                    | *string*                                | :heavy_minus_sign:                      | Value of the Content-Disposition header | attachment; filename="example.pdf"      |
| `ContentType`                           | *string*                                | :heavy_minus_sign:                      | MIME type of the file                   | application/pdf                         |
| `ContentLength`                         | *double*                                | :heavy_minus_sign:                      | Size of the content in bytes            | 1024                                    |
| `ContentRange`                          | *string*                                | :heavy_minus_sign:                      | Range of the content being sent         | bytes 0-1023/2048                       |
| `ContentEncoding`                       | *string*                                | :heavy_minus_sign:                      | Encoding of the content                 | gzip                                    |
| `TransferEncoding`                      | *string*                                | :heavy_minus_sign:                      | Transfer encoding type                  | chunked                                 |