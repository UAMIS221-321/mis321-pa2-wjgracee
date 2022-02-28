using System;
namespace mis321_pa2_wjgracee
{
    public class Menu
    {
        public int GetCharacter()
        {
            System.Console.WriteLine("Please choose your character");
            System.Console.WriteLine("\n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            int userChoice = int.Parse(Console.ReadLine());
            while(userChoice != 1 && userChoice != 2 && userChoice != 3)
            {
                System.Console.WriteLine("Invalid choice.");
                System.Console.WriteLine("Please choose your character");
                System.Console.WriteLine("\n1.Jack Sparrow \n2. Will Turner \n3. Davy Jones");
                userChoice = int.Parse(Console.ReadLine());
            }
            return userChoice;
        }

        public int WhoGoesFirst()
        {
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1,3);
            return randomNumber;
        }

        public void GuessNumber()
        {
            System.Console.WriteLine("Please guess a number of 1 or 2 to decide who goes first");
            int.Parse(Console.ReadLine());
        }
    }

}