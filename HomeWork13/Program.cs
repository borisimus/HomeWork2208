/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Clear();
int GetNumberThree(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьего числа нет!");
        return -1;
    }
    int result = 0;
    while (number > 999)
    {
        number /= 10;
        result = number % 10;
    }
    if (number < 1000 || number >= 100);
    {
        result = number % 10;
    }
    return result;
}
Console.Write("Третья цифра числа ");
Console.WriteLine(GetNumberThree(Convert.ToInt32(Console.ReadLine())));