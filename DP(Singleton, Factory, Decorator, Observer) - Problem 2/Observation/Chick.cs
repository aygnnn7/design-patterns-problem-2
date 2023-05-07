using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution_2
{
    internal class Chick : IChick
    {
        public Chick(string name) {
            Name = name;
        }
        public string Name { get; set; }
        public void SawFiveEggs()
        {
            Console.WriteLine($"The chick {Name} just saw the five eggs in the basket. {Name}: 'The eggs are ready!'");
        }
    }
}
