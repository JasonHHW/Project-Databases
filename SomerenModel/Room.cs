namespace SomerenModel
{
    public class Kamer
    {
        public string KamerCode { get; set; }         // database id
        public string Gebouw { get; set; }     // RoomNumber, e.g. 206
        public int Verdieping { get; set; }   // number of beds, either 4, 6, 8, 12 or 16
        public bool IsEenPersoons { get; set; }      // student = false, teacher = true

        public Kamer(string kamerCode, string gebouw, int verdieping, bool isEenPersoons)
        {
            KamerCode = kamerCode;
            Gebouw = gebouw;
            Verdieping = verdieping;
            IsEenPersoons = isEenPersoons;
        }
    }
}