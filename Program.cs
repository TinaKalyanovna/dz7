// 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


/*

Random random = new Random();
double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = random.NextDouble() * 100;
            Console.Write("{,}", matrix[i, j]);
        }
    }
   Console.WriteLine();
}

 void PrintMatrix(int[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int m = 0; m < matrix.GetLength(1) ; m++)
         {
             Console.Write(matrix[i,m] + "\t");
         }
         Console.WriteLine();
     }
 }


 int[,] resultMatrix = GetMatrix(-10,10);
 PrintMatrix(resultMatrix);


*/


// 50. Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет

/*
Console.WriteLine("Введите размер двумерн. массива : ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++) 
{
  for (int j = 0; j < array.GetLength(1); j++)
    array [i, j] = Convert.ToInt32(new Random().Next(0,100)); 
}

for (int i = 0; i < array.GetLength(0); i++) 
{
  for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + "\t");
    Console.WriteLine();
}
Console.WriteLine();


*/


// 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом 
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());
int [,]arr=new int [n, m];
int []sum=new int [m];
Random ran = new Random();
int avg = Convert.ToInt32(Console.ReadLine());
for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}
Console.ReadLine();

*/

