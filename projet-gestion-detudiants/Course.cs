using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gestion_detudiants
{
    internal class Course
    {

        public int NumeroDeCours { get; set; }
        public string Code { get; set; }
        public string Titre { get; set; }
        public Course(int CourseNumber, string Code, string Title)
        {
            this.NumeroDeCours = CourseNumber;
            this.Code = Code;
            this.Titre = Title;
        }
    }
}
