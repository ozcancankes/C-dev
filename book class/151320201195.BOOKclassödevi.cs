using System;

class Kitap
{
    public string Kitapismi { get; set; }
    public string[] Kitapyazar { get; set; } 
    public decimal kitapfiyat  { get; set; }
    public int kitapsayfa { get; set; }
    public string Kkategori { get; set; }

    public void Discount(decimal percentage)
    {
        kitapfiyat *= (decimal)(1 - percentage / 100);
        // typecasting için işe yaramıyormuş for c#
    }
}

class Program
{
    static void genelindirim(Kitap[] kitaplar, decimal percentage)
    {
        foreach (Kitap kitap in kitaplar)
        {
            kitap.Discount(percentage);
        }
    }

    static void Main(string[] args)
    {
        Kitap[] kitaplar = new Kitap[5];
        kitaplar[0] = new Kitap()
        {
            Kitapismi = "Dune",
            Kitapyazar = new string[] { "Frank Herbert" },
            kitapfiyat = 389M,
            kitapsayfa = 604,
            Kkategori = "Bilim Kurgu"
        };
        kitaplar[1] = new Kitap()
        {
            Kitapismi = "Dune Meishi",
            Kitapyazar = new string[] { "Frank Herbert" },
            kitapfiyat = 410M,
            kitapsayfa = 688,
            Kkategori = "Bilim Kurgu"
        };
        kitaplar[2] = new Kitap()
        {
            Kitapismi = "Taht Oyunları",
            Kitapyazar = new string[] { "George R. R. Martin" },
            kitapfiyat = 325M,
            kitapsayfa = 704,
            Kkategori = "Fantastik"
        };
        kitaplar[3] = new Kitap()
        {
            Kitapismi = "Kralların Çarpışması I",
            Kitapyazar = new string[] { "George R. R. Martin" },
            kitapfiyat = 325M,
            kitapsayfa = 704,
            Kkategori = "Fantastik"
        };
        kitaplar[4] = new Kitap()
        {
            Kitapismi = "Kralların Çarpışması II",
            Kitapyazar = new string[] { "George R. R. Martin" },
            kitapfiyat = 325M,
            kitapsayfa = 704,
            Kkategori = "Fantastik"
        };
        

        Console.WriteLine("İndirimsiz Fiyatlar:");
       
       //String.Format("{0:C2}") hocam bu kodu şuradan aldım
       //https://stackoverflow.com/questions/21464496/format-decimal-value-to-currency-with-2-decimal-places
        foreach (Kitap kitap in kitaplar)
        {
            Console.WriteLine(kitap.Kitapismi + ": " + String.Format("{0:C2}",kitap.kitapfiyat));
        }
        Console.WriteLine("\n Kralların Çarpışması serisine %25 indirimden sonra:");
        kitaplar[3].Discount(25);
        kitaplar[4].Discount(25);
        foreach (Kitap kitap in kitaplar)
        {
            Console.WriteLine(kitap.Kitapismi + ": " + String.Format("{0:C2}",kitap.kitapfiyat));
        }
        genelindirim(kitaplar, 10M);

        Console.WriteLine("\n 10% indrimden sonraki fiyatlar:");
        foreach (Kitap kitap in kitaplar)
        {
            Console.WriteLine(kitap.Kitapismi + ": " + String.Format("{0:C2}",kitap.kitapfiyat));
        }
        Console.ReadLine(); // cmd kapanmasın diye 
    }
}
