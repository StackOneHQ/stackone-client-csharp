# SkillsLanguageSourceValueUnion

For read operations: the original language code from the provider. For write operations: fallback value used when value is omitted or "unmapped_value". You must ensure this matches the provider's format.


## Supported Types

### Str

```csharp
SkillsLanguageSourceValueUnion.CreateStr(/* values here */);
```

### Number

```csharp
SkillsLanguageSourceValueUnion.CreateNumber(/* values here */);
```

### Boolean

```csharp
SkillsLanguageSourceValueUnion.CreateBoolean(/* values here */);
```

### SkillsSourceValueLanguage

```csharp
SkillsLanguageSourceValueUnion.CreateSkillsSourceValueLanguage(/* values here */);
```

### ArrayOfAny

```csharp
SkillsLanguageSourceValueUnion.CreateArrayOfAny(/* values here */);
```
