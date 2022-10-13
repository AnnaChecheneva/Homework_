// Задача 2: 
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
System.Console.WriteLine("===================================");
System.Console.WriteLine(" Hello, Friend! This program accept coordinates with three dotes and find the distance between them.");
System.Console.WriteLine("===================================");
const int X = 0;
const int Y = 1;
const int Z = 2;
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputDote(int point)
{
    int[] CoorDote = new int[3];
    CoorDote[X] = Prompt($"Please, Enter X({point}) --->");
    CoorDote[Y] = Prompt($"Please, Enter Y({point}) --->");
    CoorDote[Z] = Prompt($"Please, Enter Z({point}) --->");
    return CoorDote;
}

int[] Dote1 = InputDote(1);
int[] Dote2 = InputDote(2);
int Pow2(int arg)
{
    return arg*arg;
}

double lenght =Math.Sqrt(Pow2(Dote1[X]-Dote2[X])+Pow2((Dote1[Y]-Dote2[Y]))+Pow2((Dote1[X]-Dote2[X])));
System.Console.WriteLine("Calculating....");
System.Console.WriteLine("===================================");
System.Console.WriteLine($"{lenght:f3}");