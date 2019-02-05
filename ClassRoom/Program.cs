using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
           KlasseRum klasseRum = new KlasseRum(); // skaber nyt Klasse Objekt
            klasseRum.KlasseNavn = "3B"; // navngiver klassen
            klasseRum.SemesterStart = new DateTime(2018,09,04); //sætter en start dato
            Studerende student1 = new Studerende("Martin", 06, 13);
            Studerende student2 = new Studerende("Alex", 08, 30);
            Studerende student3 = new Studerende("Dennis", 07, 26);
            Studerende student4 = new Studerende("Luca", 09, 28);
            Studerende student5 = new Studerende("Louise", 05, 04);
            //skaber nogle studerende objekter

            klasseRum.Klasseliste.Add(student1);
            klasseRum.Klasseliste.Add(student2);
            klasseRum.Klasseliste.Add(student3);
            klasseRum.Klasseliste.Add(student4);
            klasseRum.Klasseliste.Add(student5);
            //tilføjer til klasse listen

            foreach (var item in klasseRum.Klasseliste)
            {
                Console.WriteLine($"Denne student {item.Navn} og går i {klasseRum.KlasseNavn} deres semester startede {klasseRum.SemesterStart}");

                Console.WriteLine($"{item.Navn} er født {item.Bday}/{item.Birth}");
            }
            //udskriver diverse info

            Console.WriteLine(student1.årstid());
            

            // kalder på metoden fra opgave 6.
            Count("Sommer", klasseRum);
            Count("Vinter", klasseRum);
            Count("Efterår", klasseRum);
            Count("Forår", klasseRum);


            Console.ReadLine();
        }


        // Laver metoden opgave 6.
        static void Count(string type, KlasseRum KlasseRum)
        {
            int count = 0;
            if (type == "Vinter")
            {
                count = KlasseRum.Klasseliste.Where(x => x.Birth == 12 || x.Birth == 1 || x.Birth == 2).Count();
                
            }
            else if (type == "Forår")
            {
                count = KlasseRum.Klasseliste.Where(x => x.Birth == 3 || x.Birth == 5 || x.Birth == 4).Count();
            }
            else if (type == "Sommer")
            {
                count = KlasseRum.Klasseliste.Where(x => x.Birth == 6 || x.Birth == 7 || x.Birth == 8).Count();
            }
            else if (type == "Efterår")
            {
                count = KlasseRum.Klasseliste.Where(x => x.Birth == 9 || x.Birth == 10 || x.Birth == 11).Count();
            }
            Console.WriteLine($"Så mange {count} har fødseldag i {type} perioden ");
        }
    }
}
