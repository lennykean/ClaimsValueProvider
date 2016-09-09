using System.Security.Claims;
using System.Web.Http.Controllers;
using System.Web.Http.ValueProviders;

namespace ClaimsValueProvider
{
    public class ClaimsValueProviderFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(HttpActionContext actionContext)
        {
            var user = actionContext.ControllerContext.RequestContext.Principal as ClaimsPrincipal;

            return new ClaimsValueProvider(user);
        }
    }
}