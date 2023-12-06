int[] fgh = { 10, 11, 12, 25, 30, 45, 64, 78, 98, 87 };
int count = 0;
int index = 0;

while (index < fgh.Length)
{
    if (fgh[index] >= 20 && fgh[index] <= 90)
    {
        count++;
    }
    index++;
}
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке от 20 до 90: {count}");
