// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] a = new double[5, 10];
// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble()*10; 
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int[,] a = new int[4, 4];
// Random random = new Random();
// FillArrayRandomNumbers(a);

// if (4 > a.GetLength(0) || 4 > a.GetLength(1))
// {
//  Console.WriteLine("такого элемента нет");
// }
// else
// {
//  Console.WriteLine($"значение элемента {4} строки и {4} столбца равно {a[4-1,4-1]}");
// }

// PrintArray(a);

// void FillArrayRandomNumbers(int[,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//         {        
//  for (int j = 0; j < array.GetLength(1); j++)
//             {
//  array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//  Console.Write("[ ");
//  for (int j = 0; j < array.GetLength(1); j++)
//         {
//  Console.Write(array[i,j] + " ");
//         }   
//  Console.Write("]");
//  Console.WriteLine(""); 
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] a = new int[4, 4];
// Random random = new Random();
// FillArrayRandoma(a);


// for (int j = 0; j < a.GetLength(1); j++)
// {
//  double avarage = 0;
//  for (int i = 0; i < a.GetLength(0); i++)
//     {
//  avarage = (avarage + a[i, j]);
//     }
//  avarage = avarage / 4;
//  Console.Write(avarage + "; ");
// }
// Console.WriteLine();

// PrintArray(a);

// void FillArrayRandoma(int[,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//  for (int j = 0; j < array.GetLength(1); j++)
//         {
//  array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//  Console.Write("[ ");
//  for (int j = 0; j < array.GetLength(1); j++)
//         {
//  Console.Write(array[i, j] + " ");
//         }
//  Console.Write("]");
//  Console.WriteLine("");
//     }
// }