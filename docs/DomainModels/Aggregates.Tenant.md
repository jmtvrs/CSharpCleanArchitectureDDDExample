# Domain Models


- [Tenant](#tenant)


## Tenant

```csharp
class Tenant
{
    Tenant Create();
    void Update();
    void Delete();
}

```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "clientId": "00000000-0000-0000-0000-000000000000",
    "physicalDeviceIds": [
        "00000000-0000-0000-0000-000000000000",
        "00000000-0000-0000-0000-000000000000"
    ],
    "createdDateTime": "2023-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2023-01-01T00:00:00.0000000Z"
}
```