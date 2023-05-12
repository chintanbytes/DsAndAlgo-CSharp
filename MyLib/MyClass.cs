using System.Reflection;
using JetBrains.Annotations;

namespace MyLib;

//First test class to test with my applications
public class MyClass
{


    private int myIntMember;

    private String myStringMember;

    [NotNull]
    public String MyStringMember { get => myStringMember; private set => myStringMember = value; }

    [NotNull]
    public int MyIntMember { get => myIntMember; private set => myIntMember = value; }

    [NotNull]
    public DateTime MyDateTimeMember { get; private set; }

    //Public constructor
    public MyClass([NotNull] int intMember, [NotNull] String stringMember, [NotNull] DateTime dateTimeMember)
    {
        this.MyIntMember = intMember;
        this.MyStringMember = stringMember;
        this.MyDateTimeMember = dateTimeMember;
    }

    //Test method for the first class
    public void MyTestClassMethod()
    {

    }
}
