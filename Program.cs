// 2024-01-26. Домашнее задание. Рекурсия

// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

System.Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());;
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());;

if (M==N)
{
    Console.WriteLine("Вы ввели одно и то же число: " + M+". Попробуйте снова.");
}

else
{
int minNum=Int32.Min(M,N);
int maxNum=Int32.Max(M,N);
PrintNumbers(minNum, maxNum);
}

void PrintNumbers(int firstNum, int lastNum)
{
    if(firstNum>lastNum)
    {
        return;
    }
    System.Console.Write(firstNum+"\t");
    PrintNumbers(firstNum+1, lastNum);
}


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

System.Console.WriteLine("Введите неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите неотрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else if (x > 0 && y == 0)
    {
        return AckermannFunction(x - 1, 1);
    }
    else
    {
        return AckermannFunction(x - 1, AckermannFunction(x, y - 1));
    }
}

Console.WriteLine($"A({m},{n}) = {AckermannFunction(m,n)}");

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


int[] matrix = CreateArray();
GetArray(matrix);
PrintArray(matrix); //стандартным образом выводим созданный массив для наглядности
System.Console.WriteLine();
int index = 0;
PrintReverseArray(matrix, index); //С ИСПОЛЬЗОВАНИЕМ РЕКУРСИИ ВЫВОДИМ МАССИВ В ОБРАТНОМ ПОРЯДКЕ


int[] CreateArray()
{
    System.Console.WriteLine("Задайте длину массива");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[sizeArray];
    return array;
}

void GetArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write(newArray[i] + "\t");
    }
}

void PrintReverseArray(int[] array2, int i)
{
    if (i == array2.Length)
    {
        return;
    }
    System.Console.Write(array2[array2.Length - 1 - i] + "\t");

    PrintReverseArray(array2, ++i);
}