/*Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных 
числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;

class Program 
{ 
    static void Main(string[] args) 
    { 
        int m = 2, n = 3; // задаем значения m и n

        int result = Ackermann(m, n); // вызываем функцию Аккермана

        Console.WriteLine("A({0}, {1}) = {2}", m, n, result); // выводим результат
    } 

    // Функция для вычисления функции Аккермана
    static int Ackermann(int m, int n) 
    { 
        if (m == 0) // базовый случай
        { 
            return n + 1; 
        } 
        else if (n == 0) // еще один базовый случай
        { 
            return Ackermann(m - 1, 1); 
        } 
        else // рекурсивный случай
        { 
            return Ackermann(m - 1, Ackermann(m, n - 1)); 
        } 
    } 
}
