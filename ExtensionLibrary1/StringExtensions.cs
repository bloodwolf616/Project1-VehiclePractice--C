using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionLibrary1
{
    public static class StringExtensions
    {
        public static void Print(this string phrase)
        {
            Console.WriteLine(phrase);
        }


    }
}
