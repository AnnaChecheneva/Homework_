// Задача 2. 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FindDoteCrossX()
{
    int[] DoteCross = new int[2];
    DoteCross[0]= Convert.ToInt32((b2-b1)/(k1-k2));
    DoteCross[1]= Convert.ToInt32(k1 * (b2-b1)/(k1-k2) + b1);
    return DoteCross;
}
void PrintArray(int[] array)
{
    int i = 0;
    System.Console.Write($"[{array[i]};{array[i+1]}]");
    System.Console.WriteLine();
}
System.Console.WriteLine("Data for line 1:");
    int k1 = Prompt("Enter value for k1 --->");
    int b1 = Prompt("Enter value for b1 --->");
    System.Console.WriteLine("Data for line 2:");
    int k2 = Prompt("Enter value for k2 --->");
    int b2 = Prompt("Enter value for b2 --->");
int[] DoteCross = FindDoteCrossX();
System.Console.WriteLine("Counting.....");
System.Console.WriteLine("Dote coordinate of cross lines:");
PrintArray(DoteCross);