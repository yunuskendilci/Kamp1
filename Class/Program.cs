namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "c#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Engin Demiroğ";
            kurs2.izlenmeOrani = 13;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "c# v2";
            kurs3.egitmen = "Engin Demiroğ";
            kurs3.izlenmeOrani = 95;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.egitmen + ":" + kurs.izlenmeOrani); 
            }

        }
    }


    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }


    }
}
