# ClaimsValueProvider

The claims value provider allows binding a controller parameter to a claim that is associated with the current user, such a user ID, name, or email

## Usage

#### Controller

In a controller action, use the FromClaim attribute, along with a claim type, to bind the parameter

```csharp
public class MyController : Controller
{
    [HttpGet("")]
    public IActionResult Get(
        [FromClaim(ClaimTypes.NameIdentifier)]Guid userId, 
        [FromClaim(ClaimTypes.Email)]string email)
    {
        ...
    }
}
```
