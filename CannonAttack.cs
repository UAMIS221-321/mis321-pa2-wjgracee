using System;
using mis321_pa2_wjgracee.Interfaces;

namespace mis321_pa2_wjgracee
{
    public class CannonAttack: IAttack
    {
        public void Attacking()
        {
            System.Console.WriteLine("Cannon Attack!!");
        }
    }
}