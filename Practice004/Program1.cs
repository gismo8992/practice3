/*Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB 
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//Task1
d = sqrt((x2 — x1)^2 + (y2 — y1)^2 + (z2 — z1)^2)

//Task2
double DistanceBetweenPoints(int[] pointA, int[] pointB) {
    double distance = Math.Sqrt(Math.Pow(pointB[0]-pointA[0], 2) + Math.Pow(pointB[1]-pointA[1], 2) + Math.Pow(pointB[2]-pointA[2], 2));
    return distance;
}

//Task3
double result = DistanceBetweenPoints(new int[]{3, 6, 8}, new int[]{2, 1, -7});
Console.WriteLine($"{result:F2}");

 static void Pow(int N){   
    for(int i = 1; i <= N; i++) {
            Console.WriteLine(Math.Pow(i, 3));
            i++;
    }
 }