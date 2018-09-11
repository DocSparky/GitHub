using System;

public class Battle
{
	public static void Main()
	{
		Random rnd = new Random();
		int enemy_initial = rnd.Next(100, 200);	// Random number of enemies
		int enemy_current = enemy_initial;		// Sets the enemy counter to initial number of enemies
		int healthLegolas = 100;				//	Initial Health, Legolas
		int healthGimli = 100;					//	Initial Health, Gimli
		int killsLegolas = 0;					//	Defining initial kill count for Legolas
		int killsGimli = 0;						//	Defining initial kill count for Gimli
		Console.WriteLine("Legolas is a formidable archer with a magical quiver.  He can fire a random number of up to five arrows in a round, with perfect accuracy, and his quiver always replinishes.");	
		Console.WriteLine("Gimli is a wild bezerker, he can swing his ax very quickly, but he doesn't always hit his mark.");
		Console.WriteLine();
		
		for (int cycle = 0; cycle < 1000; cycle++)	{
			int rnd_arrows = rnd.Next(5);					// Sets a random number 0-4 for number of arrows able to be fired
			int	rnd_swings = rnd.Next(10);					// Sets a random number 0-9 for number of axe swings available
			int arrows_current_round;
		
			if (healthLegolas <= 0 && healthGimli <= 0)	{	// Losing condition if both die and output
				Console.WriteLine("Our champions have failed us.  Darkness prevails. The world has come to an end.");
				cycle = 1000;
			}
			else if (enemy_current <= 0)	{				// Winning conditions and output
				Console.WriteLine("Our heros have triumphed over the Darkness! Long live New Zealand!");
					if(killsLegolas > killsGimli){
						Console.WriteLine("Legolas was the better warrior!");		
					}
						else if (killsLegolas < killsGimli){
							Console.WriteLine("Gimli was the better warrior!");
						}
						else {
							Console.WriteLine("Our heroes tied in this battle, they must find a new battle to see who is the better warrior."); // Final outcome (3) - tie
						}

				
				
				
				
				cycle = 1000;										// ends the loop if the enemies are dead
			}
			
			
			else	{														// the long running battle between Legolas and Gimli (and the darkness too...)

				
				
// Legolas's turn
				if (enemy_current <= rnd_arrows)							// At 100% accuracy, Legolas cannot fire more arrows than enemies
					arrows_current_round = enemy_current;					// If Legolas has more arrows available than enemies, he'll only shoot as many as the quantity of enemies
				else arrows_current_round = rnd_arrows;						// otherwise, he'll use all that he has
				if (arrows_current_round != 0)	{							// if no arrows, no output for Legolas
					for (int n = 1; n <= arrows_current_round; n++) { 		// Legolas always hits, so each arrow bumps Legolas's kill counter
							killsLegolas++;
						}
					enemy_current = enemy_initial - killsLegolas - killsLegolas + rnd.Next(0,3);	// quantity of enemies = start - kills + small random number joining
					Console.WriteLine("Legolas fires " + arrows_current_round + " arrows.");		// Output how many arrows Legolas fires
				}
				else	// No arrows to fire.
					Console.WriteLine("Legolas rolled a zero and did not fire an arrow");			//	Bad luck outcome!

				
					
//	Gimli's turn								
						for (int n = 0; n <= rnd_swings; n++)	{			// Loop to check how many hits Gimli gets with 70% hit chance:
							if (rnd.Next(0, 100) >= 50){						// check if swing hit
								killsGimli++;								// increment Gimli's kill counter if he does					}
								Console.WriteLine("Gimli gets a hit");
							}
							else
								Console.WriteLine("Gimli swung and missed");
						}
//						Console.WriteLine("Gimli swings his axe " + rnd_swings + " times.");
					enemy_current = enemy_initial - killsLegolas - killsGimli;	// quantity of enemies = start - kills

					Console.WriteLine("Legolas's kill count is now at " + killsLegolas + "!");	// display Legolas's kill count
					Console.WriteLine("Gimli's kill count is now at " + killsGimli + "!");		// displays Gimli's kill count
					Console.WriteLine();
				
				
// Logic Tree to see who is in the lead				
					if(killsLegolas > killsGimli){	
						Console.WriteLine("Legolas is in the lead!");
					}
						else if (killsLegolas < killsGimli){
							Console.WriteLine("Gimli is in the lead!");
						}
						else {
							Console.WriteLine("Our heroes are tied.");
						}
				
//	Damage to heroes => Heroes' health				
					int damage = rnd.Next(0,5);				// randomizes damage to deal to Legolas
					healthLegolas = healthLegolas - damage;	// calculates Legloas's current health
					damage = rnd.Next(0,5);					// randomizes damage to deal to Gimli
					healthGimli = healthGimli - damage;		// calculates Gimli's current health
					Console.WriteLine("Health Legolas: " + healthLegolas + " Gimli: " + healthGimli); // tells the heroes' health

				
//	Checking number of enemies				
				if (enemy_current < 0)						// make sure there isn't a negative number of enemies.
						enemy_current = 0;
	
//	Readability
				Console.WriteLine();
			}
		}
	}
}