string [] Array3SymbolsStrings (string [] array) // создание массива с длиной строк <= 3 символам
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) result = result + "," + array[i];
    }
    string [] newArray = result.Split (",");
    return newArray;
}

void ShowArray (string [] array) // вывод массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine (array[i]);
    }
}

string [] text = {"music", "sky", "stars", "-_-", "156", "winter", "XD"};
string [] newText = Array3SymbolsStrings (text);
ShowArray (newText);
