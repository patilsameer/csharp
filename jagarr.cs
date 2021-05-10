using System;
public class Jag{
    public static void Main(string[] args)
    {
        int[,] twoarr=new int[2,2]{{1,2},{3,4}};
        int[][] ar=new int[3][];
        ar[0]=new int[3]{1,2,3};
        ar[1]=new int[1]{4};
        ar[2]=new int[6]{5,6,7,8,9,0};

        foreach(int i in twoarr){
            System.Console.WriteLine(i);
        }

        for(int i=0;i<ar.Length;i++)
        {
            for(int k=0;k<ar[i].Length;k++)
            {
                System.Console.Write(ar[i][k]);
            }
            System.Console.WriteLine("");
        }
    }
}