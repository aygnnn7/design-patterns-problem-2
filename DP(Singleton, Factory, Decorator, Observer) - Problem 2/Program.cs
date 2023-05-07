using Design_Pattern_Solution_2.Decoratorion;
using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_Pattern_Solution_2.Eggs.Egg;

namespace Design_Pattern_Solution_2
{
    internal class Program
    {
        public static Basket basket = new Basket();
        
        static void Main(string[] args)
        {
            
            Chick chickAlfred = new Chick("Alfred");
            Chick chickAlex = new Chick("Alex");
            Chick chickBob = new Chick("Bob");
            basket.Watch(chickAlfred);
            basket.Watch(chickAlex);
            basket.Watch(chickBob);

            EasternBunny bunny = new EasternBunny();
            bunny.CreateDinosaurEgg();
            bunny.CreateQuailEgg();
            bunny.CreateChickenEgg();
            bunny.CreateQuailEgg();
            bunny.CreateQuailEgg();

            Console.WriteLine("\nAlex is no more watching the basket. \n");
            basket.UnWatch(chickAlex);

            bunny.CreateDinosaurEgg();
            bunny.CreateQuailEgg();
            bunny.CreateChickenEgg();
            bunny.CreateDinosaurEgg();
            bunny.CreateChickenEgg();


            Console.ReadKey();
        }
    }
}
