using System;
using mis321_pa2_wjgracee.Interfaces;

namespace mis321_pa2_wjgracee
{
    public class DistractAttack : IAttack
    {
        public void Attacking()
        {
            System.Console.WriteLine("Look over there!! (Distraction)");
        }
    }
}