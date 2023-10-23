// Console.Clear();
// Console.Write("Enter a size of the matrix: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];

// void InutpMatrix(double[,] matrix, int minLimitRandom, int maxLimitRandom) {
//     for(int i = 0; i < matrix.GetLength(0); i++) {
//         for(int j = 0; j < matrix.GetLength(1); j++) {
//             matrix[i, j] = Math.Round((minLimitRandom + new Random().NextDouble()*(maxLimitRandom-minLimitRandom)), 2);
//         }
//     }
// }

// void PrintMatrix(double[,] matrix) {
//     for(int i = 0; i < matrix.GetLength(0); i++) {
//         for(int j = 0; j < matrix.GetLength(1); j++) {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// InutpMatrix(matrix, -10, 10);
// PrintMatrix(matrix);

void CreateIncreasingMatrix(int n, int m, int k) {
      int[,] matrix = new int[n, m];
      int value = 1;
      for(int i = 0; i < n; i++) {
        for(int j = 0; j < m; j++) {
          // if(i == 0 && j == 0) matrix[i, j] = 1;
          // if(i == 0 && j!=0) matrix[i, j] = matrix[i, j-1] + k;
          // if(j == 0 && i!=0) matrix[i, j] = matrix[i-1, m-1] + k;
          // if(j!=0 && i!=0) matrix[i, j] = matrix[i, j-1] + k;
          matrix[i, j] = value;
          value += k;
        }
      }
      PrintMatrix(matrix);
}

void PrintMatrix(int[,] matrix) {
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

CreateIncreasingMatrix(3, 4, 3);

// static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition) {  
//       // Введите свое решение ниже
//       int[] result = {0, 0};
//       for(int i = 0; i < matrix.GetLength(0); i++) {
//         for(int j = 0; j < matrix.GetLength(1); j++) {
//           if(i == rowPosition && j == columnPosition) {
//             result[0] = matrix[i, j];
//           }         
//         }
//       }  
//       return result;
// }
// FindNumberByPosition(matrix, 2, 2);
