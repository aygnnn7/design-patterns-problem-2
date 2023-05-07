using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution_2.Decoratorion
{
    public abstract class EggDecorator : IEgg
    {
        protected IEgg decoratedEgg;
        public EggDecorator(IEgg egg) : base()
        {
            
            this.decoratedEgg = egg;
        }

        public virtual void Created()
        {
            this.decoratedEgg.Created();
        }
        
    }
}
