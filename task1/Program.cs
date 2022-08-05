
void FillArray(string[] coll)
{
    int length = coll.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine($"введите {i + 1}-е значение для массива");
        string som = Console.ReadLine();
        coll[i] = som;
    }
}

void ShowArray(string[] arrayToShow)
{
    Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write($" <<{arrayToShow[i]}>>");
        if (i < arrayToShow.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
string[] GetConvertedArray(string[] masiv)
{
    int digit = masiv.Length;
    string[] coll = new string[digit];
    int j = 0;
    for (int i = 0; i < digit; i++)
    {
        string element = masiv[i];
        int length = element.Length;
        if (length < 4)
        {
            coll[j] = masiv[i];
            j++;
        }
    }
    string[] masiv2 = new string[j];
    for (int i = 0; i < masiv2.Length; i++)
    {
        masiv2[i] = coll[i];
    }

    return masiv2;
}

Console.WriteLine("введите длину массива");
int digit = Convert.ToInt32(Console.ReadLine());
string[] array = new string[digit];
FillArray(array);
ShowArray(array);
Console.Write(" -> ");
string[] array2 = GetConvertedArray(array);
ShowArray(array2);
