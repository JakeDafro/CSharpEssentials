using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
		
		
        string[] soda = {"Coke", "Rootbeer", "Sprite", "Pepsi", "Mountain Dew"};
        foreach (string can in soda){
			int i = 0;
			while (i < soda.Length){
            Console.WriteLine(can);
			i++;
            
            }
		}
		for (int p = 0; p <= 12; p = p + 3){
                Console.WriteLine(p);
        }
    }    
}