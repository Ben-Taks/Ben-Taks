using BlazorChatApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BlazorChatAppServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
#pragma warning disable CS0246 // The type or namespace name 'Startup' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'Startup' could not be found (are you missing a using directive or an assembly reference?)
                    webBuilder.UseStartup<Startup>();
#pragma warning restore CS0246 // The type or namespace name 'Startup' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'Startup' could not be found (are you missing a using directive or an assembly reference?)
                });
    }
}
