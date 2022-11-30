class Jump : ICommand
{
    public void Dump()
    {
        Console.Write("jmp");
    }

    public void Execute(int[] registers, ref int currentCommandIndex)
    {
        currentCommandIndex += registers[0];
    }
}
