// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
/*
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()); 

double[] myArray = new double[size]; 

for (int i = 0; i < size; i++)
{
    Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
    myArray[i] = double.Parse(Console.ReadLine());
}

double min = myArray[0]; 
double max = myArray[0]; 

for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] < min)
    {
        min = myArray[i];
    }
    if (myArray[i] > max)
    {
        max = myArray[i];
    }
}

double diff = max - min; 
Console.WriteLine($"Разница между максимальным {max} и минимальным элементом {min} вещественных чисел: " + diff);
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int size = 10;
Random rnd = new Random();

double[] myArray = new double[size];
for (int i = 0; i < size; i++)
{
    myArray[i] = rnd.NextDouble() * 10;
}

Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write(myArray[i] + " ");
}
Console.WriteLine();

double sum = 0;
for (int i = 1; i < size; i += 2)
{
    sum += myArray[i];
}

Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);
*/
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int size = 10;
Random rnd = new Random();

int[] myArray = new int[size];
for (int i = 0; i < size; i++)
{
    myArray[i] = rnd.Next(100, 1000);
}

Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write(myArray[i] + " ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < size; i++)
{
    if (myArray[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine("Количество четных чисел в массиве: " + count);
*/