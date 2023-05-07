using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_Pattern_Solution_2.Eggs.Egg;

namespace Design_Pattern_Solution_2
{
    abstract class AbstractMagic : IMagic
    {
        public abstract Egg CreateEgg(EggType type);

    }
}
