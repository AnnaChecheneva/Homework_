// Задача 1: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.
int InputNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] CreateArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
        System.Console.WriteLine();
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] RangeArray (int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
           for ( int k = 0; k < array.GetLength(1)-1-j; k++)
           {
           if ( array[i, k] < array[i, k+1])
            {
            int temp = array[i, k];                
            array[i, k] = array[i, k+1];               
            array[i, k+1] = temp;
            }
           }
        }
    
    }
    return array;
}
int rows = InputNumber("Please, input a rows value --->");
int colums = InputNumber("Please, input a colums value --->");
int[,] CurArray = CreateArray(rows, colums);
System.Console.WriteLine("Current array:");
PrintArray(CurArray);
System.Console.WriteLine();
System.Console.WriteLine("Ranged array:");
int[,] RangeArr = RangeArray(CurArray);
PrintArray(RangeArr);