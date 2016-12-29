using Loja.Domain.Commom;
using System.Web.Mvc;

namespace Loja.MVC.Controllers
{
    public class ControllerUser : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!Utils.ExisteSession("User"))
            {
                filterContext.Result = new RedirectResult("~/");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}