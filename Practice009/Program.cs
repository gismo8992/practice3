// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Enter numbers: ");
int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int countPositive = 0;
for(int i = 0; i < arr.Length; i++) {
    if(arr[i] > 0) {
        countPositive++;
    }
}
Console.WriteLine(countPositive);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Enter four number b1, k1, b2, k2: ");
double[] arr1 = Console.ReadLine().Split(" ").Select(z => double.Parse(z)).ToArray();
double x = Math.Round((arr1[2]-arr1[0])/(arr1[1]-arr1[3]), 2);
double y = Math.Round((arr1[1]*x + arr1[0]), 2);
Console.WriteLine($"Координата точки пересечения прямых: {x}; {y}");

