namespace VSharpPlus.Entities.User
{
    public class UserMilitary
    {
        public string Unit { get; set; }
        public int UnitId { get; set; }
        public int CountryId { get; set; }
        public int FromYear { get; set; }
        public int UntilYear { get; set; }
    }
}