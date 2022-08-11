string[] words = new string[5];

void ReadArray(string[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}
Console.WriteLine("Введите массив строк с клавиатуры:");
ReadArray(words);
Console.WriteLine();
Console.WriteLine("Текущий массив строк:");
PrintArray(words);
Console.WriteLine();
Console.WriteLine("Строки, в которых символов меньше или равно 3");

for(int i = 0; i<words.Length; i++)
{
    if(words[i].Length <= 3) Console.WriteLine(words[i]);
}