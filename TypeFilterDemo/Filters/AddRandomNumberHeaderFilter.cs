using System;
using Microsoft.AspNetCore.Mvc.Filters;
using TypeFilterDemo.Services;

namespace TypeFilterDemo.Filters
{
    public class AddRandomNumberHeaderFilter : IResultFilter
    {
        private readonly IRandomNumberService _randomNumberService;

        public AddRandomNumberHeaderFilter(IRandomNumberService randomNumberService)
        {
            _randomNumberService = randomNumberService;
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("X_Random_Number_2", _randomNumberService.GetRandomInteger().ToString());
        }
    }
}
