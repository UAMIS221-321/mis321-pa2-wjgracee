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
            Character playerOne = new Character(); // instantiates player one
            Character playerTwo = new Character(); //instantiates player two
            playerOne = GetUserCharacter(); // gets player ones character choice
            System.Console.WriteLine("''''''''''''''\nPlayer two"); 
            playerTwo = GetUserCharacter(); // gets player twos character choice 
            System.Console.WriteLine($"\nPlayer: {playerOne.UserName}\nCharacter: {playerOne.CharacterName}\nMaxPower: {playerOne.MaxPower}\nHealth: {playerOne.Health}\nAttackStrength: {playerOne.AttackStrength}\nDefensivePower: {playerOne.DefensePower}");
            System.Console.WriteLine($"\nPlayer: {playerTwo.UserName}\nCharacter: {playerTwo.CharacterName}\nMaxPower: {playerTwo.MaxPower}\nHealth: {playerTwo.Health}\nAttackStrength: {playerTwo.AttackStrength}\nDefensivePower: {playerTwo.DefensePower}");
            GamePlay(playerOne,playerTwo, damage); // calls game play for logic 
        }

        public static Character GetUserCharacter()
        {
            Character myCharacter = new Character();

            Menu newMenu = new Menu();
            int userChoice = newMenu.GetCharacter();
            switch(userChoice)
            {
                case 1: myCharacter = JackSparrowCharacter(myCharacter); // instanciates character 
                    break;
                case 2: myCharacter = WillTurnerCharacter(myCharacter); // instanciates character 
                    break;
                case 3: myCharacter = DavyJonesCharacter(myCharacter); // instanciates character 
                    break;
                default: 
                    System.Console.WriteLine("Invalid choice."); // error check
                    newMenu.GetCharacter(); //recalls method
                    break;
            }
            return myCharacter; // returns character 
        }
        
        public static Character JackSparrowCharacter(Character myCharacter)
        {
            Menu newMenu = new Menu();
            System.Console.WriteLine("Jack Sparrow. Great Choice! \nJack Sparrow's Primary attack is to distract. Please follow the prompts given below.");
            System.Console.WriteLine("Your starting health is 100. Enjoy!");
            System.Console.WriteLine("''''''");
            System.Threading.Thread.Sleep(1000); // slows gameplay down
            int maxPower = myCharacter.GetMaxPower(); //generates max power 
            myCharacter = new JackSparrow(){UserName = myCharacter.GetUserName(),CharacterName = "Jack Sparrow",Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefenseStrength(maxPower)};
            return myCharacter; //returns character 

        }

        public static Character WillTurnerCharacter(Character myCharacter)
        {
            WillTurner myTurner = new WillTurner();
            System.Console.WriteLine("Will Turner. Great Choice! \nWill Turner's Primary attack is the sword. Please follow the prompts given below. Enjoy!");
            System.Console.WriteLine("You will start at 100 health for the round");
            System.Console.WriteLine("''''''"); 
            System.Threading.Thread.Sleep(1000); // slows gameplay
            int maxPower = myCharacter.GetMaxPower(); //generates max power
            myCharacter = new WillTurner(){UserName = myCharacter.GetUserName(),CharacterName = "Will Turner",Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefenseStrength(maxPower)};
            return myCharacter; //returns character 
        }

        public static Character DavyJonesCharacter(Character myCharacter)
        {
            DavyJones myDavy = new DavyJones();
            System.Console.WriteLine("Davy Jones. Great Choice! \nDavy Jone's Primary attack is the cannon fire. Please follow the prompts given below. Enjoy!");
            System.Console.WriteLine("''''''"); 
            System.Console.WriteLine("You will start at 100 health for the round");
            System.Threading.Thread.Sleep(1000); // slows gameplay
            int maxPower = myCharacter.GetMaxPower(); //generates max power 
            myCharacter = new DavyJones(){UserName = myCharacter.GetUserName(),CharacterName = "Davy Jones",Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefenseStrength(maxPower)};
            return myCharacter; // returns character 
        }

        public static void GamePlay(Character playerOne, Character playerTwo, double damage)
        { 
            Battle newBattle = new Battle();
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1,3);
            System.Console.WriteLine("The computer will randomly generate a number between 1 or 2. If guessed correctly, player one will go first. Else, player two will go first"); // prompts user with directions 
            System.Console.WriteLine("Please pick a number 1 or 2 to decide who goes first"); // prompts user
            int userPick = int.Parse(Console.ReadLine()); // gets user choice 
            while(userPick != 1 && userPick != 2) //while loop
            {
                System.Console.WriteLine("Invalid choice");
                System.Console.WriteLine("The computer will randomly generate a number between 1 or 2. If guessed correctly, player one will go first. Else, player two will go first");
                System.Console.WriteLine("Please pick a number 1 or 2 to decide who goes first");
                userPick = int.Parse(Console.ReadLine()); //update read
            }

            if(userPick == randomNumber)
            {
                System.Console.WriteLine("Player One Goes First"); // prompts user with who won
            }
            else
            {
                System.Console.WriteLine("Player two goes first"); //prompts user with who won
            }

            while(playerOne.Health > 0 && playerTwo.Health > 0) // game runs as long as players health is above zero
            {
                if(userPick == randomNumber) //player one choose correctly 
                {
                    newBattle.PlayerOneTurn(playerOne, playerTwo); //calls player one turn
                    System.Threading.Thread.Sleep(2000);
                    if(playerTwo.Health > 0) // if player two health is above 0 after attack, call player two
                    {
                        newBattle.PlayerTwoTurn(playerTwo, playerOne); // player two turn
                        System.Threading.Thread.Sleep(2000); //slows
                    }
                }
                else
                {
                    newBattle.PlayerTwoTurn(playerTwo, playerOne); // calls player two turn
                    System.Threading.Thread.Sleep(2000);
                    if(playerOne.Health > 0)
                    {
                        newBattle.PlayerOneTurn(playerOne, playerTwo); // calls player one if player one health is above zero 
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }

            if(playerOne.Health > playerTwo.Health)
            {
                System.Console.WriteLine("Player one wins"); // winner
            }
            else
            {
                System.Console.WriteLine("PLayer two wins!"); //winner
            }
        }
        static void Exit()
        {
            System.Console.WriteLine("Have a great day... May the Force be With You");
            Environment.Exit(0); //exit method
        }
    }
}
