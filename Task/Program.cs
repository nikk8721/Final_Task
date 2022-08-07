// Сформировать из имеющего массива массив из строк,
// длина которых меньше или равна 3.
Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
string[] Arr = new string [n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения: ");
    Arr[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", Arr) + "]");
// Формирование массива по условию
int count = 0; // Ввод переменной - счетчика
for (int i = 0; i < n; i++) // Цикл подсчета элементов, подходящих по условию
{
    string s = Arr[i];
    if (s.Length <= 3)
    {
        {
            count++;
        }
    }    
}
string[] Arr2 = new string [count]; // Формируем новый массив, длина которого равна счетчику
int min = 0; // Ввод переменной счетчика индекса нового массива
for (int i = 0; i < n; i++) // Цикл формирования нового массива по значениям из старого, совпадающих по условию
{
    string s = Arr[i];
    if (s.Length <= 3)
    {
        for (int j = 0; j < count; j++)
        {
            Arr2[min] = s;
        }
        min++;
    }    
}
Console.WriteLine("Итоговый массив: [" + string.Join(", ", Arr2) + "]");                
