// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму. Если
// первое число не кратно второму, программа выводит остаток от
// деления

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторвое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"{firstNumber} кратно {secondNumber}");
}
else
{
    Console.WriteLine($"{firstNumber} не кратно {secondNumber}, остаток {firstNumber % secondNumber}");
}
