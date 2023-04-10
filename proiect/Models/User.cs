using System;
using System.ComponentModel.DataAnnotations;

namespace proiect.Models
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string TwoFactorKey { get; set; }
        [Required]
        public string Salt { get; set; }
        public DateTime? TwoFactorCreatedOn { get; set; }
    }
}
