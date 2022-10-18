// Задача 1: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
System.Console.WriteLine("Hello, friend! This program count a even number from the current array and introduse this count on console.");
int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i= 0; i<array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        int j = array[i] % 2;
        if(j == 0)
        {
            count +=1;
        }
    }
    return count;
}
int[] arr = CreateArray(30, 0, 999);
System.Console.WriteLine("Current array:");
PrintArray(arr);
System.Console.WriteLine();
int result = CountPositive(arr);
System.Console.WriteLine("Calculating.......");
System.Console.WriteLine();
System.Console.WriteLine($"Count even value from array ----> {result}");