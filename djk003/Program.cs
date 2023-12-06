// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
using System.Net.NetworkInformation;

static void Main(){
int [,] CreateArray(int row, int col, int min, int max){
int [,] array = new int [row,col];
for (int i =0; i<row; i++){
for(int j = 0; j<col;j++){
array[i,j] = new Random().Next(min, max+1);
}
}
return array;
}
}
void Showarray(int [,] array){
for(int i = 0; i<array.GetLength(0); i++){
for(int j=0; j<array.GetLength(1); j++){
Console.Write(array[i,j]+" ");
}
Console.WriteLine();
}
}
Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <  col; i++)
        {
            CreateArray[0, i] = CreateArray[row- 1, i];
        }


int [,] createarray = CreateArray(row,col,min,max);
Showarray(createarray);
Console.WriteLine();
Showarray(createarray);