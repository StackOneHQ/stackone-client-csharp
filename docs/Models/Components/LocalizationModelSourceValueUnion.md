# LocalizationModelSourceValueUnion

For read operations: the original language code from the provider. For write operations: fallback value used when value is omitted or "unmapped_value". You must ensure this matches the provider's format.


## Supported Types

### Str

```csharp
LocalizationModelSourceValueUnion.CreateStr(/* values here */);
```

### Number

```csharp
LocalizationModelSourceValueUnion.CreateNumber(/* values here */);
```

### Boolean

```csharp
LocalizationModelSourceValueUnion.CreateBoolean(/* values here */);
```

### LocalizationModelSourceValue

```csharp
LocalizationModelSourceValueUnion.CreateLocalizationModelSourceValue(/* values here */);
```

### ArrayOfAny

```csharp
LocalizationModelSourceValueUnion.CreateArrayOfAny(/* values here */);
```
