using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLib
{
    public interface IComputerComponent
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
