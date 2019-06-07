using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_methods;

namespace Reqursiya
{
    class Program
    {
        private static int[] mas;
        static void Main()
        {
            Color.Print("\n Задайте первое число последовательности а1: ");
            int a1 = Number.Check(int.MinValue, int.MaxValue);
            Color.Print("\n Задайте второе число последовательности а2: ");
            int a2 = Number.Check(int.MinValue, int.MaxValue);
            Color.Print("\n Задайте третье число последовательности а3: ");
            int a3 = Number.Check(int.MinValue, int.MaxValue);
            Color.Print("\n Задайте колличество чисел в последовательности N: ");
            int N = Number.Check(int.MinValue, int.MaxValue);
            mas = new int[N];
            mas[0] = a1;
            mas[1] = a2;
            mas[2] = a3;
        }
    }
}
