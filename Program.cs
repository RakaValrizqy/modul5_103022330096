// See https://aka.ms/new-console-template for more information
public class PemrosesData 
{
    public static T DapatkanNilaiTerbesar<T>(T x, T y, T z)
    {
        dynamic t1 = (dynamic)x;
        if (t1 < y)
        {
            t1 = y;
        } 
        if (t1 < z)
        {
            t1 = z;
        }
        return t1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 30;
            int z = 22;
            Console.WriteLine(PemrosesData.DapatkanNilaiTerbesar(x,y,z));
        }
    }
}

