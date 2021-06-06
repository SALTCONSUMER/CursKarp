using System.Windows;
using System.Reflection;
using System.Diagnostics;
using System;


namespace CursKarp
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите n");
                int n = 0;
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите число от 1 до 2147483647");
                    continue;

                }
                if (n <= 0)
                {
                    Console.WriteLine("Введите число от 1 до 2147483647");
                    continue;
                }

                int[] nums = new int[n];
                Console.WriteLine("Введите числа последовательности построчно");
                int index = 0;
                while  (index < n)
                {
                    try
                    {
                        nums[index] = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите число от 0 до 2147483647");
                        continue;
                    }
                    index++;
                }
                int[,] TMatr = new int[n, n];
                BuildMatr(n, nums, ref TMatr);
                int[,] SMatr = TMatr;
                SortMatr(n, ref SMatr);
                Console.WriteLine("Матрица сформирована");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(SMatr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                break;
            }

        }

       public static void BuildMatr(int n, int[] nums, ref int[,] Matr)
        {
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += nums[j];
                    Matr[i, j] = sum;
                }

            }

        }
        public static void SortMatr(int n, ref int[,] Matr)
        {
            for (int s = 0; s < n; s++)
            {
                int temp;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Matr[s, i] < Matr[s, j])
                        {
                            temp = Matr[s, i];
                            Matr[s, i] = Matr[s, j];
                            Matr[s, j] = temp;
                        }
                    }
                }
            }
        }
    }

}