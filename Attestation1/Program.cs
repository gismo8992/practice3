// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
string function (int n) {
    if(n < 1) return "";
    Console.Write($"{n} ");
    return function(n-1);
}


Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your sequnce of numbers: ");
function(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int FindSum(int m, int n) {
    if (n == m) {
        return m;
    }
    return FindSum(m, n-1) + n;
}

Console.Write("Sum of numbers: ");
Console.WriteLine(FindSum(3, 4));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29