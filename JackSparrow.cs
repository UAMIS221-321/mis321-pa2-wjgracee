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
    }
}