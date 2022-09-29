using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HT3.Gift
{
    public interface IGift
    {
        IEnumerable<Sweet> Items { get; }
        IEnumerable<Sweet> FindCandyBySugar(int _min, int _max);
        void Add(Sweet _sweets);
        int GiftWeight();
        void SortByWeight();
        void GiftPrint();
    }
}
