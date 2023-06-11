using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class Angajat
    {
        public string Nume { get; set; }
        public string Departament { get; set; }
        public List<string> Raspunsuri { get; set; }
        public string Rezultate { get; set; }

        public Angajat(string nume, string departament)
        {
            Nume = nume;
            Departament = departament;
            Raspunsuri = new List<string>();
            Rezultate = "";
        }
    }
}
