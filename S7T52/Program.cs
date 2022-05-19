/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/
Console.Write("Задайте значение m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение n = ");
int n = Convert.ToInt32(Console.ReadLine());

Random random = new Random();

int[,] array = new int[m, n];
double sum = 0;
double res;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(0, 10) ;
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0,1:}  ", array[i, j]); 
        //sum += array[i, j];    
    }
    //res = sum / m;
    System.Console.WriteLine();    
}
for(int j=0; j< n; j++)
{
    for(int i=0; i < m; i++)
    {
        sum += Convert.ToDouble(array[i, j]);
    }
    res = sum / n * 1.0;  
    Console.Write("{0,3:f1} ", res);
    sum = 0; 
}
