using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    class Student   
    {
        string nume;
        string prenume;
        string materie;
        float nota;
        string promovat;
        public Student()
        {
            nume = string.Empty;
            prenume = string.Empty;
            materie = string.Empty;
            nota = 0;
            promovat = string.Empty;

        }
        public Student(string _nume, string _prenume, string _materie, float _nota)
        {
            nume = _nume;
            prenume = _prenume;
            materie = _materie;
            nota = _nota;
            if (nota >= 5)
                promovat = "Da";
            else
                promovat = "Nu";
        }
        public string info()
        {
            return string.Format("Nume: {0}\nPrenume: {1}\nMaterie: {2}\nNota: {3}\nPromovat: {4}\n", nume, prenume, materie, nota, promovat);
        }
    }
}
