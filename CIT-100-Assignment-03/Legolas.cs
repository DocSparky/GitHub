using System;


public class Legolas
{
	public static void Second()
	{
		
		int arrowsheld = 3;
		int enemies = 3;
		
		for(int j = 1; j <= arrowsheld; j++) // incrementing cycle J
		{
			if(enemies == 1)
			{	
				Console.WriteLine("There is only " + enemies + " enemy remaining!");
			}
			else
			{
				Console.WriteLine("There are " + enemies + " enemies remaining!");
			}
			if(arrowsheld > 0)
			{
				Console.WriteLine("Legolas fires an arrow.");
				Console.WriteLine("Legolas has hit an enemy!");
				enemies--; // decremating number of enemies
			}
			else
			{
				Console.WriteLine("Legolas has run out of arrows.");
			}
			Console.WriteLine("  ");
		}
		if(enemies == 0)
		{
			 Console.WriteLine("Legolas is lucky!  There are no more enemies.  Legolas lives!");
		}
		else
		{
			Console.WriteLine("Poor Legolas, there are still enemies.  Game Over Legolas.");
		}
		
	}