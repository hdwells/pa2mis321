using System;
namespace pa2mis321
{
    public class Player
    {
        public void GetPlayersName()
        {
            System.Console.WriteLine("What is player 1 name?");
            string player1 = Console.ReadLine();

            System.Console.WriteLine("what is player 2 Name?");
            string player2 = Console.ReadLine();

            GetPlayerCharacter();
        }

        public void GetPlayerCharacter()
        {
            System.Console.WriteLine("Player 1 choose your character: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            string player1Char = Console.ReadLine();

            System.Console.WriteLine("Player 2 choose your character: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            string player2Char = Console.ReadLine();
        }
    }
}