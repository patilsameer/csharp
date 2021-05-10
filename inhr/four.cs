public class A{
    internal int i;
}

public class B{
    public void data()
    {
        A obj=new A();
        obj.i=22;
        System.Console.WriteLine(obj.i);

        five_A ob=new five_A();
        ob.j=22;
        System.Console.WriteLine(ob.j);
    }
}
public class four{
    public static void Main(string[] args)
    {
        B obj=new B();
        obj.data();
    }
}