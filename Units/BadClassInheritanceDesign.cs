using System;

namespace Units
{
    // should be in separate files, but this is only to show bad design
    // and having it in one place is easier to grasp
    public class WolfGoblin : Goblin//, Wolf <- cannot do that
    {

    }

    public class Goblin : Unit
    {
        public override void Bla()
        {
            throw new NotImplementedException();
        }
    }

    public class Wolf : Unit
    {
        public override void Bla()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Unit
    {
        public abstract void Bla();
    }
}
