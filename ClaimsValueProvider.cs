using System.Globalization;
using System.Security.Claims;
using System.Web.Http.ValueProviders;

namespace ClaimsValueProvider
{
    /// <summary>
    /// An <see cref="IValueProvider"/> adapter for data stored in a claim
    /// </summary>
    public class ClaimsValueProvider : IValueProvider
    {
        private readonly ClaimsPrincipal _user;

        /// <param name="user">The <see cref="ClaimsPrincipal" /> to wrap.</param>
        public ClaimsValueProvider(ClaimsPrincipal user)
        {
            _user = user;
        }

        /// <inheritdoc />
        public bool ContainsPrefix(string prefix)
        {
            return _user.HasClaim(claim => claim.Type == prefix);
        }

        /// <inheritdoc />
        public ValueProviderResult GetValue(string key)
        {
            var claim = _user.FindFirst(key);

            return new ValueProviderResult(claim?.Value, claim?.Value, CultureInfo.InvariantCulture);
        }
    }
}