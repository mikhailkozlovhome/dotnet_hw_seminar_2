// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int enterNumber (string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = enterNumber("Введите 3-х значное число");

if (number > 100 && number < 1000)
{
    int secondDigit = (number / 10) % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
}
else
{
    System.Console.WriteLine($"Число {number} не 3-х значное");
}