using  System;
using System.Threading;
class Demo{
    
    delegate void dg();

    delegate void dg2(int a);


    public void data3(int k){
        Console.WriteLine("this is data3 {0}",k);        
    }
    
    public static void Main(string[] args)
    {
        
        Demo obj=new Demo();
        dg2 temp4=obj.data3;
        temp4.BeginInvoke(11,null,null);

        dg temp=obj.data;
        //temp();
        temp.BeginInvoke(data2,temp);
        Console.WriteLine("this is main method");
        Console.Read();
            
    }

    public void data(){
        //Console.Read();
        Console.WriteLine(" this is data method");
         
    }
    public static void data2(IAsyncResult ar){
        Console.WriteLine("this is data2");   
    }
}