using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentsAPI.Filters;
using StudentsAPI.Middleware;
using StudentsAPI.Services;

namespace StudentsAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IStudentsService, StudentsService>();
            services.AddSingleton<IRequestService, RequestService>();
            services.AddControllers().AddXmlSerializerFormatters();
            services.AddScoped<EventsFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(a => a.Run(async context =>
                {
                    await context.Response.WriteAsync("Unexpected server error. Please contact admin@localhost.com.");
                }));
            }

            app.UseRouting();

            app.UseApiKeyValidatorMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
