// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int enterNumber(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

bool isHoliday(int dayNumb)
{   
    int[] weekDay = {0, 0, 0, 0, 0, 1, 1};
    return weekDay[dayNumb - 1] == 1;
}

int number = enterNumber("Введите номер дня недели");

if (number > 0 && number < 8)
{
    if (isHoliday(number))
    {
        System.Console.WriteLine($"{number}-й день недели является выходным");
    }
    else
    {
        System.Console.WriteLine($"{number}-й день недели не является выходным");
    }    
}
else
{
    System.Console.WriteLine("В неделе 7 дней :), введите правильное число!");
}
