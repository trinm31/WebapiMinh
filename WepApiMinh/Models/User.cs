using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WepApiMinh.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
    
    public enum Role
    {
        Admin, 
        User
    }
}