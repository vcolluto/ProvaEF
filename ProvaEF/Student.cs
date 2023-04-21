using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEF
{

    [Table("student")]
    [Index(nameof(Email), IsUnique = true)]
    internal class Student
    {
        [Key]
          
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        [Column("student_email")]
        public string Email { get; set; }

        public string? Phone { get; set; }

        public List<Review> Reviews { get; set; }       //ogni studente può aver scritto più recensioni

        public List<Course> FrequentedCourses { get; set; } //ogni studente può frequentare più corsi
    }
}
