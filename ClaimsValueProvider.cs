using System.Globalization;
using System.Security.Claims;
using System.Web.Http.ValueProviders;

namespace ClaimsValueProvider
{
    public class ClaimsValueProvider : IValueProvider
    {
        private readonly ClaimsPrincipal _user;

        public ClaimsValueProvider(ClaimsPrincipal user)
        {
            _user = user;
        }

        public bool ContainsPrefix(string prefix)
        {
            return _user.HasClaim(claim => claim.Type == prefix);
        }

        public ValueProviderResult GetValue(string key)
        {
            var claim = _user.FindFirst(key);

            return new ValueProviderResult(claim?.Value, claim?.Value, CultureInfo.InvariantCulture);
        }
    }
}