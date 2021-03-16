using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2~100以内的素数：");
            List<int> list = new List<int>();
            NotPrime(ref list);
            for(int i = 2; i < 101; i++)
            {
                if (!list.Contains(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void NotPrime(ref List<int> list)
        {
            for(int i = 2; i < 51; i++)
            {
                for(int j = 2; i * j < 101; j++)
                {
                    int np = i * j;
                    list.Add(np);
                }
            }
        }
    }
}
