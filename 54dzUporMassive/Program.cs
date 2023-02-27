/* //  Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
*/


using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
WriteLine();
int [,] mass = PrintArrayExit(array);
PrintArray(mass);

WriteLine();



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



int[,] PrintArrayExit(int[,] array) // функ. по сортировке убывания строк массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {                                                // пробегаемся по строчкам массива и 
    for (int j = 0; j < array.GetLength(1); j++) // переставляем элементы в порядке возрастания
    {
      for (int k = 0; k < array.GetLength(1) - 1 - j; k++) // "-j" для сокращения числа ненужных итераций
      {
        if (array[i, k] < array[i, k + 1])
        {                                   
          int temp = array[i, k];         // заводим новую переменную и в ней сравниваем соседние элементы и
                    array[i, k] = array[i, k + 1];    //меняем местами, если последующий  меньше предыдущего
          array[i, k + 1] = temp;
        }
      }
    }
  }
  return array;
}

