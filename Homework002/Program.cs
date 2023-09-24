/* Task #1
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
Console.WriteLine("Task1");
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number/10;
Console.WriteLine(number1%10);

/* Task #2
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Task2");
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 100 && a > -100) {
    Console.WriteLine("третьей цифры нет");
}
else if(a > 99) {
    while(a > 999) {
        a = a/10;
    }
    Console.WriteLine(a%10);
}
else if(a < -99) {
    while(a < -999) {
        a = a/10;
    }
    Console.WriteLine(a%10);
}

/* Task #3
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
Console.WriteLine("Task3");
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b == 6 || b == 7) Console.WriteLine("yes");
else Console.WriteLine("no");