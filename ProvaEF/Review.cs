using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEF
{
    [Table("review")]
    internal class Review
    {
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public int StudentId { get; set; }      //"foreign key" (riferimento alla key di studente)
        public Student Student { get; set; }    //ogni recensione è scritta da un solo studente
    }

}
