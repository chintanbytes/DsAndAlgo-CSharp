
using TestLib;
using log4net;
using JetBrains.Annotations;

namespace MainApp;
public class Program{
    
    [NotNull]
    private static readonly ILog log = LogManager.GetLogger(typeof(MyClass));

    static void Main(string[] args) {

        log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

        var myClass = new MyClass();
        myClass.MyMethod(1, "Chintan", DateTime.Now);    
        Console.WriteLine($"{myClass.MyStringMember}, you passed {myClass.MyIntMember} at {myClass.MyDateTimeMember}");
        log.Info("This is info message");
        log.Warn("This is warning message");
        log.Error("This is error message");
    }
}
    