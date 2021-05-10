using System;
public class Demo{
    
    public static void Main(string[] args)
    {
            int [] a=new int[2]{1,2};
    
            int[,] multi=new int[2,2]{{1,2},{3,4}};
    
            int[][] arr=new int[4][];
            arr[0]=new int[2]{1,2};
            arr[1]=new int[3]{3,4,5};
            arr[2]=new int[5]{6,7,8,0,0};
            arr[3]=new int[2]{9,0};

            foreach(int index in a){
                index=222;
                Console.Write(index);
            }
            Console.Write("\n");
            foreach(int i in multi){
                Console.Write(i);
            }
            Console.Write("\n");
            foreach(int[] k in arr){
                    foreach(int j in k){
                        Console.Write(j);
                    }
                    Console.Write("\n");
                    
            }
            
            /*  for(int i=0;i<2;i++){
               Console.WriteLine(a[i]);
            }            
            */
            
           /* for(int i=0;i<arr.Length;i++)
            {
                for(int k=0;k<arr[i].Length;k++)
                {
                    Console.Write(arr[i][k]);
                }
                    Console.WriteLine("");
            }
            */

            /*
            for(int i=0;i<3;i++){
                for(int k=0;k<2;k++){
                    Console.WriteLine(multi[i,k]);
                }
            }
            */

    }
}