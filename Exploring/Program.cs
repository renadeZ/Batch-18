int a = 10;
Point z = new Point(10, 21);
Point x = new Point(10, 21);
// Console.WriteLine(a.GetHashCode());
// Console.WriteLine(z.GetHashCode());
// Console.WriteLine(x.GetHashCode());
Console.WriteLine(Environment.UserName);

public class Point
{
    public int x;
    public int y;
    public Point(int x, int y) {this.x = x; this.y = y;}
}