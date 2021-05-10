using System;
class first{

    public static void Main(string[] args){
            int k;
            Console.WriteLine("This is first c# program");
            Console.WriteLine("Enter number");
            string msg=Console.ReadLine();
            bool information=int.TryParse(msg,out k);
            Console.WriteLine(information);
            int i=Console.Read();
            Console.WriteLine(i);
    }

}