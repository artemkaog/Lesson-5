// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int Sum(int[,]matrix){
    int min=11234123;
    int minstr = 0;
    for ( int i =0; i<matrix.GetLength(0);i++){
        int sum=0;
        for ( int j =0 ; j<matrix.GetLength(1);j++){
            sum+=matrix[i,j];
        }
        if (sum<min){
            min=sum;
            minstr=i;
        } 
    }
    return minstr;
}
Console.WriteLine("Строка с наименьшой суммой - " + Sum(matrix));