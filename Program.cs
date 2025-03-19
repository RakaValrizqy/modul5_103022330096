﻿// See https://aka.ms/new-console-template for more information
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
        int x = 10;
        int y = 30;
        int z = 22;
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(x);
        db.AddNewData(y);
        db.AddNewData(z);
        db.PrintAllData();
    }
}
