using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution_2.Eggs
{
    internal class QuailEgg:IEgg
    {
        public string Type { get { return "quail"; } }

        public void Created()
        {
            Console.WriteLine("Yuppi! The eastern bunny just created a " + this.Type + " egg!");
        }
    }
}
