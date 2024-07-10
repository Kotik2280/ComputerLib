using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLib
{
    public class GPU : IGPU, IComputerComponent
    {
        public double MemoryClockSpeed { get; set; }
        public double CoreClockSpeed { get; set; }
        public double VideoRAM { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name} |GPU|\nMemory Clock Speed - {MemoryClockSpeed}GHz\nCore Clock Speed - {CoreClockSpeed}GHz\nVideo RAM - {VideoRAM}Gb\nPrice - {Price}$";
        }
    }
}
