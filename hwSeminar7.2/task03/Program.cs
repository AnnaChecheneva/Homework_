// Задача 3.
//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
System.Console.WriteLine("Hello, friend! The program finds the arithmetic mean of the elements in each column.");
int[,] RndArray()
{
    int[,] array = new int[5, 5];
    Random rnd = new Random();
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-10, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");;
        }
        System.Console.WriteLine();
    }    
}
void AvergeColum(int[,] array)
{
    System.Console.WriteLine("Ar. mean of the each column:");
     int line = 0;
    for ( int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        line +=1;
        for (int j=0; j<array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        System.Console.Write($"column {line} ---> ");
        double res = (double) sum / 3;
        System.Console.WriteLine(Math.Round(res, 2));
    } 
}
int[,] array = RndArray();
System.Console.WriteLine("\nCurrent array:");
PrintArray(array);
System.Console.WriteLine("\nCounting...\n");
AvergeColum(array);