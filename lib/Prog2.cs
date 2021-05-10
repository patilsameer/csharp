using System;
public class Prog2{
    public static void Main(string[] args)
    {
        Console.WriteLine("The Prog2 Program is loaded .");
        Math1 obj=new Math1();
        int i1=10;
        int i2=5;
        int result=obj.add(i1,i2);
        Console.WriteLine(result);
        Console.WriteLine(obj.sub(i1,i2));
    }
}