using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 1;
            Console.Write("请输入第一个数字：");
            string s1 = Console.ReadLine();
            Console.Write("请输入第二个数字：");
            string s2 = Console.ReadLine();
            if (s1 != null)
            {
                a = Convert.ToDouble(s1);
            }
            else
            {
                Console.Write("数据异常");
            }
            if (s1 != null)
            {
                b = Convert.ToDouble(s2);
            }
            else
            {
                Console.Write("数据异常");
            }
            Console.Write("请输入一个运算符：");
            string symbol = Console.ReadLine();
            Console.Write("结果为：");
            if (symbol=="+")
            {
                Console.WriteLine(a + b);
            }
            else if (symbol == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (symbol == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (symbol == "/")
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.Write("数据异常");
            }
        }
    }
}
