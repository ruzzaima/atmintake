using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Web
{

    public class AtmAuthorize : AuthorizeAttribute
    {

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var isAuthorized = base.AuthorizeCore(httpContext);
            if (!isAuthorized)
            {
                return false;
            }

            var user = ObjectBuilder.GetObject<ILoginUserPersistance>("LoginUserPersistance").GetByUserName(httpContext.User.Identity.Name);
            if (null != user)
            {
                var roles = ObjectBuilder.GetObject<IRoleProvider>("RoleProvider").GetRoles(user.UserId);
                if (!string.IsNullOrWhiteSpace(roles))
                {
                    if (Roles.Contains(roles))
                        return true;
                }

            }
            return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new
                            {
                                controller = "Base",
                                action = "Unauthorised"
                            })
                        );
        }
    }
}