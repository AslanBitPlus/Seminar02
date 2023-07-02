// Напишите программу, которая принимает на вход трехзначное число и на выходе 
// показывает вторую цифру этого числа


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


// int firstDigit = number / 100;
// int secondDigit = (number - firstDigit * 100) / 10;
// int thirdDigit = number % 10;
if (number < 0)
{
    number *= -1;
}


if (number < 100 || number > 999)
{
    Console.WriteLine($"Число {number} НЕ является трехзначной");
}
else
{
    int secondDigit = (number - (number / 100) * 100) / 10;
    Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");
}

