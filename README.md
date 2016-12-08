# Unofficial ActiveCampaign C# Wrapper
C# Wrapper for the ActiveCampaign API

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
```
