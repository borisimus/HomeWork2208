/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
Console.Clear();
int GetNumberSecond(int number)
{
    return number = number / 10 % 10;
}
int random = new Random().Next(100, 1000);
//int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{random}");
//Console.WriteLine($"{num}");
Console.WriteLine($"вторая цифра {GetNumberSecond(random)}");
//Console.WriteLine($"вторая цифра {GetNumberSecond(num)}");