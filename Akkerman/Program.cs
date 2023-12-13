int AkkermanNumbers(int m, int n){
if (m == 0) return n + 1;
else if (n == 0) return AkkermanNumbers(m - 1, 1);
else return AkkermanNumbers(m - 1, AkkermanNumbers(m, n - 1));
}

int m = 2;
int n = 3;

Console.Write($"Функция Аккермана равна {AkkermanNumbers(m, n)} ");
