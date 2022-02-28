using System;
using mis321_pa2_wjgracee.Interfaces;
namespace mis321_pa2_wjgracee
{
    public class KickAttack : IAttack
    {
        public void Attacking()
        {
            System.Console.WriteLine("Kick!");
        }
    }
}