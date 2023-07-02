﻿// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно чмсло вадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет


Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber || secondNumber == firstNumber * firstNumber)
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Одно число НЕ является квадратом другого");
}

