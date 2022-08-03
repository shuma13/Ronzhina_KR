Console.WriteLine("введите длину массива");
int digit = Convert.ToInt32(Console.ReadLine());
string[]array = new string[digit];


void FillArray(string [] coll)
{
    int length = coll.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine("введите значение для массива");
        string som = Console.ReadLine();
        coll[i] = som;
    }
}
FillArray(array);
foreach (var item in array)
{
   Console.Write(" << " + item + ">>" + ", "); 
}