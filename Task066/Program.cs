/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите натуральное число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = SumNumbers(m, n);

        Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", m, n, sum);
    }

    static int SumNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + SumNumbers(m + 1, n);
        }
    }
}