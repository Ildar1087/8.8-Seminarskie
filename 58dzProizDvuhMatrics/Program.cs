/* Задача 58: Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18             */

Console.Clear();
Console.Write("введите число строк в первом массиве: ");
int strNum1 = int.Parse(Console.ReadLine());
Console.Write("введите число столбцов в первом массиве: ");
int stolNum1 = int.Parse(Console.ReadLine());
Console.Write("введите число строк во втором массиве: ");
int strNum2 = int.Parse(Console.ReadLine());
Console.Write("введите число столбцов во втором массиве: ");
int stolNum2 = int.Parse(Console.ReadLine());
int[,] array1 = AddsDoubleArray(strNum1, stolNum1, 1, 6);
int[,] array2 = AddsDoubleArray(strNum2, stolNum2, 1, 6);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

if (array1.GetLength(1) == array2.GetLength(0))  //проверка матриц на равность, защита от дурака)))
{
  int[,] MultipliedMatrix = ProizvedMatrix(array1, array2);
  PrintArray(MultipliedMatrix);
}
else Console.WriteLine("не равные матрицы для умножения");

int[,] AddsDoubleArray(int numberOfRows, int numberOfColumns, int minValue, int maxValue)
{
  int[,] array = new int[numberOfRows, numberOfColumns];
  for (int i = 0; i < numberOfRows; i++)
  {
    for (int j = 0; j < numberOfColumns; j++)
    {
      array[i, j] = new Random().Next(minValue, maxValue);
    }
  }
  return array;
}

int[,] ProizvedMatrix(int[,] matr1, int[,] matr2)
{
  int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
  int sum = 0;                  // sum - переменная для получения элементов новой матрицы
  for (int i = 0; i < matr1.GetLength(0); i++)  // i - кол-во строк в 1 матрице
  {
    for (int j = 0; j < matr2.GetLength(1); j++)  // j - кол-во столбцов во 2 матрице
    {
      for (int k = 0; k < matr1.GetLength(1); k++)  // k - количество столбцов в 1
      {                                               // матрице и строк во 2 матрице
        sum += (matr1[i, k] * matr2[k, j]);  //перемножаем матрицы и результат записываем в result
      }
      result[i, j] = sum;
      sum = 0;                    //счетчик обнуляем для следующей итерации
    }
  }
  return result;
}


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
