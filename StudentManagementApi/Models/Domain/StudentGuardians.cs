namespace StudentManagementApi.Models.Domain
{
    public class StudentGuardians
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FamilyRelationship { get; set; }
        public Guid StudentId { get; set; }

        public Students Student { get; set; }
    }
}
