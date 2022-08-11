string[] words= new string[5];

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
ReadArray(words);
Console.WriteLine();
PrintArray(words);