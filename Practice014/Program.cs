﻿// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// string rec(int n) {
//     if (n == 0) {
//         return "";
//     }
//     return rec(n-1) + $"{n}";
// }

// Console.Write("Введите элемент: "); 
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));
//                               rec(5)
//                         rec(4) + '5'
//                   rec(3) + '4'
//             rec(2) + '3'
//       rec(1) + '2'
// rec(0) + '1'
// ''

// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// string rec(int m, int n) {
//     if (n == m) {
//         return $"{m}";
//     }
//     return rec(m, n-1) + $"{n}";
// }

// Console.Write("Введите элемент m: "); 
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите элемент n: "); 
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(m, n));

// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int summ(int m) {
//     if(m < 10) return m;
//     else {
//         int lastNumber = number % 10;
//         int remainingNumber = number / 10;
//         return lastNumber + summ(remainingNumber);
//     }
// }
// Console.Write("Введите элемент m: "); 
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(summ(m));

// // **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// // A = 3; B = 5 -> 243 (3⁵)
// // A = 2; B = 3 -> 8

// Console.Write("Введите элемент a: "); 
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите элемент b: "); 
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(summ(m));
//  int[] arr = new int[4];
//  Console.Write(arr);
string rec(int n) {
    if (n == 0) {
        return "";
    }
    return rec(n-1) + $"{n}";
}
Console.WriteLine(rec(4));
