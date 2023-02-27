/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07           */



Console.Clear();
Console.Write("Enter the number of the first rank elements: ");
int rank1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of the second rank elements: ");
int rank2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of the third rank elements: ");
int rank3 = int.Parse(Console.ReadLine());
GetTripleArray(rank1, rank2, rank3);

void GetTripleArray(int rank1Num, int rank2Num, int rank3Num)
{
  int[,,] result = new int[rank1Num, rank2Num, rank3Num];
  for (int i = 0; i < rank1Num; i++)
  {
    for (int j = 0; j < rank2Num; j++)
    {
      for (int k = 0; k < rank3Num; k++)
      {
        result[i, j, k] = rank1Num * rank1Num * i + rank2Num * j + k + 10;
        Console.Write($"{result[i, j, k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}