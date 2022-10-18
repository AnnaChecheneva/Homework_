// Задача 3
// Difference between min value and max value from array.
System.Console.WriteLine("Hello, friend! This program create an array and find difference between max and min value!");
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

int FindMaxValue(int[] array)
{
    int max = array[0];
    for ( int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
int FindMinValue(int[] array)
{
    int min = array[0];
    for ( int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
System.Console.WriteLine();
int[] arr = CreateArray(26, -20, 20);
PrintArray(arr);
System.Console.WriteLine();
int Max = FindMaxValue(arr);
int Min = FindMinValue(arr);
System.Console.WriteLine($"Minimal value ---> {Min}");
System.Console.WriteLine($"Maximal value ---> {Max}");

int FindDiff()
{
    int diff = Max - Min;
    return diff;
}
System.Console.WriteLine();
int diff = FindDiff();
System.Console.WriteLine($"Difference between {Min} and {Max} ---> {diff}");