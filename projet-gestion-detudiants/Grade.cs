using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gestion_detudiants
{
    internal class Grade
    {
        public int NumeroDetudiant { get; set; }
        public int NumeroDeCours { get; set; }
        public float Note { get; set; }

        public Grade(int studentNumber, int courseNumber, float note)
        {
            NumeroDetudiant = studentNumber;
            NumeroDeCours = courseNumber;
            Note = note;
        }
    }
}
