static class Memory
{
    private static readonly Dictionary<string, int> _ram = new();

    public static int Read(string address) => _ram[address];
    public static int Write(string address, int value) => _ram[address] = value;

    internal static void Dump()
    {
        foreach (var (address, val) in _ram)
        {
            Console.Write($"{address}={val}".PadLeft(5));
        }
    }
}
