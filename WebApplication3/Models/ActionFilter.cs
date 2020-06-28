using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Routing;

namespace WebApplication3.Models
{
    public class ActionFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //AuthorizationService _authorizeService = new AuthorizationService();
            string userId = HttpContext.Current.User.Identity.GetUserId();
            if (userId != null)
            {
                //var result = _authorizeService.CanManageUser(userId);
                var result = "";

                if (!result)
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary{{ "controller", "Account" },
                                          { "action", "Login" }

                                         });
                }
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary{{ "controller", "Account" },
                                          { "action", "Login" }

                                         });

            }
            base.OnActionExecuting(filterContext);
        }

    }
}