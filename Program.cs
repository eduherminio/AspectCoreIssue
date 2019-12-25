using AspectCore.Configuration;
using AspectCore.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AspectCoreIssue
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseServiceContext(container =>
                {
                    //container.Configuration.Interceptors.AddTyped<AuthorizationAttribute>();
                })
                .ConfigureDynamicProxy((services, config) =>
                {
                    config.Interceptors.AddTyped(typeof(AuthorizationAttribute));
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://localhost:1234");
                });
        }
    }
}
