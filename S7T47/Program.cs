/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
*/

Console.Write("Задайте значение m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение n = ");
int n = Convert.ToInt32(Console.ReadLine());

Random random = new Random();

double [,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.NextDouble() * 10 - 5;
        
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0,6:f1}  ", array[i, j] );     
    }
    Console.WriteLine();    
}