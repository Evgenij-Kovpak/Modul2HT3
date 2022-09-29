using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HT3.Gift
{
    public enum ColorOfChocalate { BlackChocolate, WhiteChocolate };
    public class Chocalate : Sweet
    {
        public ColorOfChocalate Color;
        public Chocalate(string _name, string _manufact, int _sugar, int _weight, ColorOfChocalate _color)
        : base(_name, _manufact, _sugar, _weight)
        {
            Color = _color;
        }
    }
}
