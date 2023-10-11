// void InputArray(int[] arr) {
//     int temp = 0;
//     for(int i =0; i < arr.Length/2; i++) {
//         temp = arr[i];
//         arr[i] = arr[arr.Length-1-i];
//         arr[arr.Length-1-i] = temp;
//     }
// }

/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
*/

// Console.WriteLine("Enter numbers: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // прохождение по всем элементам из строки и добавление в массив
// Console.WriteLine($"[{string.Join(", ", size)}]");

// void function(int[] array) {
//     if(array[0] < array[1] + array[2] && array[1] < array[0]+array[2] && array[2] < array[1]+array[0]) {
//         Console.WriteLine("yes");
//     }
//     else Console.WriteLine("no");
// }

// // Console.WriteLine("Enter nubmer #1: ");
// // int nubmer1 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Enter nubmer #2: ");
// // int nubmer2 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Enter nubmer #3: ");
// // int nubmer3 = Convert.ToInt32(Console.ReadLine());
// int[] myArray = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// function(myArray);

// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101
// // 3  -> 11
// // 2  -> 10
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string res = String.Empty;

// while (n > 0)
// {
//     res = Convert.ToString(n % 2) + res;
//     n /= 2;
// }
// Console.Write(res);

/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

// 1 2 3 4 5 6 7  8  9
//  0  1  1  2  3  5  8  13 21 34
// x0 x1 x2
//    x0 x1 x2
//       x0 x1 x2
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int x0 = 0;
// int x1 = 1;
// int x2 = x0 + x1;

// for (int i =0; i < n; i++)
// {
//     Console.Write($"{x0} ");
//     x2 = x0 + x1;
//     x0 = x1;
//     x1 = x2;
// }
/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
void printArray(int[] arr) {
     Console.WriteLine($"[{string.Join(", ", arr)}]");
}

Console.WriteLine("Enter an array: ");
Console.WriteLine("Point of stop");
Console.WriteLine("Point after stop");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//Select(x => int.Parse(x)).ToArray();
int[] arr = {2, 4, 33, 31, 333};
printArray(array);
