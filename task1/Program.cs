
void FillArray(string [] coll)
{
    int length = coll.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine($"введите {i+1}-е значение для массива");
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
string []  myFunk (string []masiv)
{
    int digit =masiv.Length;
    string[]coll = new string[digit];
    int j=0;
    for (int i = 0; i < masiv.Length; i++)
    {
        string element = masiv[i];
        int length = element.Length;
        if (length<3)
        {
            coll[j]= masiv[i];
            j++;
        }
    }

    return coll;
}

Console.WriteLine("введите длину массива");
int digit = Convert.ToInt32(Console.ReadLine());
string[]array = new string[digit];
FillArray(array);
ShowArray(array);
Console.Write(" -> ");
 string[]array2 = myFunk(array);
 ShowArray(array2);
