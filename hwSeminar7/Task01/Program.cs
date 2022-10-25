int[] CreateArray(int M)
{
    int[] array = new int[M];
    Random rnd = new Random();
    for (int i = 0; i< M; i++)
    {
        array[i]=rnd.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("Generate array:");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int CountPositive(int[] array, int M)
{
    int count = 0;
    for( int i = 0; i < M; i++)
    {
        if (array[i]>=0)
        {
            count += 1;
        }
    }
    return count;
}
System.Console.WriteLine("Hello, friend! This program check certain amount of a random numbers and count quantity of a positive number. Cool?");
System.Console.Write(" Enter how many numbers do you want to add ---> ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(M);
System.Console.WriteLine();
PrintArray(arr);
int res = CountPositive(arr, M);
System.Console.WriteLine("\nCounting....\n");
System.Console.WriteLine($" Count positive numbers ---> {res}");