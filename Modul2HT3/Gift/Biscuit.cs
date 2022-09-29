using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HT3.Gift
{
    public enum TypeOfBiscuit { OatCookies, Shortbread };
    public class Biscuit : Sweet
    {
        public TypeOfBiscuit Type;
        public Biscuit(string _name, string _manufact, int _sugar, int _weight, TypeOfBiscuit _type)
        : base(_name, _manufact, _sugar, _weight)
        {
            Type = _type;
        }
    }
}
