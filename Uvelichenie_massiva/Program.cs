// Этот метод считает массив и выводит начиная с большей цифры


void MaxToMinArray(int[,] array)
{
for(int i = 0;i < m;i++)
{
  for(int j = 0;j < n;j++)
    {
    for(int k = 0;k < n - 1;k++)
     {
      if(array[i, k] < array[i, k + 1])
        {
        int temp = array[i, k + 1];
        array[i, k + 1] = array[i, k];
        array[i, k] = temp;
        }
     }
    }
}
    return;
}
Console.WriteLine();
MaxToMinArray(myarray);
PrintArray(myarray);