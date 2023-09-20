int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array1 = {12,23,13,42,15,46,67,18,29};
array1[0] = 30;
Console.WriteLine(array1[0]);

int max = Max(
    Max(array1[0], array1[1], array1[2]),
    Max(array1[3], array1[4], array1[5]),
    Max(array1[6], array1[7], array1[8])
);
Console.WriteLine(max);

int[] array2 = {12,23,13,42,15,46,67,18,29,42};
int index1 = 0;
int find = 42;
int n = array2.Length;
while(index1 < n) {
    if(array2[index1] == find) {
        Console.WriteLine(array2[index1]);
        break;
    }
     index1++;
}

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