using System;
using System.Net;
using System.Security.Permissions;

namespace ClassRoom
{
    public class Studerende
    {
        public string Navn { get; set; }

        public int Birth { get; }
        public int Bday { get; set; }
        public Studerende(string navn, int birth, int bday)
        {
            Navn = navn;
            Birth = birth;
            Bday = bday;

            // opgave 7 mit bud på. Ikke komplet færdig...
            if (Birth > 13  || Birth < 0)
            {
                throw ArgumentException;
            }
        }

        // opgave 5
        public string årstid()
        {
            if (Birth == 12 || Birth == 1 || Birth == 2)
            {
                return "Vinter";
            }

            if (Birth == 3 || Birth == 4 || Birth == 5)
            {
                return "Forår";
            }

            if (Birth == 6 || Birth == 7 || Birth == 8)
            {
                return "Sommer";
            }
            if (Birth == 9 || Birth == 10 || Birth == 11)
            {
                return "Efterår";
            }
            return null;
        }
        
    }
}