using System;

namespace SomerenModel
{
    public class Kamer
    {     
        public string Gebouw { get; set; } 
        public int Verdieping { get; set; }   
        public bool IsEenPersoons { get; set; }
        public string Type
        {
            get
            {
                if (IsEenPersoons)
                { return "Docent"; }
                else
                {
                    return "Student";
                }
            }
        }
        public int Slaapplekken
        {
            get
            {
                if (IsEenPersoons)
                {
                    return 1;
                } else
                {
                    return 8;
                }
            }
        }

        public string RoomCode
        {
            get { return RoomCode; }
            set
            {
                string roomcode = "";
                char[] kamercode = (value.ToCharArray());
                for (int i = 1; i < kamercode.Length; i++)
                {
                    roomcode+= kamercode[i];
                }
                this.RoomCode = roomcode;
            }
        }
    }
}