using System.ComponentModel.DataAnnotations;

namespace SchoolManagement1.Models
{
    public class Teachers
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Hobbies { get; set; }
      
    }
}

