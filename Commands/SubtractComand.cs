class SubtractComand : BaseBinaryCommand
{
    public SubtractComand(int regNumberForResult)
        : base(regNumberForResult, "sub") { }

    protected override int ExecuteBinaryCommand(int left, int right) => left - right;
}
