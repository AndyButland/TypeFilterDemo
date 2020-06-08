using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using TypeFilterDemo.Services;

namespace TypeFilterDemo.Filters
{
    public class AddRandomNumberHeaderAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var service = context.HttpContext.RequestServices.GetService<IRandomNumberService>();
            context.HttpContext.Response.Headers.Add("X_Random_Number_1", service.GetRandomInteger().ToString());
        }
    }
}
