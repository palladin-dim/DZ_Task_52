/* Задача 52: Задайте двумерный массив из целых чисел.  Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

Console.Clear();
int[,] RandomArray(int m, int n, int minVolue, int maxValue) 
{
    int[,] Array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i, j] = new Random().Next(minVolue, maxValue);
        }
    }
    return Array;
}
void PrintArray(int[,] mass) 
{
    for (int rows = 0; rows < mass.GetLength(0); rows++)
    {
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            Console.Write($"{mass[rows, columns]}\t");
        }
        Console.WriteLine();
    }
}
double[] ArifmeticSumAlements(int[,] ArraySum) 
{
    double[] NewSumArray = new double[ArraySum.GetLength(1)];
    for (int rows = 0; rows < ArraySum.GetLength(0); rows++)
        {
            int z = 0; 
            for (int columns = 0; columns < ArraySum.GetLength(1); columns++)
            {
                NewSumArray[z] = NewSumArray[z] + ArraySum[rows, columns];
                z++;
            }
        } 
    Console.WriteLine();
    return NewSumArray;         
}

void PrintArifmetic(double[] mass) //выводим новый одномерный массив 
{
    for (int i = 0; i < mass.Length; i++)
    {
       Console.Write($"Сумма элементов столбца {mass[i]} \t");
    }
}    

void PrintArifmetic2(double[] mass, int q) //метод принимает одномерный массив и аргумент количества строк для среднего арифметического
{
    Console.WriteLine();
    Console.Write($"Среднее арифметическое элементов каждого столбца: -> ");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{Math.Round(mass[i]/q, 2)} \t"); //элемент массива с текущим индексом делим на колич. строк двумерного массива
    }
}    

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myArray = RandomArray(rows, columns, 0, 20);
PrintArray(myArray);

double[] myArray2 = ArifmeticSumAlements(myArray);
PrintArifmetic(myArray2);
PrintArifmetic2(myArray2, columns);