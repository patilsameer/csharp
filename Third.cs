using System;
class Third{
   
    public static void data(int[] b){
        b[0]=22;
    }

    public static void Main(string[] args){
        int [] a=new int[1];
        a[0]=1;
        Third.data(a);
        System.Console.WriteLine(a[0]);
    }
}


