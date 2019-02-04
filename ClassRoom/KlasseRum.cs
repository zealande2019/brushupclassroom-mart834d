using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string KlasseNavn { get; set; }

        public List<Studerende> Klasseliste { get; } = new List<Studerende>();
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
                
        }
        // vi bruger bare denne her til chat i stedet
        //rgr
        //du flyver bare

    }
}