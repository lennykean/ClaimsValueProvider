using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;

namespace ClaimsValueProvider
{    
    /// <summary>
    /// Specifies that a parameter or property should be bound using a claim.
    /// </summary>
    public class FromClaimAttribute : ModelBinderAttribute
    {
        /// <param name="claimType">Claim type</param>
        public FromClaimAttribute(string claimType)
        {
            Name = claimType;
        }

        /// <inheritoc />
        public override IEnumerable<ValueProviderFactory> GetValueProviderFactories(HttpConfiguration configuration)
        {
            return new[] { new ClaimsValueProviderFactory() };
        }
    }
}