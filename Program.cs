//Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
/*
void stepen (int num1, int step)
{
    double result = Math.Pow(num1, step);
    Console.WriteLine(result);
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число два - степень");
int step = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {num1} в степени {step} равняется ");
stepen(num1, step);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int summa(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result = summa(num);
Console.Write($"Сумма цифр числа {num} равняется {result}");
*/
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
using System;

class Program
{
    static void Main()
    {
        int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.ReadKey();
    }
}