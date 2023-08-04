Console.WriteLine("Введите строковый массив через пробел:");
string inputString = Console.ReadLine();
string[] stringArray = FullStringArrayFromString(inputString);
int n = CountElements(stringArray);
string[] newStringArray = new string[n];
newStringArray = FullNewArray(stringArray, newStringArray);
PrintArray(newStringArray);

string[] FullStringArrayFromString(string inputString)
{
    var stringOfArray = inputString.Split(' ');
    string[] stringArray = new string[stringOfArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        stringArray[i] = stringOfArray[i];
    }
    return stringArray;
}

int CountElements (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    return count;
}

string[] FullNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine(string.Join(" ", array));
}
