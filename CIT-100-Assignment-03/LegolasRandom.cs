using System;

public class Legolas
{
	public static void Main()
	{

//		int cycle = 0;
		Random rnd = new Random();
		int bad = rnd.Next(10, 50);
		
		Console.WriteLine("Legolas is an amazing archer, who fires three arrows with sometimes impeccable accuracy! (And sometimes, not so impeccable accuracy...");	

		for(int cycle = 0; cycle < 1000; cycle++)
		{
//		Random rnd = new Random();
		int luck = rnd.Next(0,2);
     		int luck1 = rnd.Next(0, 100);
		int luck2 = rnd.Next(0, 100);
		int luck3 = rnd.Next(0, 100);
		int miss1 = rnd.Next(0, 100);
		int miss2 = rnd.Next(0, 100);
		int miss3 = rnd.Next(0, 100);
//		int bad = rnd.Next(10, 50);
		int quiver = rnd.Next(30, 60);
		int health = 100;
		int hit1 = 0;
		int hit2 = 0;
		int hit3 = 0;
		int kills = 0;
		int quiverb = 3;
		
		if(health <= 0) // final condition if Legolas dies
		{
			Console.WriteLine("Legolas has failed us.  Darkness prevails. The world has come to an end.");
			cycle = 1000;
		}
		else if(bad <= 0) // final condition if Legolas wins
		{
			Console.WriteLine("Legolas has triumphed over the Darkness! Long live Legolas!");
			cycle = 1000;
		}
		else if(health > 0 && bad > 0) // the long running battle between Legolas and the Darkness
		{
				if(quiver >= 3)
					quiverb = 3;
					else quiverb = quiver;
				switch(quiverb)
				{		
					case 3:
					{
						if(luck1 >= miss1) // Evaluating random hit chance
							hit1 = 1;
						else hit1 = 0;
						if(luck2 >= miss2)
							hit2 = 1;
						else hit2 = 0;
						if(luck3 >= miss3)
							hit3 = 1;
						else hit3 = 0;
						kills = hit1 + hit2 + hit3; // counting up kills
						bad = bad - kills;  // subtracting kills from bad guys
						Console.WriteLine("Legolas has killed " + kills + " of the Darkness. " + bad + " remain.");
						quiver = quiver + luck - 3;
						Console.WriteLine("Legolas's luck has granted him " + luck + " more arrows");
						health = health - bad/2;
						Console.WriteLine("The darkness has struck Legolas for " + bad/2 + " damage");
						Console.WriteLine("Legolas's health is " + health);
					break;
					}
					case 2:
					{
						if(luck1 >= miss1) // Evaluating random hit chance
							hit1 = 1;
						else hit1 = 0;
						if(luck2 >= miss2)
							hit2 = 1;
						else hit2 = 0;
						kills = hit1 + hit2; // counting up kills
						bad = bad - kills;  // subtracting kills from bad guys
						Console.WriteLine("Legolas has killed " + kills + " of the Darkness. " + bad + " remain.");
						quiver = quiver + luck - 2;
						Console.WriteLine("Legolas's luck has granted him " + luck + " more arrows");
						health = health - bad/2;
						Console.WriteLine("The darkness has struck Legolas for " + bad/2 + " damage");
						Console.WriteLine("Legolas's health is " + health);
					break;
					}
					case 1:
					{
						if(luck1 >= miss1) // Evaluating random hit chance
							hit1 = 1;
						else hit1 = 0;
						kills = hit1; // counting up kills
						bad = bad - kills;  // subtracting kills from bad guys
						Console.WriteLine("Legolas has killed " + kills + " of the Darkness. " + bad + " remain.");
						quiver = quiver-- + luck;
						Console.WriteLine("Legolas's luck has granted him " + luck + " more arrows");
						health = health - bad/2;
						Console.WriteLine("The darkness has struck Legolas for " + bad/2 + " damage");
						Console.WriteLine("Legolas's health is " + health);
					break;
					}
					case 0:
					{
						quiver = quiver + luck;
						Console.WriteLine("Legolas's luck has granted him " + luck + " more arrows");
						health = health - bad/2;
						Console.WriteLine("The darkness has struck Legolas for " + bad/2 + " damage");
						Console.WriteLine("Legolas's health is " + health);
						
					break;
					}
				}				
			}
		}
	}
}