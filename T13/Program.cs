// Напишите программу, которая принимает на вход трехзначное число и на выходе 
// показывает вторую цифру этого числа


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 0)
{
    number *= -1;
}

if (number < 100) 
{
    Console.WriteLine("Третьей цифры  НЕТ");
} 


if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }

    int thiedDigit = number % 10;
    Console.WriteLine($"Третья цифра: {thiedDigit}");
}
