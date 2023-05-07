using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution_2.Decoratorion
{
    internal class StickerDecorator : EggDecorator
    {
        private string _sticker;
        public StickerDecorator(IEgg egg, string sticker) : base(egg)
        {
            this._sticker = sticker;
        }
        override
        public void Created()
        {
            base.Created();
            this.ApplySticker();
        }
        public void ApplySticker()
        {
            Console.WriteLine($"The bunny applied {_sticker} sticker to the egg!\n");
        }
    }
}
