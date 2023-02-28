/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04   
12 13 14 05
11 16 15 06
10 09 08 07           */


int[,] array = new int[5, 5];     //пустой массив для заполнения в функции SpiralArray
int itr = 0;
int N = 0;
int Nmax = array.GetLength(0) * array.GetLength(1);
while (N < Nmax)
{
  N = SpiralArray(array, N, itr, Nmax);
  itr++;
}
PrintArr(array);


//функ. спирального заполнения последовательными числами контура любого двумерного массива
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
  for (int i = itr + 1; i < n; i++) /* в каждой строке убираем по одному элементу за одну итерацию 
  прибавляя к itr+1 за проход */
  {
    N++; array[i, m - 1] = N;
  }
  if (N == Nmax) { return N; }
  for (int j = m - 2; j > itr; j--) { N++; array[(n - 1), j] = N; } /* в столбцах убираем по 2 элемента
  во втором проходе и так увеличивая itr дальше*/
  for (int i = n - 1; i > itr; i--) { N++; array[i, itr] = N; }  /* в строках убираем по одному элементу
  и так увеличивая itr дальше*/
  return N;
}

// функ. для вывода массива
void PrintArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:D2} ", array[i, j]); /*"{0:D2} ", делает двухзначными однозначные числа -
      добавляет нули к цифрам от 1 до 9ти и пробел между цифрами при выводе массива*/
    }
    System.Console.WriteLine(""); // горизонтальный "пробел" между строчками в выводящемся массиве
  }
  
}

