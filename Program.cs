using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] num = new  [] {1,2,3,4,5,6,7,8,9,10};
            // Query Syntax

             // Select * from table where 
            var list  =  (from x in num
             select x);
             foreach(int x in list)
             {
                 Console.WriteLine(x);
             }
            var evenList  =  (from x in num
            where x%2==0
             select x);
             Console.WriteLine("Even Numbers");
             foreach(int x in evenList)
             {
                 Console.WriteLine(x);
             }
            var oddList  =  (from x in num
            where x%2!=0
             select x);
             Console.WriteLine("odd Numbers");
             foreach(int x in oddList)
             {
                 Console.WriteLine(x);
             }
           var sum = (from x in num
           select x).Sum();

           Console.WriteLine("Sum is " + sum);
           var avg = (from x in num
           select x).Average();

           Console.WriteLine("Average is " + avg);
           
        }
    }
}
