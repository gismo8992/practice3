
// void PrintArray (int [,] matrix) {
//   for(int i = 0; i < matrix.GetLength(0); i++) {
//     for(int j = 0; j < matrix.GetLength(1); j++) {
//         Console.Write($"{matrix[i, j]}\t");
//     }
//     Console.WriteLine();
//     }
// }

// int[,] CreateIncreasingMatrix(int n, int m, int k) {
//   int[,] matrix = new int[n, m];
//   int value = 1;
//   for(int i = 0; i < n; i++) {
//     for(int j = 0; j < m; j++) {
//       matrix[i, j] = value;
//       value += k;
//       }
//     }
//     return matrix;
// }

// int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition) {
//   if (rowPosition < 0 || rowPosition >= matrix.GetLength(0) || columnPosition < 0 || columnPosition >= matrix.GetLength(1)) {
//     return new int[] {0};
//   }
//   else return new int[] {matrix[rowPosition, columnPosition], 0};
// }

// void PrintCheckIfError (int[] results, int X, int Y) {
//   if(results.Length == 1) Console.Write($"There is no such index");
//   else Console.Write($"The number in [{X}, {Y}] is {results[0]}");
// }

// int[,] myArr = CreateIncreasingMatrix(4, 3, 2);
// PrintArray(myArr);
// PrintCheckIfError(FindNumberByPosition(myArr, 3, 2), 3, 2);



// task 1, hw8
void PrintArray (int [,] matrix) {
  for(int i = 0; i < matrix.GetLength(0); i++) {
    for(int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
    }
}

int[,] GenerateMatrix(int rowSize, int columnSize) {
  int[,] matrix = new int[rowSize, columnSize];
  for(int i = 0; i < matrix.GetLength(0); i++) {
    for(int j = 0; j < matrix.GetLength(1); j++) {
      matrix[i, j] = new Random().Next(-10, 11);
    }
  }
  return matrix;
}

int[,] SortMatrix(int[,] matrix) {
  for(int i = 0; i < matrix.GetLength(0); i++) {
    int temp;
    for(int j = 0; j < matrix.GetLength(1)-1; j++) {
      for(int k = j+1; k < matrix.GetLength(1); k++) {
        if(matrix[i, j] < matrix[i, k]) {
          temp = matrix[i, j];
          matrix[i, j] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
  return matrix;
}

PrintArray(SortMatrix(GenerateMatrix(3, 4)));


// task 2 hw8
void SumOfRow(int[,] matrix, int row) {
  int sum = 0;
    for(int i = 0; i < GetLength(1); i++) {
        sum += matrix[row, i]
    }
    return int sum;
}