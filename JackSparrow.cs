using System;
using mis321_pa2_wjgracee.Interfaces;
namespace mis321_pa2_wjgracee
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            attackbehavior = new DistractAttack();
        }

        // public void ChooseAttack()
        // {
        //     System.Console.WriteLine("Please choose your attack");
        //     System.Console.WriteLine("\n1. Distract \n2. Kick \n3. Punch");
        //     int userChoice = int.Parse(Console.ReadLine());
        //     switch (userChoice)
        //     {
        //         case 1:
        //     }
        // }
    }
}