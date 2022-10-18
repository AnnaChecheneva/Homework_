// Задание 2 
// Задайье массив.
// Найдите сумму элементов, стоящих на нечетных позициях.
System.Console.WriteLine("Hello, friend! This program create an array and find sim of nonenen elements from cuurent array!");
int[] CreateArray (int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit);
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

int FindSumNonevenElement(int[] array)
{
    int NonEVenSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int j = i % 2;
        if ( j == 0)
        {
            NonEVenSum += array[i];
        }
    }
    return NonEVenSum;
}
int[] arr = CreateArray(26, -100, 100);
System.Console.WriteLine();
System.Console.WriteLine("Current array:");
PrintArray(arr);
int Result = FindSumNonevenElement(arr);
System.Console.WriteLine();
System.Console.WriteLine("Calculating.......");
System.Console.WriteLine();
System.Console.WriteLine($"Count sum noneven elements ---> {Result}");