using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();
        string cevap;

        do
        {
            Console.WriteLine("Araba üretmek istiyor musunuz? (e/h)");
            cevap = Console.ReadLine().ToLower(); // Büyük-küçük harf duyarlılığını kaldırdık

            if (cevap == "h")
            {
                break; // Kullanıcı hayır dedi, programı sonlandırıyoruz.
            }
            else if (cevap == "e")
            {
                Araba yeniAraba = new Araba();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine();

            KapiSayisiGir:
                Console.Write("Kapı Sayısı: ");
                try
                {
                    yeniAraba.KapiSayisi = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş! Kapı sayısı için sayısal bir değer giriniz.");
                    goto KapiSayisiGir; // Hatalı girişte tekrar kapı sayısını sormak için geri yönlendiriyoruz.
                }

                arabalar.Add(yeniAraba); // Arabayı listeye ekledik.

                Console.WriteLine("Başka araba üretmek istiyor musunuz? (e/h)");
                cevap = Console.ReadLine().ToLower();
            }
            else
            {
                Console.WriteLine("Geçersiz cevap! Lütfen sadece e veya h giriniz.");
            }

        } while (cevap != "h");

        // Tüm arabaların seri numaralarını ve markalarını yazdırıyoruz.
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }

        Console.WriteLine("Program sona erdi.");
    }
}
