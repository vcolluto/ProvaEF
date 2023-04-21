using Microsoft.EntityFrameworkCore;

namespace ProvaEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext db = new SchoolContext())
            {
                //// Create
                //Student nuovoStudente = new Student { Name = "Mario", Email = "Mario@gmail.com" };
                //db.Students.Add(nuovoStudente);
                //db.SaveChanges();       // rendo permanenti le modifiche
                //Console.WriteLine("Studente aggiunto correttamente");

                ////Update
                //nuovoStudente.Surname = "Rossi";
                //db.SaveChanges();
                //Console.WriteLine("Studente modificato correttamente");


                Student studenteFrancesco = db.Students.Where(student => student.Name == "Francesco").Include(m => m.Reviews).First();
                Console.WriteLine($"Recensioni di {studenteFrancesco.Name}: ");

                foreach (Review review in studenteFrancesco.Reviews)
                    Console.WriteLine(review.Title);

                //studenteFrancesco.Reviews.Add(new Review { Text="Prova", Title="Recensione1"}) ;
                //db.SaveChanges();
                //Console.WriteLine("Studente modificato correttamente");

                // Read
                Console.WriteLine("Recupero lista di Studenti");
                List<Student> students = db.Students.OrderBy(student => student.Name).ToList<Student>();
                foreach (Student student in students) { 
                    Console.WriteLine(student.Name);
                }

            }
        }
    }
}