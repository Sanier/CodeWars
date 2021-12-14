using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SquareDigits(n);

            Console.ReadKey();
        }

        public static int SquareDigits(int n)
        {
            var result = n.ToString();

            List<int> intList = new List<int>();

            string sd = "";

            for (int i = 0; i < result.Length; i++)
            {
                var sum = (int)Math.Pow(result[i] - '0', 2);

                intList.Add(sum);
                sd = sd + intList[i].ToString();

                
                Console.WriteLine(intList[i]);
            }

            int num = int.Parse(sd);
            Console.Write(num);

            return num;
        }
    }
}
