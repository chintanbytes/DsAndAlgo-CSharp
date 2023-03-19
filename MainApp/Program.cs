
using TestLib;

namespace MainApp;
public class Program{
    static void Main(string[] args) {

        var myClass = new MyClass();
        myClass.MyMethod(1, "Chintan", DateTime.Now);    

        Console.WriteLine($"{myClass.MyStringMember}, you passed {myClass.MyIntMember} at {myClass.MyDateTimeMember}");
    }
}
    