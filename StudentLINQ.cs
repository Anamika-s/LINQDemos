using System;
using System.Collections.Generic;
using System.Linq;

class StudentLINQ
{
  static void Main()
  {
    List <Student> studentsList = new   List<Student>()
    {
       new Student() { StudentID=1,StudentName="Ajay", Age=19},
       new Student() { StudentID=2,StudentName="Deepak", Age=39},
       new Student() { StudentID=3,StudentName="Sagar", Age=23},
       new Student() { StudentID=4,StudentName="Vijay", Age=17},
       new Student() { StudentID=5,StudentName="Rupesh", Age=19},
       new Student() { StudentID=6,StudentName="Geeta", Age=19},
       
    };

    // var list = (from x in studentsList
    // select x);

    // foreach(var temp in list)
    // {
    //    Console.WriteLine(temp.StudentID + " " + temp.StudentName + " " + temp.Age);
    // }

    var list =   studentsList.Select(x=>x);

    foreach(var temp in list)
    {
       Console.WriteLine(temp.StudentID + " " + temp.StudentName + " " + temp.Age);
    }
    Console.WriteLine("ID more thaa 3");
          list = (from x in studentsList
         where x.StudentID > 3
          select x);
    foreach(var temp in list)
    {
       Console.WriteLine(temp.StudentID + " " + temp.StudentName + " " + temp.Age);
    } 


    Console.WriteLine("ID more thaa 3");
          list =  
    foreach(var temp in list)
    {studentsList.Where(x=>x.StudentID>3);
       Console.WriteLine(temp.StudentID + " " + temp.StudentName + " " + temp.Age);
    }
  }
}