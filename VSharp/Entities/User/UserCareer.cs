namespace VSharpPlus.Entities.User
{
    public class UserCareer
    {
        public int? GroupId { get; set; }
        public string? CompanyName { get; set; }
        public int CountryId { get; set; }
        public int? CityId { get; set; }
        public string? CityName { get; set; }
        public int FromYear { get; set; }
        public int UntilYear { get; set; }
        public string Position { get; set; }
    }
}