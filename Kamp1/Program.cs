namespace Kamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // Kategori etiketi bir değer tutucudur - alias
            //Solution - Çözüm
            // lenght - uzunluk


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);




        }
    }
}
