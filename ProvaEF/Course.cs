using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEF
{

    [Table("course")]
    internal class Course
    {
        [Key]        
        public int CourseId { get; set; }
        public string Name { get; set; }

        public CourseImage CourseImage { get; set; }       //riferimento a all'immagine corrispondente

        public List<Student> StudentsEnrolled { get; set; } //ad ogni corso possono essere iscritti più studenti

    }
}
