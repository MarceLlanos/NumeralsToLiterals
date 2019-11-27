using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class LiteralsUnitConverter:IConverter
    {
        IConverter next;
        
        Dictionary<int, string> literalNames;
        public LiteralsUnitConverter(Dictionary<int, string> literalNames)
        {            
            this.literalNames = literalNames;
        }
        public string ConvertIntToLiteral(int number)
        {
            if (number >= 1 && number <= 29)
            {
                return literalNames[number];
            }

            return string.Empty;
        }

        public void setNext(IConverter next)
        {
            this.next = next;
        }
    }
}
