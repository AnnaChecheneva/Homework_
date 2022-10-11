Console.WriteLine("Hello, Friend!");
// Задача 4:
//  Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели.");
int NumDay = Convert.ToInt32(Console.ReadLine());
if ( (NumDay<1) || (NumDay>7))
{
    System.Console.WriteLine("Увы! Вы ввели несуществующий номер дня недели! Попробуйте еще раз =)");
}
else 
{
bool Weekend = (NumDay >= 6)&(NumDay<=7);
System.Console.Write(Weekend);
}