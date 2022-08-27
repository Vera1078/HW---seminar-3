// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

Console.WriteLine("Таблица кубов");

for (int i = 1; i<=number; i++)
{
        Console.WriteLine(Math.Pow(i,3));
}
