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
Console.WriteLine("Введите элементы массива");    
string[] massive = GetRandomArray(x);
Console.WriteLine(string.Join(", ", massive));

string[] array1 = new string[x];
int c = 0;
for(int i = 0; i < massive.Length; i++) 
{
string str = massive[i]; 
if ((str.Length == 3) | (str.Length < 3)) { array1[c] = str; c ++;}
} 
 
Console.WriteLine("Элементы массива меньше либо равны 3");
Console.WriteLine(string.Join(", ", array1));

}
else Console.WriteLine("Введите правильный размер массива");