using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HT3.Gift
{
    public enum TypeOfCandy { ChocalateCandy, Caramel };
    public class Candy : Sweet
    {
        public TypeOfCandy Type;
        public Candy(string _name, string _manufact, int _sugar, int _weight, TypeOfCandy _type)
        : base(_name, _manufact, _sugar, _weight)
        {
            Type = _type;
        }
    }
}
