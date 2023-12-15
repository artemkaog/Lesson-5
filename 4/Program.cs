// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца
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
int Imin=0;
int Jmin=0;
int min=11;
for ( int i =0 ; i<matrix.GetLength(0);i++){
    for ( int j =0 ; j< matrix.GetLength(1); j++){
        if ( matrix[i,j]< min){
            Jmin=j;
            Imin=i;
            min=matrix[i,j];
        } 
    }
}
Console.WriteLine();
Console.WriteLine($"{Imin} ,{Jmin}");
Console.WriteLine();
int[,] NewM= new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
int newi = 0;
int newj =0;
for ( int i =0 ; i<matrix.GetLength(0) && newi<matrix.GetLength(0)-1;i++){
    if (i==Imin) continue;
    for ( int j =0 ; j< matrix.GetLength(1) && newj<matrix.GetLength(1)-1; j++){
        if ( j== Jmin) continue;
        NewM[newi,newj]=matrix[i,j];
        newj++;
    }
    newi++;
}   
for ( int i =0 ; i<NewM.GetLength(0);i++){
    for ( int j =0 ; j< NewM.GetLength(1); j++){
        Console.Write(NewM[i,j] + "\t");
    }
    Console.WriteLine();
}