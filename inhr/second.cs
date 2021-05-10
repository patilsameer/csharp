using System;

class A{
    public A()
    {
        Console.WriteLine("default Constructor of A");
    }
}

interface B{
    void data();
    void b_data2();
}

interface C{
    void data2();
}

class D:A,B,C{
    public void data2()
    {
        Console.WriteLine("this is data2 method");
    }
    public void data(){
        Console.WriteLine("This is data method");
    }
    public D()
    {
        Console.WriteLine("default Constructor of D");
    }
}


class Demo{
    public static void Main(string[] args)
    {
            D obj=new D();
            obj.data();
            obj.data2();
    }
}