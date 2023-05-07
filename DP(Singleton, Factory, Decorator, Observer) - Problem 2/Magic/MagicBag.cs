using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static Design_Pattern_Solution_2.Eggs.Egg;

namespace Design_Pattern_Solution_2
{
    sealed class MagicBag: AbstractMagic
    {
        

        private readonly static MagicBag _magicBag = new MagicBag();
        
        public static MagicBag GetMagicBag()
        {
            return _magicBag;
        }
        
        public override Egg CreateEgg(EggType type)
        {
            Egg egg = null;

            switch (type) {

                case EggType.Quail:
                    egg = new Egg(new QuailEgg());
                    break;
                case EggType.Chicken:
                    egg = new Egg(new ChickenEgg());
                    break;
                case EggType.Dinosaur:
                    egg = new Egg(new DinosaurEgg());
                    break;
            }

            return egg;
        }
    }
}
