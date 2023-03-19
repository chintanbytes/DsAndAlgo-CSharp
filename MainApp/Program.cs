
using MyLib;
using log4net;
using JetBrains.Annotations;

namespace MainApp;
public class Program
{
    //Get logger
    [NotNull]
    private static readonly ILog log = LogManager.GetLogger(typeof(Program));

    //Main entry point of the application
    static void Main(string[] args)
    {

        //Load log4net configuration
        log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

        var myClassInstance = new MyClass(1, "Chintan", DateTime.Now);
        myClassInstance.MyTestClassMethod();

        //Output to console
        Console.WriteLine($"{myClassInstance.MyStringMember}, you passed {myClassInstance.MyIntMember} at {myClassInstance.MyDateTimeMember}");

        //Testing various log messages with different log levels
        log.Info("This is info message");
        log.Warn("This is warning message");
        log.Error("This is error message");
    }
}