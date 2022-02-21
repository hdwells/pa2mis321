using System;

namespace pa2mis321
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
        }

    //NEED UMLs
        //menu driven system: 1. select character 2. attack/defend as appropriate on a rotating basis with your opponent
        //3. view the current stats of both characters in the fight at any time
            //classes for each character?
            
        //Each character: Name, maxpower, health, attack strength, defensive power
        // each character should have the ability to attack and defend - each attack varies by character


        //BASE PLAY: 
            //The character should provide stats when requested
            // max power for a character should be set to a random number (1 to 100)
            //health should start at 100 when character is instantiated
            //attack strength & defensive power should be a random number between 1 and max power for the character
            // game should be between 2 players
            //prompt each player for their name
            //randomly choose which character attacks first
            //players alternate attacks until a characters health reaches 0
            // on each attack write the power and the damage donr to the screem, then display the attacked character's stats
        
        //Characters: 
            //Jack Sparrow: distract opponent
            //Will Turner: sword
            //Davy Jones: Cannon Fire

        //Attack effectiveness varies based on the type of attack and type of attack and the type of character being attacked. 
            //Jack sparrow beats will turner, will turner beats Davy
            //Will turner beats Davy Jones, Davy Jones beats Jack Sparrow
            //These combos get a 20% boost


        public static void WelcomeMessage()
        {
        System.Console.WriteLine("\t Welcome to the Battle of Calypso Maelstrom \t");
        Console.WriteLine("*************************************************************\t");
        }

        public static void MenuRoute()
        {
            System.Console.WriteLine("menu route");
        }

    }
}
