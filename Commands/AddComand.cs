class AddComand : BaseBinaryCommand
{
    public AddComand(int regNumberForResult)
        : base(regNumberForResult, "add") { }

    protected override int ExecuteBinaryCommand(int left, int right) => left + right;
}
