/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
// See https://aka.ms/new-console-template for more information


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

Console.Write("Задайте значение x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение y = ");
int y = Convert.ToInt32(Console.ReadLine());

if (x <= m && y <= n)
{
    Console.Write("{0,6:f1}  ", array[x, y] );
}
else
{  
    Console.Write("Такого числа в массиве нет");
}
