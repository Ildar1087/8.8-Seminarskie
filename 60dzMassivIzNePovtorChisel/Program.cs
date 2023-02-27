/*  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(0,1,0) 41(0,1,1)
27(1,0,0) 90(1,0,1)
26(1,1,0) 55(1,1,1)   */

Console.Clear();
Console.Write("введите мерность массивов: ");
int numb1 = int.Parse(Console.ReadLine());
Console.Write("введите число строк в массиве: ");
int numb2 = int.Parse(Console.ReadLine());
Console.Write("введите число столбцов в массиве: ");
int numb3 = int.Parse(Console.ReadLine());
int[,,] array1 = CreateArray(numb1, numb2, numb3);
PrintArray(array1);
Console.WriteLine();



// функ. по созданию нужной размерности массива 

int[,,] CreateArray(int numb1, int numb2, int numb3)
{
  int[,,] array = new int[numb1, numb2, numb3]; // пустой двух-трёх-четырёх зависит от пользователя
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = new Random().Next(0, 99); // заполняем случайными числами массивы
      }
    }
  }
  Console.WriteLine(" "); // перенос на одну строчку от задаваемых значений пользователя
  return array;
}

// функ. для вывода массива
void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($" {array[i, j, k],1}({i},{j},{k}) ");  // выводим массив поэлементно и с индексом
      }
      Console.WriteLine(""); // пустая строка для разделения между массивами по вертикали
    }
    Console.WriteLine("");   // пустая строка для разделения между массивами по горизонтали
  }
}




