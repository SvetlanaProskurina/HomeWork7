/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
void FillArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round(new Random().NextDouble()*10,3);
            }
        }
}
void PrintArrayRazm(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
         for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
           
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n=Convert.ToInt32(Console.ReadLine());
double [,] array1 = new double [m,n];
double [,] array2 = new double [m,n];
FillArray(array1);
PrintArrayRazm(array1);
