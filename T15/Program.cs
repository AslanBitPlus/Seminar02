// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным


Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 1 || number > 7)
{
    Console.WriteLine($"Число: {number} не соответствует указанному диаппазону от 1 до 7");;
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
 