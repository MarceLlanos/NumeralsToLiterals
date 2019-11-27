using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class LiteralThousandConverter : IConverter
    {
        IConverter next;
        public string ConvertIntToLiteral(int number)
        {
            if (number >= 1000 && number <= 99999)
            {
                var thousand = number / 1000;
                var thousanddResult = number % 1000;

                return next.ConvertIntToLiteral(thousand) +" mil " + next.ConvertIntToLiteral(thousanddResult);
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
