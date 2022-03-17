namespace tpmodul4_1302204051;

public class ClassMain
{
    public static void Main(string[] args)
    {
        String nama = "Doni";
        HaloGeneric.SapaUser<string>(ref nama);
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(ref T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }

}