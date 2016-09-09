using System.Security.Claims;
using System.Web.Http.Controllers;
using System.Web.Http.ValueProviders;

namespace ClaimsValueProvider
{
    /// <summary>
    /// A <see cref="ValueProviderFactory"/> that creates <see cref="IValueProvider"/> instances that read values from claims
    /// </summary>
    public class ClaimsValueProviderFactory : ValueProviderFactory
    {
        /// <inheritoc />
        public override IValueProvider GetValueProvider(HttpActionContext actionContext)
        {
            var user = actionContext.ControllerContext.RequestContext.Principal as ClaimsPrincipal;

            return new ClaimsValueProvider(user);
        }
    }
}