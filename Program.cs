using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsToLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionaryCreator unity = new UnityCreator();
            IDictionaryCreator tens = new TensCreator();
            IDictionaryCreator hundred = new HundredCreator();

            var thousandLiteral = new LiteralThousandConverter();
            var hundredLiteral = new LiteralHundredConverter(hundred.CreateDictionary());
            var tensLiteral = new LiteralsTensConverter(tens.CreateDictionary());
            var unityLiteral = new LiteralsUnitConverter(unity.CreateDictionary());
            
            thousandLiteral.setNext(hundredLiteral);
            hundredLiteral.setNext(tensLiteral);
            tensLiteral.setNext(unityLiteral);
            
            Console.WriteLine("Write an Number:");
            string number = Console.ReadLine();
            Console.WriteLine("The literal number is:");
            Console.WriteLine(thousandLiteral.ConvertIntToLiteral(int.Parse(number)));

            Console.ReadKey();
        }
    }
}
