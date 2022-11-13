// Задача 3:
//  Задайте две матрицы.
//   Напишите программу, которая будет находить произведение двух матриц.
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

int[,] ArrayMult(int[,] matrix1, int[,] matrix2, int rows, int colums)
    {       
        int[,] Multmatrix = new int[rows, colums];

        for (var i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Multmatrix[i, j] = 0;

                for (int k = 0; k < colums; k++)
                {
                    Multmatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return Multmatrix;
    }

    
int rows = InputNumber("Please, input a rows value --->");
int colums = InputNumber("Please, input a colums value --->");
int[,] Arr1 = CreateArray(rows, colums);
int[,] Arr2 = CreateArray(rows, colums);
System.Console.WriteLine("Array 1:");
PrintArray(Arr1);
System.Console.WriteLine();
System.Console.WriteLine("Array 2:");
PrintArray(Arr2);
System.Console.WriteLine();
int[,] result = ArrayMult(Arr1, Arr2, rows, colums);
System.Console.WriteLine("Multiply array:");
PrintArray(result);