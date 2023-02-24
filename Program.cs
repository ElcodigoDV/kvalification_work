string[] array = {"hello", "world", "hi", "Tom", "Jerry", "cat"};
Console.WriteLine(array.Length);
Console.WriteLine(array[3].Length);
for (i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.WriteLine(array[i]);
    }
}