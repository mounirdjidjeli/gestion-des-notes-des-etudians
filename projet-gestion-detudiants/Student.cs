using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gestion_detudiants
{
    public class Student

    { 
        public int NumeroDetudiant { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Student(int NumeroDetudiant, string Nom, string Prenom)
    {

        this.NumeroDetudiant = NumeroDetudiant;
        this.Nom = Nom;
        this.Prenom = Prenom;

    }
}
}
