void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) {
    int count = col.Length;
    int position = 0;
    while(position < count) {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) {
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while(index < count) {
        if(collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    Console.WriteLine(position);
    return position;
}

int[] arr1 = new int [10];
FillArray(arr1);
PrintArray(arr1);
Console.WriteLine();
int pos = IndexOf(arr1, 4);
