using System;
public class Second{

    public static void Main(string[]args)
    {
        Console.WriteLine("Enter a number");
        String no=Console.ReadLine();
        int k;
        bool result=int.TryParse(no,out k);
        //int k=int.Parse(no);
        Console.WriteLine(result);
        Console.WriteLine(k);
    }
}