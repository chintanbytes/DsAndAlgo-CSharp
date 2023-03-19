namespace TestLib;

public class MyClass
{ 
    private int myIntMember;
    private String myStringMember;
    public String MyStringMember {get=>myStringMember; private set => myStringMember = value;}
    public int MyIntMember { get => myIntMember; private set => myIntMember = value; }
    public DateTime MyDateTimeMember {get; private set;}
    public void MyMethod(int intMember, String stringMember, DateTime dateTimeMember){

     this.MyIntMember = intMember;
     this.MyStringMember = stringMember;
     this.MyDateTimeMember = dateTimeMember;

    }
}
