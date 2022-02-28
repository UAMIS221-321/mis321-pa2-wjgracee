using System;
using mis321_pa2_wjgracee.Interfaces;
namespace mis321_pa2_wjgracee
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Battle of Calypso's maelstrom");
            Menu newMenu = new Menu();
            Character playerOne = new Character();
            Character playerTwo = new Character();
            playerOne = GetUserCharacter();
            System.Console.WriteLine("''''''''''''''\nPlayer two");
            playerTwo = GetUserCharacter();
            System.Console.WriteLine($"\nPlayer: {playerOne.UserName}\nCharacter: {playerOne.Health}\nMaxPower: {playerOne.MaxPower}\nHealth: {playerOne.Health}\nAttackStrength: {playerOne.AttackStrength}\nDefensivePower: {playerOne.DefensePower}");
            System.Console.WriteLine($"\nPlayer: {playerTwo.UserName}\nCharacter: {playerTwo.Health}\nMaxPower: {playerTwo.MaxPower}\nHealth: {playerTwo.Health}\nAttackStrength: {playerTwo.AttackStrength}\nDefensivePower: {playerTwo.DefensePower}");
            GamePlay(playerOne,playerTwo);
        }

        public static Character GetUserCharacter()
        {
            Character myCharacter = new Character();

            Menu newMenu = new Menu();
            int userChoice = newMenu.GetCharacter();
            switch(userChoice)
            {
                case 1: myCharacter = JackSparrowCharacter(myCharacter);
                    break;
                case 2: myCharacter = WillTurnerCharacter(myCharacter);
                    break;
                case 3: myCharacter = DavyJonesCharacter(myCharacter);
                    break;
                default: 
                    System.Console.WriteLine("Invalid choice.");
                    newMenu.GetCharacter();
                    break;
            }
            return myCharacter;
        }
        
        public static Character JackSparrowCharacter(Character myCharacter)
        {
            Menu newMenu = new Menu();
            System.Console.WriteLine("Jack Sparrow. Great Choice! \nJack Sparrow's Primary attack is to distract. Please follow the prompts given below.");
            System.Console.WriteLine("Your starting health is 100. Enjoy!");
            System.Console.WriteLine("''''''");
            System.Threading.Thread.Sleep(1000);
            int maxPower = myCharacter.GetMaxPower();
            myCharacter = new JackSparrow(){UserName = myCharacter.GetUserName(),Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefenseStrength(maxPower)};
            return myCharacter;

        }

        public static Character WillTurnerCharacter(Character myCharacter)
        {
            WillTurner myTurner = new WillTurner();
            System.Console.WriteLine("Will Turner. Great Choice! \nWill Turner's Primary attack is the sword. Please follow the prompts given below. Enjoy!");
            System.Console.WriteLine("You will start at 100 health for the round");
            System.Console.WriteLine("''''''"); 
            System.Threading.Thread.Sleep(1000);
            int maxPower = myCharacter.GetMaxPower();
            myCharacter = new WillTurner(){UserName = myCharacter.GetUserName(),Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefenseStrength(maxPower)};
            return myCharacter;
        }

        public static Character DavyJonesCharacter(Character myCharacter)
        {
            DavyJones myDavy = new DavyJones();
            System.Console.WriteLine("Davy Jones. Great Choice! \nDavy Jone's Primary attack is the cannon fire. Please follow the prompts given below. Enjoy!");
            System.Console.WriteLine("''''''"); 
            System.Console.WriteLine("You will start at 100 health for the round");
            System.Threading.Thread.Sleep(1000);
            int maxPower = myCharacter.GetMaxPower();
            myCharacter = new DavyJones(){UserName = myCharacter.GetUserName(),Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefenseStrength(maxPower)};
            return myCharacter;
        }

        public static void GamePlay(Character playerOne, Character playerTwo)
        {
            Battle myBattle = new Battle();
            myBattle.BattleRound(playerOne,playerTwo);
        }

        static void Exit()
        {
            System.Console.WriteLine("Have a great day... May the Force be With You");
            Environment.Exit(0);
        }
    }
}
