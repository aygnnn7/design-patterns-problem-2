using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution_2.Eggs
{
    public class Egg
    {
        public enum EggType
        {
            Quail = 1,
            Chicken = 2,
            Dinosaur = 3
        }
        public Egg(object egg)
        {
            _egg = egg;
        } 

        private object _egg;
        public object _Egg { get { return _egg; }}
    }
}
