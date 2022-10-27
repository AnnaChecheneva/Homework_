// Задача 2: 
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
int InputNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number-1;
}
int[,] CreateArray()
{
    int[,] array = new int[4,4];
    Random rnd = new Random();
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-10, 10);
        }
        System.Console.WriteLine();
    }
    return array;
}
void PrintArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j]}\t");
            }
        }
        System.Console.WriteLine();
    }
}

bool FindElement(int[,] array, int rows, int colum)
{
 if ( -1 < rows & rows < array.GetLength(0) & -1 < colum & colum< array.GetLength(1))
 {
    return true;
 }
 return false;  
}

int[,] matrix = CreateArray();
System.Console.WriteLine("Current array:");
PrintArray(matrix);
System.Console.WriteLine("\nEnter the position of search element:");
int rows = InputNumber("The row ---> ");
int colum = InputNumber("The colum ---> ");
System.Console.WriteLine("\nSearching....\n");

void ResultShow(int[,] array, int rows, int colum)
{
if (FindElement(matrix, rows, colum) == true)
{
    System.Console.WriteLine($"Great!\n Program find your element ---> {matrix[rows, colum]}");
}
if (FindElement(matrix, rows, colum) == false)
{
    System.Console.WriteLine("The element not found, sorry. Try again!");
}
}

ResultShow(matrix, rows, colum);