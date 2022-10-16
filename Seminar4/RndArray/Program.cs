// Задача 3: 
// Напишите программу, которая задаёт массив из 8 случайных элементов 
// и выводит их на экран.
System.Console.WriteLine("Hello, friend! This prorgam create an array from the 8 random numbers and then introduse on console.");
System.Console.WriteLine();
System.Console.Write("[");
    int[] array = new int[8];
    Random rnd = new Random();
for (int i=0; i< array.Length; i++)
{
    array[i] = rnd.Next();
    System.Console.Write(array[i] + "; ");
}
System.Console.Write("]");
