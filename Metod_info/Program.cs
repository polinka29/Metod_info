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

// Этот метод создает новый массив, т.е массив в массиве, он должен быть выше PrintArray
void Newarray(int[,] array)
{
for(int i = 0;i < m;i++)
{
    for(int j = 0;j < n;j++)
    {
    array[i, j] = new Random().Next(10);
    }
}
    return;
}
Newarray(myarray);

// Этот метод выводит на печать массив,если выше использовать 
//метод нового массива,то выведет новый,если без метода.то повторит сам массив на печать
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


