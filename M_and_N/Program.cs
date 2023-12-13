
void EvenNumber(int m, int n)
{
if (m > n)
return;
if (m % 2 == 0)
{
Console.Write($"{m}, ");
}
EvenNumber(m+1,n);
}
int m = 1;
int n = 10;
EvenNumber(m,n);