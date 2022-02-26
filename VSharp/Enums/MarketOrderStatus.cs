namespace VSharpPlus.Enums
{
    public enum MarketOrderStatus : byte
    {
        New = 0,
        //TODO: Use a better word for Согласуется
        Confirming = 1,
        Assembling = 2,
        Delivering = 3,
        Finished = 4,
        Cancelled = 5,
        Returned = 6
    }
}