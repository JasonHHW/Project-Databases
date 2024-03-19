using System;

namespace SomerenModel
{
    public class Docent
    {
        public int DocentId { get; set; }     // database id
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Telefoonnummer { get; set; } // LecturerNumber, e.g. 47198
        public DateTime Geboortedatum { get; set; }
        public string Kamer {  get; set; }

        public Docent(int docentid, string voornaam, string achternaam, string telefoonnummer, DateTime geboortedatum, string kamer)
        {
            DocentId = docentid;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Telefoonnummer = telefoonnummer;
            Geboortedatum = geboortedatum;
            Kamer = kamer;
        }
     }
}