﻿
// Напишите программу, которая выводит случайное число
// из отрезка [10,99] и показывает наибольшую цифру

// 78 -> 8
// 12 -> 2
// 85 -> 8
int number = new Random().Next(10,100); // 99 + 1
Console.WriteLine($"Случайное число из диаппазанов 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
// }
// else if (firstDigit < secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
// }
// else
// {
//     Console.WriteLine("Цифры равны");
// }

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");
