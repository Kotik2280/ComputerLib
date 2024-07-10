using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLib
{
    public interface IGPU
    {
        public double MemoryClockSpeed { get; set; }
        public double CoreClockSpeed { get; set; }
        public double VideoRAM { get; set; }
    }
}
