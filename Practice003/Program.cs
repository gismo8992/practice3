// void f(int n) {
//     int sum = 0;
//     for (int i = 1; i <= n; i++) {
//         sum = sum + i;
//     }
//     Console.Write(sum);
// }
// f(24);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// void numberCount(int number) {
//     int i = 0;
//     while(number > 0) {
//         number = number/10;
//         i++;
//     }
//     Console.WriteLine(i);
// }
// numberCount(342);

//Task 3

void function (int n) {
    int result = 1;
    for(int i = 1; i <=n; i++) {
        result = result*i;
    }
    Console.WriteLine(result);
}

function(3);

int[] n = new int[8];
