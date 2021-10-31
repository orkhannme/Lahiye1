using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahiye.Items
{
    class DrugType
    {
        public int Id { get; }
        public string TypeName { get; }

        public DrugType(int id, string typeName)
        {
            Id = id;
            TypeName = typeName;
        }
        public override string ToString()
        {
            return $"{TypeName}";
        }
    }
}
