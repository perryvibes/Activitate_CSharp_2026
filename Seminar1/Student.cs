using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class Student
    {
        private string nume { get; set; }
        private string grupa { get; set; }
        private double? notaExamen { get; set; }
        private double? notaLaborator { get; set; }

        public double? Medie
        {
            get => notaExamen != null && notaLaborator != null ? (notaExamen + notaLaborator) / 2 : null;
        }
        public Student(string _nume, string _grupa, double? _notaExamen, double? _notaLaborator)
        {
            nume = _nume;
            grupa = _grupa;
            notaExamen = _notaExamen ?? 0;
            notaLaborator = _notaLaborator ?? 0;
        }
        public string Afiseaza() => $"Nume: {nume}\nGrupa: {grupa}\nNota Examen: {notaExamen:F2}\nNota Laborator: {notaLaborator:F2}\nMedie: {Medie:F2}";

    }
}
