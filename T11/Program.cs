﻿// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру

// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100,1000); // 999 + 1
Console.WriteLine($"Случайное трехзначное число -> {number}");

int firstDigit = number / 100;
// int secondDigit = (number - firstDigit * 100) / 10;
// int thirdDigit = (number - firstDigit * 100 - secondDigit * 10);
int thirdDigit = number % 10;

Console.WriteLine($"Первая цифра -> {firstDigit}");
// Console.WriteLine($"Вторая цифра -> {secondDigit}");
Console.WriteLine($"Третья цифра -> {thirdDigit}");

Console.WriteLine($"Ответ -> {firstDigit * 10 + thirdDigit}");