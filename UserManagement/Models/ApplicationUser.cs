using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        public byte[]? ProfilePicture { get; set; }
    }
}
