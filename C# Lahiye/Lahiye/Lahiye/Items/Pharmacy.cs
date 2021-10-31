using Lahiye.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahiye.Items
{
    class Pharmacy
    {
        public DrugType Name { get; }
        public DrugType Id { get; }
        public int MaxCount { get; private set; }

        public List<Drug> _drugs;

        public override string ToString()
        {
            return $"{Id},{Name}";
        }

        public bool AddDrug(Drug drug)
        {
            if (_drugs.Count == MaxCount) 
            {
                return false;
            }
            _drugs.Add(drug);
            return true;
        }
        public void ShowDrugItems()
        {
            if (_drugs.Count == 0)
            {
                Extensions.Print($"Bele bir derman yoxdur", ConsoleColor.Red);
                return;
            }

            Extensions.Print($"Dermanlarin siyahisi:", ConsoleColor.Yellow);
            foreach (var item in _drugs)
            {
                Extensions.Print(item.ToString(), ConsoleColor.Green);
            }
            public static SaleDrug()
            {
                
            }
        }
    }   
}
