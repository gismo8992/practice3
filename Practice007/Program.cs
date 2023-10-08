//Task1
// public static int CountEvenElements(int[] array) { 
//     int count = 0;
//     for(int i = 0; i < array.Length; i++) {
//         if(array[i]%2 == 0) {
//           count++;
//         }
//     }
//     return count;
// }

// public static void PrintArray(int[] array) {
//     // Введите свое решение ниже
//     Console.WriteLine($"{string.Join("\t", array)}");
// }

//Task2
void PrintArray(double[] array)
{       // Введите свое решение ниже
      //Console.WriteLine($"{string.Join("\t", array)}");
      for(int i = 0; i < array.Length; i++) {
        Console.Write($"{Math.Round(array[i], 2)}");
        Console.Write("\t");
        }
}
double[] arr = {2.134, 3.2344, 23.1, 32.33111};
PrintArray(arr);