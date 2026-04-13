Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
for (int x = 1; x <= n; x++)
{
    bool tagged = false;
    if (x % 3 == 0)
    {
        Console.Write("foo");
        tagged = true;
    }
    if (x % 4 == 0)
    {
        Console.Write("baz");
        tagged = true;
    }
    if (x % 5 == 0)
    {
        Console.Write("bar");
        tagged = true;
    }
    if (x % 7 == 0)
    {
        Console.Write("jazz");
        tagged = true;
    }
    if (x % 9 == 0)
    {
        Console.Write("huzz");
        tagged = true;
    }
    if (!tagged)
        Console.Write(x);
    if (x != n)
        Console.Write(", ");
}

