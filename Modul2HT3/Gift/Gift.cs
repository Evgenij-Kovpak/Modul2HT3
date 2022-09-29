using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HT3.Gift
{
    public class Gift : IGift
    {
        private readonly ICollection<Sweet> items;
        public Gift()
        {
            items = new List<Sweet>();
        }
        public void Add(Sweet _sweets)
        {
            items.Add(_sweets);
        }
        public int GiftWeight()
        {
            return items.Sum(x => x.Weight);
        }
        public IEnumerable<Sweet> FindCandyBySugar(int _min, int _max)
        {
            return items.Where(x => (x.Sugar >= _min) && (x.Sugar <= _max)).ToList();
        }
        public IEnumerable<Sweet> Items
        {
            get
            {
                return items;
            }
        }
        public void SortByWeight()
        {
            var temp = items.OrderBy(x => x.Weight).ToList();

            items.Clear();

            foreach (var item in temp)
            {
                items.Add(item);
            }
        }
        public void GiftPrint()
        {
            Console.WriteLine("Содержание подарка:");
            foreach (var item in items)
            {
                Console.WriteLine($"Название сладостей: {item.Name},\n Страна производитель: {item.Manufacturer}," +
                    $"\n Сахар: {item.Sugar}g,\n Вес: {item.Weight}g\n\n");
            }
        }
    }
}
