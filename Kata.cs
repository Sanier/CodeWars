using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Kata
    {
        public static int SquareDigits(int n)
        {
            var result = n.ToString();
            var intList = result.Select(digit => int.Parse(digit.ToString()));

            Console.WriteLine(intList);
            return 0;
        }
    }
}
