class GtComand : BaseBinaryCommand
{
    public GtComand(int regNumberForResult)
        : base(regNumberForResult, "Gt") { }

    protected override int ExecuteBinaryCommand(int left, int right) => Convert.ToInt32(left > right);
}
