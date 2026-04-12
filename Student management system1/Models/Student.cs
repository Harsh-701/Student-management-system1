using System.ComponentModel.DataAnnotations;

namespace Student_management_system1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public String Course { get; set; } = ""; 
        public int Age { get; set; }
        

        
    }
}
