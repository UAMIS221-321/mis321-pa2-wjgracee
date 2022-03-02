using System;
using mis321_pa2_wjgracee.Interfaces;
namespace mis321_pa2_wjgracee
{
    public class Character
    {
        public IAttack attackbehavior{get;set;}
        public string UserName{get;set;}
        public double Health{get;set;}
        public double AttackStrength{get;set;}
        public int MaxPower{get;set;}
        public double DefensePower{get;set;}
        public string CharacterName{get;set;}
        public double DamageDealt{get;set;}

        public Character()
        {
            
        }

        public string GetUserName() //generates user name 
        {
            System.Console.WriteLine("Please enter the name of the user playing");
            UserName = Console.ReadLine();
            return UserName;
        }

        public int GetMaxPower() //generates max power 
        {
             Random newRandom = new Random();
             int MaxPower = newRandom.Next(1,100);
            System.Console.WriteLine($"Your max power for the game is: {MaxPower}");
            return MaxPower;
        }

        public int GetAttackStrength(int maxPower) //random attack strength according to max power 
        { 
            Random newRandom = new Random();
            int AttackStrength = newRandom.Next(1,maxPower);
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"Your max attack strength is {AttackStrength}");
            return AttackStrength;
        }

         public int GetDefenseStrength(int maxPower) //random defense strength according to max power
        {
            Random newRandom = new Random();
            int DefensePower = newRandom.Next(1,maxPower);
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"Your max defense strength is {DefensePower}");
            return DefensePower;
        }

        public void StatsOne(Character playerOne, Character playerTwo) //stats
        {
            System.Console.WriteLine($"\n{playerOne.UserName} attacked {playerTwo.UserName}\n");
            System.Console.WriteLine($"\nStats: UserName: {playerOne.UserName}\nCharacter Name: {playerOne.CharacterName}\nHealth: {playerOne.Health} \nAttack Strength: {playerOne.AttackStrength} \nDefend Power: {playerOne.DefensePower}\nDamage Done: {playerOne.DamageDealt}");
            System.Console.WriteLine("---------------------------------------------------------------------------------");
            System.Console.WriteLine($"\nStats: UserName: {playerTwo.UserName}\nCharacter Name {playerTwo.CharacterName}\nHealth: {playerTwo.Health} \nAttack Strength: {playerTwo.AttackStrength} \nDefend Power: {playerTwo.DefensePower}\nDamage Done: {playerTwo.DamageDealt}");
        }

        public void StatsTwo(Character playerOne, Character playerTwo) //stats
        {
            System.Console.WriteLine($"\n{playerTwo.UserName} attacked {playerOne.UserName}\n");
            System.Console.WriteLine($"\nStats: UserName: {playerTwo.UserName} \nCharacter Name {playerTwo.CharacterName} \nHealth: {playerTwo.Health} \nAttack Strength: {playerTwo.AttackStrength} \nDefend Power: {playerTwo.DefensePower}\nDamage Done: {playerTwo.DamageDealt}");
            System.Console.WriteLine("---------------------------------------------------------------------------------");
            System.Console.WriteLine($"\nStats: UserName: {playerOne.UserName} \nCharacter Name {playerOne.CharacterName} \nHealth: {playerOne.Health} \nAttack Strength: {playerOne.AttackStrength} \nDefend Power: {playerOne.DefensePower}\nDamage Done {playerOne.DamageDealt}");
        }

    }
}