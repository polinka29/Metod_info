// Программа считает сумму в строчках и выводит на печать сумму и в какой строке она ее нашла

int SumArray(int[,] myarray, int i)
{
int sum = myarray[i, 0];
for(int j = 1;j < n;j++)
    {
    sum += myarray[i, j];
    }
return sum;
}

int minRows = 0; //Rows это строка
int minSum = SumArray(myarray, 0);
for(int i = 1;i < m;i++)
{
  int SumRows = SumArray(myarray, i);
  if(minSum > SumRows)
    {
     minSum = SumRows;
     minRows = i;
    }
}

Console.WriteLine($"Минимальная сумма: {minSum} находится в {minRows+1} строке");