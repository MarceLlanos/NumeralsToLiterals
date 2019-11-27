using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class LiteralHundredConverter : IConverter
    {
        IConverter next;
        Dictionary<int, string> hundredNames;
        public LiteralHundredConverter(Dictionary<int, string> hundredNames)
        {
            this.hundredNames = hundredNames;
        }

        public string ConvertIntToLiteral(int number)
        {
            if (number >= 100 && number <= 999)
            {
                var hundred = number / 100;
                var hundredResult = number % 100;

                return hundredNames[hundred]  + next.ConvertIntToLiteral(hundredResult);
            }
            if (next != null)
            {
                return next.ConvertIntToLiteral(number);
            }

            return string.Empty;
        }

        public void setNext(IConverter next)
        {
            this.next = next;
        }
    }
}
