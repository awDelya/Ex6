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
        private static int FindChislo(int N)
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
                return (FindChislo(N - 1) + 1) / ((FindChislo(N - 2) + 2) * FindChislo(N - 3));
            }
            catch(DivideByZeroException)
            {
                Console.Clear();
                Color.Print("\n По заданным параметрам числовую последовательность построить нельзя, попробуйте еще раз!", ConsoleColor.Red);
                Main();
                return 1;
            }
        }
        private static int a1, a2, a3;
        static void Main()
        {
            Color.Print("\n Задайте первое число последовательности а1: ", ConsoleColor.Yellow);
            a1 = Number.Check(int.MinValue, int.MaxValue);
            Color.Print("\n Задайте второе число последовательности а2: ", ConsoleColor.Yellow);
            a2 = Number.Check(int.MinValue, int.MaxValue);
            Color.Print("\n Задайте третье число последовательности а3: ", ConsoleColor.Yellow);
            a3 = Number.Check(int.MinValue, int.MaxValue);
            Color.Print("\n Задайте колличество чисел в последовательности N: ", ConsoleColor.Yellow);
            int N = Number.Check(int.MinValue, int.MaxValue);
            Color.Print("\n Ваша последовательность выглядит так: ", ConsoleColor.Yellow);
            for(int i = N; i>0; i--)
            {
                Color.Print(Convert.ToString(FindChislo(i))+" ", ConsoleColor.Cyan);
            }
            Text.GoBackMenu();
            Environment.Exit(0);
        }
    }
}
