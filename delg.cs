using System;
class Demo{
    delegate void d();
    public static void Main(string[] args){
        Demo o=new Demo();
        d obj=o.data;
        obj();
        System.Console.Read();  
        obj.BeginInvoke(d2,obj);
        Console.Read();
        obj();
        Console.Read();
    }

    public static void d2(IAsyncResult ar){
        
            Console.WriteLine("Hello d2");
    }

    public void data(){
        System.Console.WriteLine("this is data method");
    }
}