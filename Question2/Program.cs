using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你的数组元素，以空格隔开，以回车结束：");
            string str = Console.ReadLine();
            string[] result = str.Split(' ');
            int[] myArray = new int[result.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(result[i]);
            }
            int max, min, sum;
            double average;
            Calculate(myArray, out max, out min, out average, out sum);
            Console.WriteLine("最大值：" + max);
            Console.WriteLine("最小值：" + min);
            Console.WriteLine("平均值：" + average);
            Console.WriteLine("和：" + sum);
        }
        public static void Calculate(int[] array,out int max,out int min,out double average,out int sum)
        {
            max = array[0];
            min = array[0];
            sum = 0;
            foreach(int arr in array)
            {
                if (arr > max)
                {
                    max = arr;
                }
                if (arr < min)
                {
                    min = arr;
                }
                sum += arr;
            }
            average = sum / array.Length;
        }
    }
}
