
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

        // //Load log4net configuration
        log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

        var List = new LinkedList();
        List.TakeInputAndAddToTail();
        List.Print();

        var NewList = new LinkedList();
        NewList.TakeInputAndAddToHead();
        NewList.Print();

        List.DeleteIth(1);
        List.Print();
        NewList.DeleteIth(1);
        NewList.Print();

    }
}