int[,] table = new int[3, 4];
// String.Empty


void PrintArray (int[,] table){
    for (int rows = 0; rows < table.GetLength(0); rows++) {
        for (int columns = 0; columns < table.GetLength(1); columns++) {
            Console.Write($"{table[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(0, 10); // [0; 10)
        }
    }
}
PrintArray(table);
Console.WriteLine();
FillArray(table);
PrintArray(table);
Console.WriteLine();

int Factoral (int n) {
    if (n == 1) return 1;
    else return n*Factoral(n-1);
}
Console.WriteLine(Factoral(4));