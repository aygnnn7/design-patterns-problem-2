using Design_Pattern_Solution_2.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution_2.Decoratorion
{
    public class PaintDecorator : EggDecorator 
    { 
    
        private string _paintColor;
        
        public PaintDecorator(IEgg egg, string paintColor) : base (egg)
        {
            this._paintColor = paintColor;
            
        }
        override
        public void Created()
        {
            base.Created();
            this.Paint();
        }
        public void Paint()
        {
            Console.WriteLine($"The bunny painted the egg to {_paintColor}!\n");
        }
        
    }
}
