using System;
using CLTeam.Backend;
using CLTeam.ConsoleUI;
using CLTeam.WebUI;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CLTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 1 to run in console mode");
                Console.WriteLine("Press 2 to run in web mode");
                Console.WriteLine("Press 3 to exit");
                var mode = Console.ReadLine();
                if (mode == "1")
                {
                    var manager = new CLTeamManager();
                    var consoleLoop = new MainLoop(manager);
                    consoleLoop.Run();
                }
                else if (mode == "2")
                {
                    CreateWebHostBuilder(args).Build().Run();
                }
                else if (mode == "3")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Bad mode selected");
                }
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:5555");
    }
}