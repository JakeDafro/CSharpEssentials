using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("The highest rated soda is:");
		Compare();	
		Switcher();
	
	}
	public void Compare() {
		int sodaRankSprite = 22;
		int sodaRankCoke = 26;
		int sodaRankRootBeer = 37;
	if (sodaRankSprite > sodaRankCoke && sodaRankSprite > sodaRankRootBeer)
			Console.WriteLine("Sprite");
		else if (sodaRankCoke > sodaRankRootBeer)
			Console.WriteLine("Coke");
		else 
			Console.WriteLine("RootBeer");
	}
	public void Switcher() {
	int soda = 2;
      switch (soda) 
      {
        case 1:
          Console.WriteLine("Sprite");
          break;
        case 2:
          Console.WriteLine("Coke");
          break;
        case 3:
          Console.WriteLine("RootBeer");
          break;
        
      }    
	}
}
