// вывести все четные числа в промежутке заданным пользователем
// невозвратная функция
void TestFuns(int first){
    // проверка на четность
    if (first%2==0){
        // конечный результат, который выводится в консоль
        Console.Write(first+ ", ");
    }

}

Console.WriteLine("Введите 1 число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
// чтение какое число написал пользователь перевод это числа в систему int 
int second_number = Convert.ToInt32(Console.ReadLine());
// меняем 1 на 2 (если 2 больше 1)
if(first_number>second_number){
    int temp = first_number;
    first_number = second_number;
    second_number = temp;
}
// цикл не будет выполняться пока 1 число не станет больше 2 числа 
while(second_number >= first_number){
    TestFuns(first_number);
    // сокращенная запись first_number + 1
    first_number++;
}



