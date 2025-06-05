using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCoffeeShop.Table
{
    public enum Role{
        Admin,
        User
    }
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public Role role { get; set; } = Role.User;
        public DateTime Log { get; set; } = DateTime.Now;
        public UserProfile Profile { get; set; }
    }
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; } 

        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        // Navigation property
        public User User { get; set; }
    }

}
