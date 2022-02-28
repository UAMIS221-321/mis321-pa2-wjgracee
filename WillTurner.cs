using System;
using mis321_pa2_wjgracee.Interfaces;

namespace mis321_pa2_wjgracee
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            attackbehavior = new SwordAttack();
        }
    }
}