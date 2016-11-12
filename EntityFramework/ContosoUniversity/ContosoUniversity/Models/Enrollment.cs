// ROGER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        // a interrogação significa que a GRADE pode ser nula.
        public Grade? Grade { get; set; }

        // aqui não usamos collection porque uma matricula só pertence a um estudante
        // o mesmo vale para o curso.
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}