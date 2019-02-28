using System;

namespace Units
{
    public class OrcChieftain : Orc
    {
        public OrcChieftain(int hitPoints)
            : base(hitPoints)
        {
        }

        public override void DieCry()
        {
            Console.WriteLine("I died");
        }
    }
}
