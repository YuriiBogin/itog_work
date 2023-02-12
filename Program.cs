string[] GetRandomArray(int size)
{
    string[] array = new string[size];

    for (int i =0; i< array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());

if (x>0)
{
string[] massive = GetRandomArray(x);
Console.WriteLine(string.Join(", ", massive));
}
else Console.WriteLine("Введите правильный размер массива");