namespace StudentManagementApi.Models.Domain
{
    public class Students
    {
        public Guid Id { get; set; }
        public string NIS { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ProfilImageUrl { get; set; }
    }
}
