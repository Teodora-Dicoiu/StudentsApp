using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Middleware
{
    public static  class ApiKeyValidatorExtension
    {
        public static IApplicationBuilder UseApiKeyValidatorMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApiKeyValidatorMiddleware>();
        }
    }
}
