Console.WriteLine();
string[] firstArray = new string[4] { "hello", "2", "world", ":-)" };
string[] secondArray = new string[firstArray.Length];
void secondArray2(string[] firstArray, string[] secondArray)

{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("Ваш массив: ");

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
secondArray2(firstArray, secondArray);
PrintArray(secondArray);
Console.WriteLine();