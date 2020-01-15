using Microsoft.AspNetCore.Mvc.Filters;
using StudentsAPI.Models;
using StudentsAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Filters
{
    public class EventsFilter : IResultFilter
    {
        private readonly IRequestService requestService;
        public void OnResultExecuted(ResultExecutedContext context)
        {
             List<Request> requests = new List<Request>();
            Request request = new Request(context.Result.ToString(), context.RouteData.ToString(), context.HttpContext.ToString());
            requestService.Add(request);
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            
        }
    }
}
 