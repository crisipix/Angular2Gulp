using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Angular2Gulp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        /*
            https://blogs.msdn.microsoft.com/webdev/2015/03/19/customize-external-web-tools-in-visual-studio-2015/
            //If you’re using Angular 2 with ASP.NET static file serving, you’ll have no doubt run into the fact that once you’ve navigated to 
            //a different Angular route, you can’t refresh the page. You’ll get a 404 error because the new URL no longer points to a valid file.
            //Instead we want to route all requests for Angular routes to the root page, usually index.html.Angular will then go figure out which page to load based on the URL.
            //http://benjii.me/2016/01/angular2-routing-with-asp-net-core-1/
            app.Use(async (context, next) =>
            {
                await next();

                // If there's no available file and the request doesn't contain an extension, we're probably trying to access a page.
                // Rewrite request to use app root
                if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
                {
                    //context.Request.Path = "/index.html";
                    context.Request.Path = "/wwwroot/index.html";
                    await next();
                }

                // Serve wwwroot as root
                app.UseFileServer();

                // Serve /node_modules as a separate root (for packages that use other npm modules client side)
                //app.UseFileServer(new FileServerOptions()
                //{
                //    // Set root of file server
                //    // FileProvider = new PhysicalFileProvider(Path.Combine(environment.ApplicationBasePath, "node_modules")),
                //    FileProvider = new PhysicalFileProvider(Path.Combine(environment.ApplicationBasePath, "lib")),
                //    // Only react to requests that match this path
                //    //RequestPath = "/node_modules",
                //    RequestPath = "/lib",
                //    // Don't expose file system
                //    EnableDirectoryBrowsing = false
                //});
            });

            //http://stackoverflow.com/questions/30250764/how-to-force-all-requests-in-asp-net-5-mvc-project-to-redirect-to-root
            // this will force all paths to root. IE http://localhost:65399/detail/3 turns to http://localhost:65399/
            //app.Run(async (context) =>
            //{
            //    // await context.Response.WriteAsync("Hello World!");
            //     context.Response.Redirect("/");
            //     await Task.FromResult<object>(null);
            //});
        */


        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
