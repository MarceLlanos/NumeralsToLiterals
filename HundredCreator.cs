using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class HundredCreator : IDictionaryCreator
    {

        public Dictionary<int, string> CreateDictionary()
        {
            Dictionary<int, string> hundredNames = new Dictionary<int, string>();

            hundredNames.Add(0, " ");
            hundredNames.Add(1, "cien ");
            hundredNames.Add(2, "docientos ");
            hundredNames.Add(3, "trecientos ");
            hundredNames.Add(4, "cuatrocientos ");
            hundredNames.Add(5, "quinientos ");
            hundredNames.Add(6, "seiscientos ");
            hundredNames.Add(7, "setecientos ");
            hundredNames.Add(8, "ochocientos ");
            hundredNames.Add(9, "novecientos ");

            return hundredNames;
        }
    }
}
