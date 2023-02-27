/* Задача 56: Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */


using System;
using static System.Console;

Clear();


int[,] array = GetArray(5, 5, 1, 10);
PrintArray(array);
WriteLine();
int[] sumArray = ChangeRows(array);
Console.WriteLine($"{string.Join(" ", sumArray)}");
// int minElement = MinArray(sumArray);
Console.WriteLine($"индекс строчки с минимальным значением элементов: {MinArray(sumArray)}");


//функция для создания двухмерного массива, заполненого случайными числами
int[,] GetArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(min, max + 1);
    }

  }
  return result;
}


// функция для вывода массива в терминал
void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}

// функция по сложению элементов строк и преобразованию из [,} в одномерный массив
int[] ChangeRows(int[,] inArray)
{
  int[] rowCount = new int[inArray.GetLength(0)];
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      rowCount[i] += inArray[i, j];
    }
  }
  return rowCount;
}

// функция по нахождению минимального элемента в одномерном массиве 
int MinArray(int[] inArray)
{
  int result = 0;
  for (int i = 0; i < inArray.Length; i++)
  {    
      if(inArray[result] > inArray[i]) result = i;
    }
  return result;
}


