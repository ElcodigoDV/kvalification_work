string[] array1 = {"hello", "world", "hi", "Tom", "Jerry", "cat"};
Console.WriteLine(array1.Length);
Console.WriteLine(array1[3].Length);
int count = 0;
for (i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        count ++;
        Console.WriteLine(array1[i]);
    }
}
string[] array2 = new [count];
int j = 0;
for (i = 0; i < array1.Length; i++)
{
    if (array1[i] <= 3)
    {
        array2[j] = array1[i];
        j ++; 
    }
}
Console.WriteLine($"{String.Join(", ", array2)}");