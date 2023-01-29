// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = GetNum("Введите число: ");
int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int sum = SumNum(num);
int SumNum(int num)
{
    int temp = num;
    int sum = 0;
    while (temp > 0)
    {
        sum = sum + temp % 10;
        temp = temp / 10;
    }
    return sum;
}
Console.WriteLine($"{num} -> {sum}");