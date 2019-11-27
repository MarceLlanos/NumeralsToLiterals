using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class UnityCreator : IDictionaryCreator
    {
        
        public Dictionary<int, string> CreateDictionary()
        {
            Dictionary<int, string> literalNames = new Dictionary<int, string>();

            literalNames.Add(1, "Uno");
            literalNames.Add(2, "Dos");
            literalNames.Add(3, "Tres");
            literalNames.Add(4, "Cuatro");
            literalNames.Add(5, "Cinco");
            literalNames.Add(6, "Seis");
            literalNames.Add(7, "Siete");
            literalNames.Add(8, "Ocho");
            literalNames.Add(9, "Nueve");
            literalNames.Add(10, "Diez");
            literalNames.Add(11, "Once");
            literalNames.Add(13, "Trece");
            literalNames.Add(15, "Quince");
            literalNames.Add(16, "Dieciseis");
            literalNames.Add(17, "Diecisiete");
            literalNames.Add(18, "Dieciocho");
            literalNames.Add(19, "Diecinueve");
            literalNames.Add(20, "Veinte");
            literalNames.Add(21, "Veintiuno");
            literalNames.Add(22, "veintidós");
            literalNames.Add(23, "Veintitres");
            literalNames.Add(24, "Veinticuatro");
            literalNames.Add(25, "Veinticinco");
            literalNames.Add(26, "Veintiseis");
            literalNames.Add(27, "Veintisiete");
            literalNames.Add(28, "Veintiocho");
            literalNames.Add(29, "Veintinueve");
            return literalNames;
        }
    }
}
