// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numA = GetNum("Введите число A: ");
int numB = GetNum("Введите число B: ");
int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int pow = Pow(numA, numB);
int Pow(int x, int y)
{
    int pow = 1;
    for (int i = 0; i < y; i++) pow = pow * x;
    return pow;
}
Console.WriteLine($"{numA}, {numB} -> {pow}");

