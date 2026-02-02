using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Server.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }   
        public string Message { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime SubmittedAt { get; set; }
        public DateTime? deletedAt { get; set; }
        public DateTime? updateAt { get; set; }
    }
}
