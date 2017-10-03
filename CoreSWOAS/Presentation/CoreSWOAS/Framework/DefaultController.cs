using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreSWOAS.Framework
{
    /// <inheritdoc />
    public abstract class DefaultController: Controller
    {
        /// <inheritdoc />
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Check your condition here
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                filterContext.Result = new EmptyResult();
            }
            else
                base.OnActionExecuting(filterContext);

        }
    }
}