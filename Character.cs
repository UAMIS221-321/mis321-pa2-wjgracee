using System;
using mis321_pa2_wjgracee.Interfaces;
namespace mis321_pa2_wjgracee
{
    public class Character : Battle
    {
        public IAttack attackbehavior{get;set;}
        public string UserName{get;set;}
        public int Health{get;set;}
        public int AttackStrength{get;set;}
        public int MaxPower{get;set;}
        public int DefensePower{get;set;}

        public Character()
        {
            
        }

        public string GetUserName()
        {
            System.Console.WriteLine("Please enter the name of the user playing");
            UserName = Console.ReadLine();
            return UserName;
        }

        public int GetMaxPower()
        {
             Random newRandom = new Random();
             int MaxPower = newRandom.Next(1,100);
            System.Console.WriteLine($"Your max power for the game is: {MaxPower}");
            return MaxPower;
        }

        public int GetAttackStrength(int maxPower)
        {
            Random newRandom = new Random();
            int AttackStrength = newRandom.Next(1,maxPower);
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"Your max attack strength for this turn is {AttackStrength}");
            return AttackStrength;
        }

         public int GetDefenseStrength(int maxPower)
        {
            Random newRandom = new Random();
            int DefensePower = newRandom.Next(1,maxPower);
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"Your max defense strength for this turn is {DefensePower}");
            return DefensePower;
        }

        // public override string ToString(Character myCharacter)
        // {
        //     return "UserName: " + myCharacter.UserName + "       Health:" + myCharacter.Health + "      Max Power: " + myCharacter.MaxPower +"    Attack Strength:" + myCharacter.AttackStrength + "     Defense Power:" + myCharacter.DefensePower;
        // }

    }
}