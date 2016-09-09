using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;

namespace ClaimsValueProvider
{
    public class FromClaimAttribute : ModelBinderAttribute
    {
        public FromClaimAttribute(string claimType)
        {
            Name = claimType;
        }

        public override IEnumerable<ValueProviderFactory> GetValueProviderFactories(HttpConfiguration configuration)
        {
            return new[] { new ClaimsValueProviderFactory() };
        }
    }
}