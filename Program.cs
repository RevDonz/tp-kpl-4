// See https://aka.ms/new-console-template for more information
using static tpmodul4_1302204051.ClassMain;

namespace tpmodul4_1302204051;

public class ClassMain
{
    public static void Main(string[] args)
    {
        DataGeneric<string> dataGeneric = new DataGeneric<string>("1302204051");
        dataGeneric.PrintData();
    }

    
}
public class DataGeneric<T>
{
    private T Data;

    public DataGeneric(T Data)
    {
        this.Data = Data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah " + Data);
    }
}