void SwapArray<T>(List<T> list){
    if (list == null || list.Count <= 1)
    {
        return;
    }

    T value = list[0];
    list.RemoveAt(0);
    SwapArray(list);
    list.Add(value);
}
List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
SwapArray(list);
Console.WriteLine(string.Join(',', list));