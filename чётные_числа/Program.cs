using System.ComponentModel;
using System.Globalization;

int[] a = {11,12,13,14,51,611,17,91,120};
int count = 0;
foreach(int num in a){
if(num % 2 == 0){
    count++;
}
}

Console.WriteLine($"коль-во чётных чисел в массиве {count}");