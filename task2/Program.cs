/*
Задача 50. Напишите программу, которая на вход принимает 
позиции элемента либо значение элемента в двумерном массиве, 
и возвращает значение либо индекс этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
2, 3 -> такой элемент есть и равен 4
5, 5 -> такой элемент отсутствует
*/
void fillArray(int[,] array)
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}
//int [,] arr2
bool flagFindValue = false;
int counts = 0;
void FindValue(int[,] arr1, string inputValue)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (arr1[i, j] == Convert.ToInt32(inputValue))
            {
                flagFindValue = true;
                counts++;
                             
            }
        }
    }
    Console.WriteLine();
}
bool flagFindIndex = false;

void FindIndex(int[,] arr1, string inputString)
{
    int value = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {

        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (i.ToString() + "," + j.ToString() == inputString)
            {
                flagFindIndex = true;
                value = arr1[i, j];
                Console.WriteLine("такой элемент есть в массиве и равен " + value);
                break;
            }
        }
    }

    Console.WriteLine();
}
Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m, n];
Console.WriteLine("Введите число или два числа через запятую");

string input = Console.ReadLine();

fillArray(array1);
printArrayRazm(array1);
Console.WriteLine("");

if (input.Contains(","))
{
    FindIndex(array1, input);
    if (flagFindIndex == false) Console.WriteLine("такого элемента нет в массиве");

}
else
{
    FindValue(array1, input);
    if (flagFindValue == true) Console.WriteLine("такое число " + input + " есть в массиве И встречается оно " + counts + " раз");
    else Console.WriteLine("такое число " + input + " не встречается в массиве");
}

