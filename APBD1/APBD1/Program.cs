// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Sun!");
string str = "";
int a = 9;

static double Srednia(int[] numb)
{
    double suma = 0;
    foreach (var n in numb)
    {
        suma += n;
    }

    return suma / numb.Length;
}

static int MaxVal(int[] tab)
{
    int max = tab[0];
    for (int i = 1; i < tab.Length; i++)
    {
        if (tab[i] > max)
        {
            max = tab[i];
        }
    }

    return max;
}