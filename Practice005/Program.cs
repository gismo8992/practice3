/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

void InputArray(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-9,10);
    }
}

void ReleaseArray(int[] array) {
    int sumPos = 0;
    int sumNeg = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i] > 0) {
            sumPos += array[i];
        }
        else {
            sumNeg += array[i];
        }
        Console.WriteLine($"Sum positive = {sumPos}, Sum negatice = {sumNeg}");
    }
}

Console.Clear();
Console.Write("How many elemets: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);