using System.ComponentModel.DataAnnotations;

namespace StudentCRUD.Web.Models
{
    public class Student
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
