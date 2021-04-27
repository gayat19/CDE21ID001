using FirstCoreApplication.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options=>
            {
                options.EnableEndpointRouting = false;
            });
            services.AddSingleton<HomeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string Data = "";
            if (env.IsDevelopment())
            {
                Data = "This is development";
                app.UseDeveloperExceptionPage();
            }
            else if(env.IsProduction())
            {
                Data = "We have rolled out. We are live and ticking....";
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(route=>
            {
                route.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{Action=Index}/{id?}"
                    );
            });
            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World! " + Data);
            //    });
            //});
        }
    }
}
