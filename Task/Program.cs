// Сформировать из имеющего массива массив из строк,
// длина которых меньше или равна 3.
Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
string[] Arr = new string [n];
string[] Arr2 = new string [n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения: ");
    Arr[i] = (Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", Arr) + "]");
// Формирование массива по условию
for (int i = 0; i < n; i++)
{
    string s = Arr[i];
    if (s.Length <= 3)
    {
        for (int j = 0; j < n; j++)
        {
            Arr2[i] = s;
        }
        string temp;
        temp = Arr2[i];
        Arr2[i] = Arr [i];
        Arr[i] = temp;
    }
    
}
Console.WriteLine("Итоговый массив: [" + string.Join(", ", Arr2) + "]");                    
