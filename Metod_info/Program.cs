// Всегда можно использовать для создания двухмерного метода с рандомными числами этот код:
int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
int[,] myarray = new int[m, n];
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        myarray[i, j] = new Random().Next(1, 10);
        Console.Write($"{myarray[i , j]} ");
    }
    Console.WriteLine();
}

// Для вывода на печать еще раз типо дубля этот метод:
void PrintArray(int[,] array)
{
for(int i = 0;i < m;i++)
    {
    for(int j = 0;j < n;j++)
      {
       Console.Write(array[i, j] + " ");
      }
    Console.WriteLine();
    }
    return;
}
Console.WriteLine();
PrintArray(myarray);