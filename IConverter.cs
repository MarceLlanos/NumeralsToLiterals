using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    interface IConverter
    {
        string ConvertIntToLiteral(int number);
        void setNext(IConverter next);
    }
}
