
using MyLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace MainApp;
public class Program
{
    //Main entry point of the application
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration().WriteTo.Console() // Add console sink
        .WriteTo.File("logs/app-.txt", rollingInterval: RollingInterval.Day) // Add file sink with desired log file path
        .MinimumLevel.Debug()
        .CreateLogger();

        var services = new ServiceCollection();
        services.AddLogging(builder =>
        {
            builder.AddSerilog();
        });

        services.AddTransient<LinkedList>();
        var serviceProvider = services.BuildServiceProvider();

        var log = serviceProvider.GetService<ILogger<Program>>();


        log.LogInformation("Hello World");
        log.LogError("Hello World");
        log.LogWarning("Hello World");
        log.LogDebug("Hello World");
        log.LogCritical("Hello World");


        // Resolve MyClass from the DI container
        var List = serviceProvider.GetService<LinkedList>();
        //var List = new LinkedList();
        List.TakeInputAndAddToTail();
        List.Print();

        var NewList = serviceProvider.GetService<LinkedList>();
        NewList.TakeInputAndAddToHead();
        NewList.Print();

        List.DeleteIth(1);
        List.Print();
        NewList.DeleteIth(1);
        NewList.Print();

    }
}