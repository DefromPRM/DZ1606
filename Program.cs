﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Веедите число N:");
// int num = Convert.ToInt32(Console.ReadLine());
// int finish_num = 1;
// string PrintNumbers(int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         return num1.ToString();
//     }
//     return (num1 + " " + PrintNumbers(num1 - 1, num2));
// }
// Console.WriteLine(PrintNumbers(num, finish_num));


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// int Sum(int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         return num1;
//     }
//     return (num1 + Sum(num1 + 1, num2));
// }
// Console.WriteLine(Sum(m, n));


// Задача 68: Напишите программу 
// вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int A(int n, int m)
// {
//     if (n == 0) return m + 1;
//     if (n != 0 && m == 0) return A(n - 1, 1);
//     if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
//     return A(n, m);
// }
// Console.WriteLine(A(n, m));