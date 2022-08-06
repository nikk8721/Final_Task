// Сформировать из имеющего массива массив из строк,
// длина которых меньше или равна 3.
Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
string[] Arr = new string [n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения: ");
    Arr[i] = (Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", Arr) + "]");
// Формирование массива по условию
