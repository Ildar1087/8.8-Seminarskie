/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04   
12 13 14 05
11 16 15 06
10 09 08 07           */


int[,] array = new int[5, 5];
int itr = 0;
int N = 0;
int Nmax = array.GetLength(0) * array.GetLength(1);
while (N < Nmax)
{
  N = SpiralArray(array, N, itr, Nmax);
  itr++;
}
PrintArr(array);

int SpiralArray(int[,] array, int N, int itr, int Nmax)
{
  int n = array.GetLength(0) - itr;
  int m = array.GetLength(1) - itr;
  for (int j = itr; j < m; j++)
  {
    N++; array[itr, j] = N;
  }
  if (N == Nmax)
  {
    return N;
  }
  for (int i = itr + 1; i < n; i++)
  {
    N++; array[i, m - 1] = N;
  }
  if (N == Nmax) { return N; }
  for (int j = m - 2; j > itr; j--) { N++; array[(n - 1), j] = N; }
  for (int i = n - 1; i > itr; i--) { N++; array[i, itr] = N; }
  return N;
}

void PrintArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:D2} ", array[i, j]);
    }
    System.Console.WriteLine("");
  }
  
}

