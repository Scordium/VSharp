namespace VSharp.Entities.User
{
    public class UserUniversity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public int ChairId { get; set; }
        public string ChairName { get; set; }
        public int GraduatedYear { get; set; }
        public string EducationForm { get; set; }
        public string EducationStatus { get; set; }
    }
}