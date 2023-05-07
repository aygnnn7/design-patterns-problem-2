using Design_Pattern_Solution_2.Decoratorion;
using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_Pattern_Solution_2.Eggs.Egg;
using static Design_Pattern_Solution_2.Program;

namespace Design_Pattern_Solution_2
{
    
    public class EasternBunny
    {
        private readonly MagicBag _magicBag;
        public EasternBunny()
        {
            _magicBag = MagicBag.GetMagicBag();
        }
        
        public void CreateChickenEgg()
        {
            ChickenEgg egg = _magicBag.CreateEgg(EggType.Chicken)._Egg as ChickenEgg;
            RandomDecor(egg);
            basket.PutChickenEgg(egg);
        }
        public void CreateQuailEgg()
        {
            QuailEgg egg = _magicBag.CreateEgg(EggType.Quail)._Egg as QuailEgg;
            RandomDecor(egg);
            basket.PutQuailEgg(egg);
        }
        public void CreateDinosaurEgg()
        {
            DinosaurEgg egg = _magicBag.CreateEgg(EggType.Dinosaur)._Egg as DinosaurEgg;
            RandomDecor(egg);
            basket.PutDinosaurEgg(egg);
        }
        List<string> colors = new List<string> { "blue", "red", "purple", "yellow", "green", "orange", "grey", "pink" };
        List<string> stickers = new List<string> { "flower", "cat", "dog", "car", "bicycle", "skateboard", "burger" };

        public void RandomDecor(IEgg egg)
        {
           
            IEgg decoratedEgg;
            Random r = new Random();
            bool randomDecor = r.Next(2) == 0;
            if(randomDecor)
            {
                decoratedEgg = new StickerDecorator(egg, stickers[r.Next(stickers.Count)]);
            }
            else
            {
                decoratedEgg = new PaintDecorator(egg, colors[r.Next(colors.Count)]);
            }
            decoratedEgg.Created();
        }

    }
}
