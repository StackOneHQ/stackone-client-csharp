# CategoryLevelSourceValueUnion

For read operations: the original category level from the provider. For write operations: fallback value used when value is omitted or "unmapped_value". You must ensure this matches the provider's format.


## Supported Types

### Str

```csharp
CategoryLevelSourceValueUnion.CreateStr(/* values here */);
```

### Number

```csharp
CategoryLevelSourceValueUnion.CreateNumber(/* values here */);
```

### Boolean

```csharp
CategoryLevelSourceValueUnion.CreateBoolean(/* values here */);
```

### CategorySourceValueLevel

```csharp
CategoryLevelSourceValueUnion.CreateCategorySourceValueLevel(/* values here */);
```

### ArrayOfAny

```csharp
CategoryLevelSourceValueUnion.CreateArrayOfAny(/* values here */);
```
