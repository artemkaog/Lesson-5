// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
Random rand= new Random();
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


Console.WriteLine("Введите номер строчки: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int c = Convert.ToInt32(Console.ReadLine());

void Search(int[,] matrix,int r , int c){   
    for ( int i  = 0 ; i < rows;i++){
        for(int j =0 ; j<col ; j++){
            if (i==(r-1 )&& j==(c-1)){
                Console.WriteLine("Ваш элемент "+ matrix[i,j]);
            }
        }
    }
    Console.WriteLine("Числа с таким расположением нет");
}
Search(matrix,r,c);

