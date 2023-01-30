void PrintArray(string[]a)
{
    Console.Write("[");
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]+" ");
    }
    Console.Write("] -> ");
}
Console.Write("Введите стрки: ");
string[] str = Console.ReadLine().Split();
PrintArray(str);
Console.Write("[");
for(int i = 0; i < str.Length; i++)
{
    if(str[i].Length <= 3)
    {
        Console.Write(str[i] + " ");
    }
}
Console.Write("]");