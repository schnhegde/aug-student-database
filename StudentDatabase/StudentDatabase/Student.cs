using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDatabase
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public int RollNumber { get; set; }

        [Required]
        public int ClassNumber { get; set;}

        [Required]

        public int YearOfEnrollment { get; set; } = 2020;
    }
}
