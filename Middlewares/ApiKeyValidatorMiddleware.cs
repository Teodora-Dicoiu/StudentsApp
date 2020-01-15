using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Middleware
{
    public class ApiKeyValidatorMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        private readonly IConfiguration configuration;

        public ApiKeyValidatorMiddleware(RequestDelegate next, IConfiguration _configuration)
        {
            this.requestDelegate = next;
            this.configuration = _configuration;
        }


        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Headers.Keys.Contains("x-api-key"))
            {
                if (this.configuration.GetValue<string>("ApiKey") != httpContext.Request.Headers["x-api-key"].ToString())
                {
                    httpContext.Response.StatusCode = 403;
                    await httpContext.Response.WriteAsync("Invalid API Key");
                }
            }
            await requestDelegate(httpContext);
        }
    }
}
