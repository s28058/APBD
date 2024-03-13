// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Sun!");
string str = "";
int a = 9;

static double Srednia(int[] numb)
{
    double sum = 0;
    foreach (var n in numb)
    {
        sum += n;
    }

    return sum / numb.Length;
}