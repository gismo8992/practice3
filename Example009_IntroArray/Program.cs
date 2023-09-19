int[] array1 = {12,23,13,42,15,46,67,18,29};
array[0] = 31;
int Max (int[] arr) {
    int max = 0;
    for(int i: arr) {
        if (max < i) {
            max = i;
        }
        return max;
    }
}

int max1 = Max(array1);
Console.WriteLine(max1);

// int Max( int arg1, int arg2, int arg3) {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int max1 = Max(a1, b1, c1);
// Console.WriteLine(max1);
// int max2 = Max(a2, b2, c2);
// Console.WriteLine(max2);
// int max3 = Max(a3, b3, c3);
// Console.WriteLine(max3);
// int max = Max(max1, max2, max3);
// Console.WriteLine(max);