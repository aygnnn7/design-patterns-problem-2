using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution_2
{
    internal class Basket : IBasket
    {
        private List<IChick> watchingChicks;
        private List<ChickenEgg> _chickenEggs;
        private List<DinosaurEgg> _dinosaurEggs;
        private List<QuailEgg> _quailEggs;

        private int countOfEggs;
        public int CountOfEggs { 
            get { return countOfEggs; }
            set
            {
                countOfEggs = value;
                if(countOfEggs >= 5)
                {
                    countOfEggs = 0;
                    ItsFive();
                }
            }
        }
        
        public Basket()
        {
            this._chickenEggs = new List<ChickenEgg>();
            this._dinosaurEggs = new List<DinosaurEgg>();
            this._quailEggs = new List<QuailEgg>();
            this.watchingChicks = new List<IChick>(); 
            countOfEggs = 0;
        }

        public void PutChickenEgg(ChickenEgg c)
        {
            _chickenEggs.Add(c);
            CountOfEggs++;
        }
        public void PutDinosaurEgg(DinosaurEgg d)
        {
            _dinosaurEggs.Add(d);
            CountOfEggs++;
        }
        public void PutQuailEgg(QuailEgg q)
        {
            _quailEggs.Add(q);
            CountOfEggs++;
        }


        public void Watch(IChick chick)
        {
            watchingChicks.Add(chick);
        }

        public void UnWatch(IChick chick)
        {
            watchingChicks.Remove(chick);
        }

        public void ItsFive()
        {
            foreach (var watcher in watchingChicks)
            {
                watcher.SawFiveEggs();
            }
        }
    }
}
