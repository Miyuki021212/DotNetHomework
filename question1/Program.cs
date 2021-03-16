using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个整数：");
            string s = Console.ReadLine();
            int num = Convert.ToInt32(s);
            List<int> list=Prime(num);
            foreach(int ans in list)
            {
                Console.WriteLine(ans);
            }
        }
        public static List<int> Prime(int n)
        {
            int i = 0;
            int prime = 2;
            List<int> answer = new List<int>();
            if (n < 2)
            {
                answer.Add(n);
                return answer;
            }
            while (prime <= n)
            {
                int remain = n % prime;
                if (remain == 0)
                {
                    answer.Add(prime);
                    n = n / prime;
                    i++;
                }
                else
                {
                    prime++;
                }
            }
            return answer;
        }
    }
}