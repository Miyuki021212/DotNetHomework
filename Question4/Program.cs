using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入矩阵的行数m和列数n：");
            int m=Convert.ToInt32(Console.ReadLine());
            int n=Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m, n];
            Console.Write("请输入你的数组元素，以空格隔开，以回车结束：");
            string str = Console.ReadLine();
            string[] result = str.Split(' ');
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(result[i*n + j]);
                }
            }
            Console.WriteLine(Calculate(m, n, array));
        }
        public static bool Calculate(int m,int n,int[,] array)
        {
            int max;
            if (m < n)
            {
                max = m;
            }
            else
            {
                max = n;
            }
            for (int i = 0; i < max-1; i++)
            {
                if (array[i, i] != array[i+1, i+1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
