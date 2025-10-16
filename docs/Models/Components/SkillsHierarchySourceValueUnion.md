# SkillsHierarchySourceValueUnion

For read operations: the original skill level from the provider. For write operations: fallback value used when value is omitted or "unmapped_value". You must ensure this matches the provider's format.


## Supported Types

### Str

```csharp
SkillsHierarchySourceValueUnion.CreateStr(/* values here */);
```

### Number

```csharp
SkillsHierarchySourceValueUnion.CreateNumber(/* values here */);
```

### Boolean

```csharp
SkillsHierarchySourceValueUnion.CreateBoolean(/* values here */);
```

### SkillsSourceValueHierarchy

```csharp
SkillsHierarchySourceValueUnion.CreateSkillsSourceValueHierarchy(/* values here */);
```

### ArrayOfAny

```csharp
SkillsHierarchySourceValueUnion.CreateArrayOfAny(/* values here */);
```
