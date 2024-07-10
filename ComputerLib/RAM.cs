using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLib
{
    public class RAM : IRAM, IComputerComponent
    {
        public double Memory { get; set; }
        public double Rate { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name} |RAM|\nMemory - {Memory}Gb\nRate - {Rate}GHz\nPrice - {Price}$";
        }
    }
}
