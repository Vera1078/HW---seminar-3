// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

using System;

namespace Seminar3
{
    class Program
    {
         static void Main(string[] args)
        {

 System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

string str = Convert.ToString (number);
int d = 0;
int length = str.Length;

for (int i = 0; i < length / 2; i ++)
{

if (str [i] == str [length - 1 - i])
{
    d ++;
}
}

if (d == length / 2)
{
    System.Console.WriteLine($"Число {number} является палиндромом.");
}
else 
{
    System.Console.WriteLine($"Число {number} не является палиндромом.");
}
        }
    }
}
