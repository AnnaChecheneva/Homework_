// Задача 2: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
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

void FindMaxSumRow(int[,] array)
{
    int sum = 0; 
    int MaxR = 0;
     for (int i = 0; i< array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j< array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
        }
        System.Console.WriteLine($" Sum elements row {i+1} --> {sumRow}");
        if ( sumRow > sum)
        {
            sum = sumRow;
            MaxR = i;
        }
    }
    System.Console.WriteLine();
    Console.WriteLine($"The number of row with max sum {sum} ---> {MaxR +1} ");

}

int rows = InputNumber("Please, input a rows value --->");
int colums = InputNumber("Please, input a colums value --->");
int[,] CurArray = CreateArray(rows, colums);
System.Console.WriteLine("Current array:");
PrintArray(CurArray);
System.Console.WriteLine();
FindMaxSumRow(CurArray);
