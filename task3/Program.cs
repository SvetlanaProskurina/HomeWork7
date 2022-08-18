/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void fillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
}
void printArrayRazm(int[,] array)

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
void PrintArray(int[] array)
    {
        int counts = array.Length;
        int position = 0;
        while (position < counts)
            {
                Console.Write($"{array[position]} ");
                position++;
            }
    }
Console.WriteLine("Введите количество строк массива");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n=Convert.ToInt32(Console.ReadLine());
int [,] array1 = new int [m,n];
fillArray(array1);
printArrayRazm(array1);
Console.WriteLine("");


int [] SredneArifmetichColumn (int[,] arr1)
{
    int [] arrSredneArifmetichColumn = new int[arr1.GetLength(1)];
    int SumColumn=0;
    for (int j=0; j<arr1.GetLength(1);j++)
    {
         for (int i=0; i<arr1.GetLength(0);i++)
        {
            SumColumn=SumColumn+arr1[i,j];
           
        }
        arrSredneArifmetichColumn[j]=SumColumn/arr1.GetLength(1);
        SumColumn=0;
    }
    return arrSredneArifmetichColumn;
}

//SredneArifmetichColumn(array1);
PrintArray(SredneArifmetichColumn(array1));