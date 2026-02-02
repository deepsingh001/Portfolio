namespace ManagementSystem.Server.DTOs
{
    public class ContactListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime SubmittedAt { get; set; }
    }
}
