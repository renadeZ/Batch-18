Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
for (int x = 1; x <= n; x++)
{
    if(x % 3 == 0)
        Console.Write("foo");
    if(x % 5 == 0)
        Console.Write("bar");
    if(x % 7 == 0)
        Console.Write("jazz");
    if(x % 3 != 0 && x % 5 != 0 && x % 7 != 0)
        Console.Write(x);
    if(x != n)
        Console.Write(", ");
}

