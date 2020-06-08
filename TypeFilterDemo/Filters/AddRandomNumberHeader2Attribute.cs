using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TypeFilterDemo.Services;

namespace TypeFilterDemo.Filters
{
    public class AddRandomNumberHeader2Attribute : TypeFilterAttribute
    {
        public AddRandomNumberHeader2Attribute() : base(typeof(AddRandomNumberHeader2Filter))
        {
        }

        private class AddRandomNumberHeader2Filter : IResultFilter
        {
            private readonly IRandomNumberService _randomNumberService;

            public AddRandomNumberHeader2Filter(IRandomNumberService randomNumberService)
            {
                _randomNumberService = randomNumberService;
            }

            public void OnResultExecuted(ResultExecutedContext context)
            {
                throw new NotImplementedException();
            }

            public void OnResultExecuting(ResultExecutingContext context)
            {
                context.HttpContext.Response.Headers.Add("X_Random_Number_3", _randomNumberService.GetRandomInteger().ToString());
            }
        }
    }
}
