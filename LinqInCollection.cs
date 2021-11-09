using System;
using System.Collections.Generic;
using System.Linq;

class LinqInCollection
{
  static void Main()
  {
     List<string> names = new List<string>()
     {
       "Ajay",
       "Deepak",
       "Sagar",
       "Madhu",
       "Mukesh"
     };

     var list = names.Select(x=>x);
     foreach(string temp in list)
     {
       Console.WriteLine(temp);
     }

    //  var name = names.Where(x=>x=="Deepak");
    //  foreach(string temp in name)
    //  {
    //    Console.WriteLine(temp);
    //  }
      
       var name = names.First(x=>x.Contains("Deepak"));
       Console.WriteLine(name);

       name = names.FirstOrDefault(x=>x=="Deepak1");
       Console.WriteLine(name);
  }
}