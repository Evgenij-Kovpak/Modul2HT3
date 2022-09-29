using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HT3.Gift
{
    public abstract class Sweet
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public int Sugar { get; private set; }
        public int Weight { get; private set; }
        public Sweet(string _name, string _manufact, int _sugar, int _weight)
        {
            Name = _name;
            Manufacturer = _manufact;
            Sugar = _sugar;
            Weight = _weight;
        }
    }
}
