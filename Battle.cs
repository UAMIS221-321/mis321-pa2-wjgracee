using System;
using mis321_pa2_wjgracee.Interfaces;
namespace mis321_pa2_wjgracee
{
    public class Battle : Character
    {
        public void PlayerOneTurn(Character playerOne, Character playerTwo)
        {
            playerOne.attackbehavior.Attacking(); // attaack behavior 
            if(playerOne.CharacterName == "Jack Sparrow" && playerTwo.CharacterName == "Will Turner" || playerOne.CharacterName == "Will Turner" && playerTwo.CharacterName == "Davy Jones" || playerOne.CharacterName == "Davy Jones" && playerTwo.CharacterName == "Jack Sparrow") // checks condition for combo boost attack
            {
                System.Console.WriteLine(playerOne.UserName + " has the character type " + playerOne.CharacterName + ". Player two was the character type " + playerTwo.CharacterName + " resulting in an advantage with a 20% attack boost");
                if(playerOne.AttackStrength > playerTwo.DefensePower) // checks if attack is greater then defense
                {
                    playerOne.DamageDealt = (playerOne.AttackStrength - playerTwo.DefensePower) * 1.2; //combo boost 
                    Math.Round(playerOne.DamageDealt, 0, MidpointRounding.AwayFromZero); // rounds number
                    playerTwo.Health = playerTwo.Health - playerOne.DamageDealt;
                    playerOne.StatsOne(playerOne, playerTwo); //stats 
                }
                else
                {
                    playerOne.DamageDealt = 1;
                    playerTwo.Health = playerTwo.Health - playerOne.DamageDealt;
                    playerOne.StatsOne(playerOne, playerTwo); //stats
                }
            }
            else
            {
                if(playerOne.AttackStrength > playerTwo.DefensePower)
                {
                    playerOne.DamageDealt = (playerOne.AttackStrength - playerTwo.DefensePower);
                    Math.Round(playerOne.DamageDealt, 0, MidpointRounding.AwayFromZero); // rounds number  
                    playerTwo.Health = playerTwo.Health - playerOne.DamageDealt;
                    playerOne.StatsOne(playerOne, playerTwo); //stats
                }
                else
                {
                    playerOne.DamageDealt = 1;
                    Math.Round(playerOne.DamageDealt, 0, MidpointRounding.AwayFromZero); //rounds number
                    playerTwo.Health = playerTwo.Health - playerOne.DamageDealt;
                    playerOne.StatsOne(playerOne, playerTwo); //stats
                }
            }
        }

        public void PlayerTwoTurn(Character playerTwo, Character playerOne)
        {
            playerTwo.attackbehavior.Attacking();
            if(playerTwo.CharacterName == "Jack Sparrow" && playerOne.CharacterName == "Will Turner" || playerTwo.CharacterName == "Will Turner" && playerOne.CharacterName == "Davy Jones" || playerTwo.CharacterName == "Davy Jones" && playerOne.CharacterName == "Jack Sparrow") // checks condition 
            {
                System.Console.WriteLine("\n" + playerTwo.UserName + " has the character type " + playerTwo.CharacterName + ". Player one was the character type " + playerOne.CharacterName + " resulting in an advantage with a 20% attack boost");
                if(playerTwo.AttackStrength > playerOne.DefensePower) // checks if attakc is greater then defense 
                {
                    playerTwo.DamageDealt = (playerTwo.AttackStrength - playerOne.DefensePower) * 1.2; // combo boost 
                    Math.Round(playerTwo.DamageDealt, 0, MidpointRounding.AwayFromZero); // rounds 
                    playerOne.Health = playerOne.Health - playerTwo.DamageDealt;
                    playerTwo.StatsTwo(playerOne, playerTwo); // stats
                }
                else
                {
                    playerTwo.DamageDealt = 1;
                    Math.Round(playerTwo.DamageDealt, 0, MidpointRounding.AwayFromZero);
                    playerOne.Health = playerOne.Health - playerTwo.DamageDealt;
                    playerTwo.StatsTwo(playerOne, playerTwo); // stats 
                }
            }
            else
            {
                if(playerTwo.AttackStrength > playerOne.DefensePower) // checks if attack is greater then defense 
                {
                    playerTwo.DamageDealt = (playerTwo.AttackStrength - playerOne.DefensePower);
                    Math.Round(playerTwo.DamageDealt, 0, MidpointRounding.AwayFromZero);
                    playerOne.Health = playerOne.Health - playerTwo.DamageDealt;
                    playerTwo.StatsTwo(playerOne, playerTwo); // stats 
                }
                else
                {
                    playerTwo.DamageDealt = 1;
                    Math.Round(playerTwo.DamageDealt, 0, MidpointRounding.AwayFromZero);
                    playerOne.Health = playerOne.Health - playerTwo.DamageDealt;
                    playerTwo.StatsTwo(playerOne, playerTwo); // stats
                }
            }
        }
    }
}