// =================================== Recursion Home Work =====================================

Console.Clear();

// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Range (int M, int N) 
{
    if (M > N) {
        return;
    }
    Console.Write($"{M} ");
    Range(M+1, N);
}

Console.Write("\nЗадача 1: ");
Range(10, 18);



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

//          { n + 1                 m = 0
// A(m,n) = { A(m-1, 1)             m > 0, n = 0
//          { A(m-1, A(m,n-1))      m > 0, n > 0

long iAmDurak (long m, long n)
{
    if (m == 0) { return n + 1; }
    else if (m > 0 & n == 0) { return iAmDurak(m-1, 1); }
    else if (m > 0 & n > 0) { return iAmDurak(m-1, iAmDurak(m, n-1)); }
    else { return n; }
}

int m = 3;
int n = 5;
Console.Write($"\n\nЗадача 2. Функция Аккермана A({m}, {n}): ");
Console.Write(iAmDurak(m, n));



// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы

void PrintArray (int [] arr, int i)
{
    if (i >= arr.Length) { return; }
    Console.Write(arr[i] + " ");
    PrintArray(arr, i+1);
}

void PrintArrayRev (int [] arr, int i)
{
    if (i >= arr.Length) { return; }
    Console.Write(arr[arr.Length-1-i] + " ");
    PrintArrayRev(arr, i+1);
}

int [] Arr = new int [] {3, 5, 6, 7, 9};
Console.Write("\n\nЗадача 3.    Массив: ");
PrintArray(Arr, 0);
Console.Write("\nПеревернутый массив: ");
PrintArrayRev(Arr, 0);
