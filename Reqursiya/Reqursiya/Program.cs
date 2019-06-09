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
        private static double FindChislo(int N)
        {
            if(N==1)
            {
                return a1;
            }
            if(N==2)
            {
                return a2;
            }
            if(N==3)
            {
                return a3;
            }
            try
            {
                return (FindChislo(N - 1) + 1) / (FindChislo(N - 2) + 2) * FindChislo(N - 3);
            }
            catch(DivideByZeroException)
            {
                Console.Clear();
                Color.Print("\n По заданным параметрам числовую последовательность построить нельзя, попробуйте еще раз!", ConsoleColor.Red);
                Main();
                return 1;
            }
        }
        private static double a1, a2, a3;
        private static double[] mas;
        static void Main()
        {
            Color.Print("\n Задайте первое число последовательности а1: ", ConsoleColor.Yellow);
            a1 = Number.Check(double.MinValue, double.MaxValue);
            Color.Print("\n Задайте второе число последовательности а2: ", ConsoleColor.Yellow);
            a2 = Number.Check(double.MinValue, double.MaxValue);
            Color.Print("\n Задайте третье число последовательности а3: ", ConsoleColor.Yellow);
            a3 = Number.Check(double.MinValue, double.MaxValue);
            Color.Print("\n Задайте колличество чисел в последовательности N: ", ConsoleColor.Yellow);
            int N = Number.Check(int.MinValue, int.MaxValue);
            mas = new double[N];
            Color.Print("\n Ваша последовательность выглядит так: ", ConsoleColor.Yellow);
            for(int i = N; i>0; i--)
            {
                mas[i-1] = FindChislo(i);
            }
            int m = 0;
            bool z = false;
            mas.Reverse();
            for(int i = 0; i<N; i++)
            {
                try
                {
                    if (mas[i] == mas[i + 1])
                    {
                        z = true;
                        m++;
                    }  
                    if (mas[i] < mas[i + 1])
                        m++;
                }
                catch(IndexOutOfRangeException) { }
                Color.Print(Convert.ToString(mas[i]) + " ", ConsoleColor.Cyan);
            }
            if (m == N - 1 && !z)
                Color.Print("\n\n Строго возрастающая последовательность.", ConsoleColor.Magenta);
            else if (m == N - 1 && z)
                Color.Print("\n\n Последовательность монтонно неубывающая.", ConsoleColor.Magenta);
            else
                Color.Print("\n\n Последовательность не является строго возрастающей или монотонно неубывающей.", ConsoleColor.Magenta);
            Text.GoBackMenu();
            Environment.Exit(0);
        }
    }
}
