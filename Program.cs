// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// PrintNum(num1, num2);

// void PrintNum(int start, int end)
// {
//     if(start>end)
//     {
//         return;
//     }

//     Console.WriteLine(start+ " ");

//     PrintNum(++start, end);
// }

// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// Console.WriteLine("Введите неотрицательное число m");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите неотрицательное число n");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = A(m, n);

// Console.WriteLine($"А({m},{n})={result}");


// static int A(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return A(m - 1, 1);
//     }
//     else
//     {
//         return A(m - 1, A(m, n - 1));
//     }
// }

// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


int[] array = new int[5];
Console.WriteLine("Введите 5 чисел:");

FillArray(array, 0);
PrintArray(array, array.Length - 1);

void FillArray(int[] array, int i)
{
    if (i < array.Length)
    {
        Console.Write($"Число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        FillArray(array, i + 1);
    }
}

void PrintArray(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write(array[i] + " ");
        PrintArray(array, i - 1);
    }
}



