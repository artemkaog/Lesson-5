//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Random rand = new Random();
Console.WriteLine("Введите колво строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колво столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
void PrintMatrix(int[,] tempMatrix){
    for (int i = 0; i<rows;i++){
        for (int j =0 ;j< col;j++){
            Console.Write(tempMatrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] GenerateMatrix(int rows, int col){
    int[,] tempMatrix = new int[rows,col];
    for ( int i  = 0 ; i < rows;i++){
        for(int j =0 ; j<col ; j++){
            tempMatrix[i,j]=rand.Next(10);
        }
    }
    return tempMatrix;
}
Console.WriteLine();
int[,] matrix = GenerateMatrix(rows,col);
PrintMatrix(matrix);
Console.WriteLine();
int[,] Change(int[,] matrix){
    for (int i =0; i<matrix.GetLength(0);i++){
        for( int j=0;j<matrix.GetLength(1);j++){
            int temp= matrix[0,j];
            matrix[0,j]=matrix[matrix.GetLength(0)-1,j];
            matrix[matrix.GetLength(0)-1,j]=temp;
        }  
    }
    return matrix;
}
PrintMatrix(Change(matrix));