namespace tpmodul4_1302204051;

public class ClassMain
{
    public static void Main(string[] args)
    {
        String nama = "Doni";
        HaloGeneric.SapaUser<string>(ref nama);
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

class HaloGeneric
{
    public static void SapaUser<T>(ref T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}