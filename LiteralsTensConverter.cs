using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class LiteralsTensConverter:IConverter
    {
        IConverter next;
        Dictionary<int, string> tensName;
        public LiteralsTensConverter(Dictionary<int, string> tensName)
        {
            this.tensName = tensName;

        }

        public string ConvertIntToLiteral(int number)
        {
            if (number >= 30 && number <= 99)
            {
                var hundred = number / 10;
                var hundredResult = number % 10;
                if(hundredResult != 0)
                {
                    return tensName[hundred] + " y " + next.ConvertIntToLiteral(hundredResult);
                }
                else
                {
                    return tensName[hundred];
                }

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
