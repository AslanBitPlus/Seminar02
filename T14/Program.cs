// Напишите программу, которая будет принимать на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

int firstNumber = 7;
int secondNumber = 23;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % firstNumber == 0 && number % secondNumber == 0)
{
    Console.WriteLine($"{number} кратно {firstNumber} и {secondNumber} одновременно");
}
else
{
    Console.WriteLine($"{number} одновременно не кратно {firstNumber} и {secondNumber}");
}

