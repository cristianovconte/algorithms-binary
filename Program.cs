using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Conversao de número decimal para binário ####");
            Console.WriteLine("Digite um número:");

            int decimalNumber = 0;
            int.TryParse(Console.ReadLine(), out decimalNumber);

            string binary = DecimalToBinary(decimalNumber);
            int quantityBitsOne = CountBitOne(binary);
            Console.WriteLine("Binário: {0}", binary);
            Console.WriteLine("Quantidade de bits 1: {0}", quantityBitsOne);
            Console.ReadLine();
        }

        static string DecimalToBinary(int decimalNumber)
        {
            StringBuilder strBuilder = new StringBuilder();
            if (decimalNumber > 0)
            {
                while (decimalNumber >= 1)
                {
                    int remainder = decimalNumber % 2;
                    strBuilder.Insert(0, remainder);
                    decimalNumber = decimalNumber / 2;
                }
            }
            return strBuilder.ToString();
        }

        static int CountBitOne(string binary)
        {
            int i = 0;
            foreach (var item in binary)
            {
                if (item.Equals('1'))
                    i++;
            }

            return i;
        }
    }
}
