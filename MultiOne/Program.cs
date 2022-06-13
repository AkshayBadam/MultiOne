class ThreeD
{
    public int x { get; set; }
    public int y { get; set; }
   public int z = 0;
    public ThreeD()
    {

    }
    public ThreeD(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static implicit operator ThreeD(TwoD v)
    {
        ThreeD t2 = new ThreeD();
        t2.x=v.x;
        t2.y= v.y;
        t2.z = 0;
        return t2;
    }
}
class TwoD
{
    public int x { get; set; }
    public int y { get; set; }
    public TwoD()
    {

    }
    public TwoD(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static explicit operator TwoD(ThreeD V)
    {
        TwoD t1 = new TwoD();
        t1.x=V.x;
        t1.y=V.y;
        return t1;
    }
}
class Program
{
    public static void Main()
    {
        ThreeD t = new ThreeD(1, 2, 3);
        TwoD f = new TwoD();
        f=(TwoD)t;
        Console.WriteLine(f.x);
        Console.WriteLine(f.y);
        ThreeD d = new ThreeD();
        d=f;
        Console.WriteLine(d.x);
        Console.WriteLine(d.y);
        Console.WriteLine(d.z);
    }
}