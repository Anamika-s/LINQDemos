using System;
using System.Linq;

namespace LinqDemo
{
    class MethodSyntaxDemo
    {
        static void Main(string[] args)
        {
           int[] num = new  [] {1,2,3,4,5,6,7,8,9,10};
            // Query Syntax

             // Select * from table where 
            var list  =  num.Select(x=>x);
             foreach(int x in list)
             {
                 Console.WriteLine(x);
             }
            var evenList  = num.Where(x=>x%2==0);  
             Console.WriteLine("Even Numbers");
             foreach(int x in evenList)
             {
                 Console.WriteLine(x);
             }
            var oddList  =   num.Where(x=>x%2!=0);
             Console.WriteLine("odd Numbers");
             foreach(int x in oddList)
             {
                 Console.WriteLine(x);
             }
           var sum =  num.Select(x=>x).Sum();

           Console.WriteLine("Sum is " + sum);
           var avg = num.Select(x=>x).Average();

           Console.WriteLine("Average is " + avg);
           
        }
    }
}
