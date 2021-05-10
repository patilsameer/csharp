using System;
class fourth{

    public String  Id{get;set;}
    private static int age;
    public static int Propageg{
        set{age=value;}
        get{return age;}
    }
    public static void Main(string[] args)
    {
        var i=1;
        //i=1;
        var j=i;
        String msg="sameer";
        var o=new {Id=j,Name=msg};
        Console.WriteLine(i);
        Console.WriteLine(o.Id);
        Console.WriteLine(o.Name);
        fourth.Propageg=18;
        Console.WriteLine(fourth.Propageg);
    }

}