using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class TensCreator : IDictionaryCreator
    {
        public Dictionary<int, string> CreateDictionary()
        {
            Dictionary<int, string> tensName = new Dictionary<int, string>();

            tensName.Add(3, "Treinta");
            tensName.Add(4, "Cuarenta");
            tensName.Add(5, "Cinuenta");
            tensName.Add(6, "Sesenta");
            tensName.Add(7, "Setenta");
            tensName.Add(8, "Ochenta");
            tensName.Add(9, "Noventa");
            return tensName;
        }
    }
}
