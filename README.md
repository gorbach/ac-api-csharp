# Unofficial ActiveCampaign C# Wrapper
C# Wrapper for the ActiveCampaign API

This is still a work in progress and will update as it is finished

## Connect to API
```
string url = "https://account.api-us1.com";
string key = "API_KEY";

Ac ac = new Ac(new Api(url, key, true));
```

## Examples
```csharp
// View User
ac.Api.User.View(1);

// Create new Contact
ac.Api.Contact.Add(new Contact()
{
    Email = "test@example.com",
    FirstName = "FirstName",
    LastName = "LastName",
    Phone = "123-456-7890",
    OrgName = "Acme Inc.",
    ListDictionary = new Dictionary<int, int>() {{1, 1}},
    StatusDictionary = new Dictionary<int, int>() {{1, 1}},
    InstantRespondersDictionary = new Dictionary<int, int>() {{1, 1}}
});
```
