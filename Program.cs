Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array1[i] = Console.ReadLine()!;
}
Console.WriteLine($"Введенный массив: [{String.Join(", ", array1)}]");