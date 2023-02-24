int Count(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count ++;
        }
    }
        return count;
}

string[] array1 = {"hello", "world", "hi", "Tom", "Jerry", "cat"};
int count = Count(array1);
string[] array2 = new string [count];
int j = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[j] = array1[i];
        j ++; 
    }
}
Console.WriteLine($"{String.Join(", ", array2)}");