using System;
public class A{
    public A(int a)
    {
        Console.WriteLine(a);
    }
    public A(){
        Console.WriteLine("default Constructor of A");
    }
}

public class B : A{
    public B()
    {
        Console.WriteLine("default Constructor of B");
    }
    public B(int val):base(val){

    }
}

class C : B{
    public C(){
        Console.WriteLine("default Constructor of C");
    }
}
public class first{
    public static void Main(string[] args)
    {
           // Console.WriteLine("main Method");
           // B obj=new B(22);
            C obj=new C();
    }
}