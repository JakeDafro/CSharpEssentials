using System;

namespace MyApplication
{
  class Program
  {

  
    static void Main(string[] args)
    
    {
      if (1 > 2) 
      {
        Console.WriteLine("The first man is stronger than the second.");
      } 
      else if (2 > 3)
      {
      Console.WriteLine("The second man is stronger than the first and the third.");
      }
      else
      {
      Console.WriteLine("The third man is the strongest.");
      }
      
        int talk = 3;
      switch (talk) 
      {
        case 1:
          Console.WriteLine("O'Brian");
          break;
        case 2:
          Console.WriteLine("Kimmel");
          break;
        case 3:
          Console.WriteLine("Fallon");
          break;
        
      }    
    }
  }
}
