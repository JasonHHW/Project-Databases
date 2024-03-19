using System;

namespace SomerenModel
{
    public class Student
    {
        public int StudentId { get; set; }     // database id
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Telefoonnummer { get; set; } // StudentNumber, e.g. 474791
        public string Klas {  get; set; }
        public string Kamer { get; set; }

        public Student(int studentId, string voornaam, string achternaam, string telefoonnummer, string klas, string kamer)
        {
            StudentId = studentId;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Telefoonnummer = telefoonnummer;
            Klas = klas;
            Kamer = kamer;
        }
    }
}