/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void function (int number, int degree) {
    int result = 1;
    for(int i = 1; i <= degree; i++) {
        result*=number;
    }
    Console.WriteLine($"A в степени B равно: {result}");
}

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
function(A, B);

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
void function (int number) {
    int degree = 1;
    int numberCount = number;
    while(numberCount/10 > 0) {
        degree+=1;
        numberCount/=10;
    }
    Console.WriteLine($"Number of digits in number: {degree}");
    int sum = 0;
    for(int i = 0; i <= degree; i++) {
        sum += number%10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе: {sum}");
}
Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
function(n);

/*
Задача 29: Напишите программу, которая задаёт принимет на вход длинну массива, и далее элементы массива. Программа должна вывести массив
5
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
3
6, 1, 33 -> [6, 1, 33]
*/

void arrayPrint(int arrayLength) {
    int[] arr = new int[arrayLength];
    for(int i = 0; i < arr.Length; i++) {
        Console.WriteLine($"Enter number in array's position #{i}");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    Console.Write($"[{string.Join(", ", arr)}]");
}

Console.WriteLine("Enter number of array's elements: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
arrayPrint(arrLength);


