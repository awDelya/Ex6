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
            if(N==1) return a1;
            if(N==2) return a2;
            if(N==3) return a3;
            double a = FindChislo(N - 1) + 1;
            double b = FindChislo(N - 2) + 2;
            double c = FindChislo(N - 3);
            if(b==0)
            {
                Console.Clear();
                Color.Print("\n По заданным параметрам числовую последовательность построить нельзя, попробуйте еще раз!\n", ConsoleColor.Red);
                Main(); return 1;
            }
            else
                return a / b * c;
        }

        private static double a1, a2, a3;
        private static double[] mas;
        private static int N;

        private static void Create()
        {
            Color.Print("\n Задайте первое число последовательности а1: ", ConsoleColor.Yellow);
            a1 = Number.Check(-100.0, 100.0);
            Color.Print("\n Задайте второе число последовательности а2: ", ConsoleColor.Yellow);
            a2 = Number.Check(-100.0, 100.0);
            Color.Print("\n Задайте третье число последовательности а3: ", ConsoleColor.Yellow);
            a3 = Number.Check(-100.0, 100.0);
            Color.Print("\n Задайте колличество чисел в последовательности N: ", ConsoleColor.Yellow);
            N = Number.Check(1, 10);
            mas = new double[N];
        }

        private static void Rezult()
        {
            for (int i = N; i > 0; i--)
            {
                mas[i - 1] = FindChislo(i);
            }
            int m = 0;
            bool z = false;
            mas.Reverse();
            for (int i = 1; i < N; i++)
            {
                if (mas[i - 1] == mas[i])
                {
                    z = true;
                    m++;
                }
                if (mas[i - 1] < mas[i])
                    m++;
                Color.Print(Convert.ToString(mas[i]) + " ", ConsoleColor.Cyan);
            }
            if (m == N - 1 && !z)
                Color.Print("\n\n Строго возрастающая последовательность.", ConsoleColor.Magenta);
            else if (m == N - 1 && z)
                Color.Print("\n\n Последовательность монтонно неубывающая.", ConsoleColor.Magenta);
            else
                Color.Print("\n\n Последовательность не является строго возрастающей или монотонно неубывающей.", ConsoleColor.Magenta);
        }
        static void Main()
        {
            Create();
            Color.Print("\n Ваша последовательность выглядит так: ", ConsoleColor.Yellow);
            Rezult();
            Text.GoBackMenu();
        }
    }
}
