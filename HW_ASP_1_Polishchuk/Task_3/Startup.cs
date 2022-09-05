using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "Default",
                        pattern: "{controller}/{action}/{id?}"
                    );
            });
            //app.Map("/Test/Massage", massage =>
            //{
            //    massage.UseExceptionHandler("/Error");

            //    massage.Run(async context =>
            //    {
            //        var text = Encoding.UTF8.GetBytes("\"Hello world\"");
            //        context.Response.ContentType = "text/plain";

            //        await context.Response.Body.WriteAsync(text);
            //    });
            //});

            //app.Map("/List/Info", listInfo =>
            //{
            //    listInfo.UseExceptionHandler("/Error");

            //    listInfo.Run(async context =>
            //    {
            //        context.Response.ContentType = "text/plain";
            //        await context.Response.WriteAsync("");
            //    });

            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Start page");
            //});
        }
    }
}
