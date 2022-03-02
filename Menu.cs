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
            while(userChoice != 1 && userChoice != 2 && userChoice != 3) // error check
            {
                System.Console.WriteLine("Invalid choice.");
                System.Console.WriteLine("Please choose your character");
                System.Console.WriteLine("\n1.Jack Sparrow \n2. Will Turner \n3. Davy Jones");
                userChoice = int.Parse(Console.ReadLine()); // update read 
            }
            return userChoice; // returns user choice
        }

        
    }

}