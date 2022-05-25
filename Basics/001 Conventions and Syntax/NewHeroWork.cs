//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

using System;
					
public class Program
{
    public Hero heroOne;
    public Hero heroTwo;
	public Hero heroThree;
    public void Main()
    {
        heroOne = new Hero();
        heroTwo = new Hero();
		heroThree = new Hero();

        heroOne.health = 2;
        heroOne.powerLevel = 5;
		
        heroTwo.health = 3;
        heroTwo.powerLevel = 1;

        heroThree.health = 4;
        heroThree.powerLevel = 8;
		
        Console.WriteLine(heroOne.health);
        Console.WriteLine(heroOne.powerLevel);
		
        Console.WriteLine(heroTwo.health);
        Console.WriteLine(heroTwo.powerLevel);

        Console.WriteLine(heroThree.health);
        Console.WriteLine(heroThree.powerLevel);
    }
}

public class Hero {
    public int health;
    public int powerLevel;
}//Based on the HelloWorld File, turn this into a class.