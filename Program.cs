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
}

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 30;
        int z = 22;
        Console.WriteLine(PemrosesData.DapatkanNilaiTerbesar(x, y, z));
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {storedData[i]}, yang disimpan pada waktu {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
    }
}
