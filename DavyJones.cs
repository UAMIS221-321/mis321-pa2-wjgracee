using System;
using mis321_pa2_wjgracee.Interfaces;
namespace mis321_pa2_wjgracee
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            attackbehavior = new CannonAttack();
        }
    }
}