using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 1, f2 = 1, f3, s1;
            int x = 10, s2 = 0;
            int[] numbers = new int[11];

            do
            {
                f3 = f2 + f1;
                f1 = f2;
                f2 = f3;
                s1 = 0;
                for (int i = 2; i < f3 - 1; i++)
                {
                    if (f3 % i == 0)
                    {
                        s1++;
                    }
                }
                if (s1 == 0)
                {
                    s2++;
                    numbers[s2] = f3;
                }

            } while (s2 < x);

            List<int> listNumbers = numbers.ToList();

            Console.WriteLine("Fibonacci dizesinde işlem yapmak istediğiniz bir sayı giriniz: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());

            listNumbers.Sort();
            int index = listNumbers.BinarySearch(myNumber);
            int number = (~index) - 1;
            int nearestMin = listNumbers[number];
            int nearestMax = listNumbers[+~index];
            int nearestDif = nearestMax - nearestMin;

            Console.WriteLine("Fibonacci dizesinde " + myNumber + "'den(dan) küçük en büyük asal sayı " + nearestMin + " ile\n" + myNumber + "'den(dan) büyük en küçük asal sayı " + nearestMax + " arasındaki fark ise " + nearestDif + "'dir(dır).");

        }
    }
}
