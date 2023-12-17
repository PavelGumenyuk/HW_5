// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// using System.Runtime.Serialization.Formatters;

// Console.Write("ВВедите размер m массива:");

// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[m, n];
// Console.Write("Введите позицию строки:");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца:");
// int n2 = Convert.ToInt32(Console.ReadLine());
// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.NextDouble();
//             Console.Write($"{randomArray[i, j]:F2}");
//             {
//                 Console.WriteLine();
//             }
//         }
//         mas (m, n);
//         if (m2 < 1 || n2 <1)
//         Console.Write("Позиции строк не могут быть отрицательными");
//         else if (m2 <= m + 1 && n2 <= n + 1)
//         Console.Write($"Значение элемента равно {randomArray[m2 - 1, n2 - 1]: F2}");
//         else Console.Write("Такого элемента нет в массиве");
//     }
// }


// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// int [,] intArray = new int [4, 4];
// Random rnd = new Random();
// for (int i = 0; i < 4; i++)
// for (int j = 0; j < 4; i++)
// intArray[i, j] = rnd.Next(0, 10);
// int[] intTemp1 = new int [4];
// int[] intTemp2 = new int [4];
// for (int i = 0; i < 4; i++)
// {
//     intTemp1[i] = intArray[0, i];
//     intTemp2[i] = intArray[3, i];
// }
// int[] intSwap = new int[4];
// Array.Copy(intTemp1, intSwap, 4);
// Array.Copy(intTemp2, intTemp1, 4);
// Array.Copy(intSwap, intTemp1, 4);
// Console.ReadKey();


// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


// Console.Write("ВВедите размер m массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите расмер n массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int [m, n];

// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.Next(1, 9);
//         }
//     }
// }
// void printm (int[,] array)
// {
//     int i, j;
//     for (i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }
// mas(m, n);
// Console.WriteLine("\nИсходный массив:");
// printm(randomArray);

// int SumLine(int[,] array, int i)
// {
//     int sum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     return sum;
// }

// int minSum =1;
// int sum = SumLine(randomArray, 0);
// for (int i = 1; i < randomArray.GetLength(0); i++)
// {
//     if (sum > SumLine(randomArray, i))
//     {
//         sum = SumLine(randomArray, i);
//         minSum = i + 1;
//     }
// }
// Console.WriteLine($"\nСтрока с наименьшей суммой элементов:{minSum}");