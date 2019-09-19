using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using student_app.Models;
using Microsoft.EntityFrameworkCore;

namespace student_app
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DatabaseContext>(options =>
                  
                    options.UseNpgsql(
            "Host=ec2-54-83-9-36.compute-1.amazonaws.com;" +
            "Database=d1tu8c5ppao6f2;Username=yzmxpthfwuyfnj;"+
            "Password=8e7debf56bf9689a87ba545f57d711b4f8b8f8969d831c3796532443d053aa57;"+
            "Port=5432;SSL Mode=Require;Trust Server Certificate=true")
                  );            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles(); // For the wwwroot folder
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/

            app.UseMvc(routes => {

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
