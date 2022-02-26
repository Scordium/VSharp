using VSharpPlus.Enums;

namespace VSharpPlus.Entities.User
{
    public class UserSchool
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public int FromYear { get; set; }
        public int UntilYear { get; set; }
        public int GraduatedYear { get; set; }
        public string ClassLetter { get; set; }
        public string Speciality { get; set; }
        public SchoolType Type { get; set; }

    }
}