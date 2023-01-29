// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int num = GetNum("Введите размер массива: ");
int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] arr = new int[num];
int lenght = arr.Length;

for (int i = 0; i < lenght; i++)
{
    arr[i] = new Random().Next(0, 100);
}

void PrintArray(int[] array)
{
    int lenght = array.Length;
    Console.Write($"{num} -> [");
    for (int i = 0; i < lenght - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    if (lenght > 0) Console.Write($"{array[lenght - 1]}");
    Console.WriteLine("]");
}
PrintArray(arr);