// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int enterNumber(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int thirdDigit(int numb)
{   
    while (numb / 1000 > 0)
    {
        numb /= 10;
    }
    return numb % 10;
}

int number = enterNumber("Введите число");

if (number > 99)
{
    int digit = thirdDigit(number);
    System.Console.WriteLine($"Третья цифра числа {number} равна {digit}");
}
else
{
    System.Console.WriteLine($"У числа {number} нет третьей цифры");
}
