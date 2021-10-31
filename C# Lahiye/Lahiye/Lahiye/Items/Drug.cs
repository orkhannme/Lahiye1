using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahiye.Items
{
    class Drug
    {
        public DrugType Name { get; }
        public DrugType Id { get; }
        public DrugType Type { get; }
        public int Price { get; }
        public int MaxCount { get; }

        public List<DrugType> _drugs;

        public Drug(DrugType name, int price, int maxCount)
        {
            Name = name;
            Price = price;
            MaxCount = maxCount;
            _drugs = new List<DrugType>();
            
        }
        public override string ToString()
        {
            return $"{Id}-{Name},{Type},{Price},{MaxCount}";
        }

    }
}
