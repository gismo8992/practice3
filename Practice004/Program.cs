/*Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.
14212 -> False
12821 -> True
234322 -> Число не пятизначное
                     False
*/

static bool IsPalindrome(int number){
    if(number/10000 >=1 && number/10000 <10) {
        // if(number<0) {
        //     Console.WriteLine("False");
        //     return false;
        // }
        int leading1 = number / 10000;
        int trailing1 = number % 10;
        if (leading1 != trailing1) {
            Console.WriteLine("False");
            return false;
        }
        int leading2 = (number / 1000) % 10;
        int trailing2 = (number / 10) % 10;
        if(leading2 != trailing2) {
            Console.WriteLine("False");
            return false;
        }
        Console.WriteLine("True");
        return true;
    }
    else {
        Console.WriteLine("Число не пятизначное \n False");
        return false;
        }
    }

Console.WriteLine("Введите пятизначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
IsPalindrome(i);