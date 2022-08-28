/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.WriteLine("Задача 15");

Console.Write("Введите день недели: ");
int dayN = Convert.ToInt32(Console.ReadLine());

void CheckWeakend (int dayN)
{
    if (dayN == 7 || dayN == 6)
    {
        Console.WriteLine($"День недели {dayN} выходной -> ДА");
    }
    else if (dayN > 7 || dayN < 1)
    {
       Console.WriteLine("Такого дня недели не существует!");
    }
    else
    {
        Console.WriteLine($"День недели {dayN} выходной -> НЕТ");
    }
}
CheckWeakend(dayN);