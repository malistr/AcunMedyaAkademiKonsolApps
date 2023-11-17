using System.Xml.Linq;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*    int toplam = 0;
             //    int sayi = 0;
             //    int sayac = 0;

             //    while (toplam<50)
             //    {
             //        Console.Write("Sayı giriniz");
             //        sayi= int.Parse(Console.ReadLine());
             //        toplam += sayi;
             //        sayac++;
             //    }
             //    Console.WriteLine($"{0} adet sayı girişi yaptınız" +
             //        $"Girilen Sayıların Toplamı {toplam}",sayac,toplam
             //        );
             */

            /*Console.Write("Kaç Adet Sayı Girmek " +
             //    "İstiyorsunuz?: ");

             //int adet = int.Parse(Console.ReadLine());
             //int[] sayilar = new int[adet];

             //int toplam = 0;
             //for (int i = 0; i < adet; i++)
             //{
             //    Console.Write($"Sayi {i+1}: ");
             //    sayilar[i] = int.Parse(Console.ReadLine());
             //    toplam += sayilar[i];
             //}

             //double ortalama = (double)toplam / adet;

             //Console.WriteLine($"Girilen Sayıların Toplamı: " +
             //    $"{toplam}");
             //Console.WriteLine($"Girilen Sayıların Ortalaması: " +
             //    $"{ortalama}");

             //Console.WriteLine("Kaç Adet Sayı Girmek İstiyorsunuz?: ");

             //int adet = int.Parse(Console.ReadLine());

             //int[] sayilar = new int[adet];

             //for (int i = 0; i < adet; i++)
             //{
             //    Console.Write($"Sayı {i+1}: ");
             //    sayilar[i] = int.Parse(Console.ReadLine());


             //}
             //Console.WriteLine("Çift Sayılar: ");
             //foreach (var sayi in sayilar)
             //{
             //    if (sayi %2 == 0)
             //    {
             //        Console.WriteLine(sayi + " ");
             //    }
             //}
             //Console.WriteLine("Tek Sayılar: ");
             //foreach (var sayi in sayilar)
             //{
             //    if (sayi %2 !=0)
             //    {
             //        Console.WriteLine(sayi+" ");
             //    }
               }
             */

            /* Console.WriteLine("Bir Üst Sınır Girin");
             int ustSinir = int.Parse(Console.ReadLine());

             Console.WriteLine($"1 ile {ustSinir} arasındaki asal" +
                 $"sayılar:");

             for (int i = 2; i <= ustSinir; i++)
             {

                 bool asalMi = true;

                 for (int j = 2; j < Math.Sqrt(i); j++)
                 {
                     if (i%j==0)
                     {
                         asalMi = false;
                         break;
                     }
                 }
                 if (asalMi)
                 {
                     Console.WriteLine(i+" ");
                 }

             }
            */

            /*Console.WriteLine("Kaç Adet Sayi Gireeksiniz?: ");
            //int adet = int.Parse(Console.ReadLine()); 
            //int[] sayilar = new int[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine($"Sayi {i+1}: ");
            //    sayilar[i] = int.Parse(Console.ReadLine()); 
            //}
            //int max = sayilar[0];
            //int min = sayilar[0];

            //foreach (var sayi in sayilar)
            //{
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //    else if (sayi < min)
            //    {
            //        min = sayi;
            //    }
            //}

            //Console.WriteLine($"En büyük sayı : {max}");
            //Console.WriteLine($"En büyük sayı : {min}");
            */

            /*int[] sayilar = { 1, 2, 3 };

            //int topla = 0;

            //foreach (int sayi in sayilar)
            //{
            //    topla += sayi;
            //}

            //double ortalama = topla/ sayilar.Length;
            //Console.WriteLine($"Dizi elemanlarının toplamı: {topla}");
            //Console.WriteLine($"Dizi elemanlarının ortalaması: {ortalama}");
            */

            /*
            Console.WriteLine("Faktoriyel hesaplamak ıcın bir sayı girin: ");
            //int sayi =int.Parse(Console.ReadLine());

            //int faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel *= i;
            //}
            //Console.WriteLine($"{sayi} sayısının faktoriyeli : {faktoriyel}");
            */

            /*Console.WriteLine("Bir Cümle Girin: ");

            //string cumle = Console.ReadLine();

            //string[] kelimeler = cumle.Split(' ');

            //Console.WriteLine($"Cümledeki kelime sayısı: {kelimeler.Length}");
            */

            /*

            //Console.WriteLine("Bir kelime girin");

            //string kelime = Console.ReadLine();

            //Console.WriteLine($"\"{kelime}\" kelimesindeki harfler:");

            //foreach (var harf in kelime)
            //{
            //    if (Char.IsLetter(harf))
            //    {
            //        Console.WriteLine(harf);
            //    }
            //}
            */

            /*

            Console.Write("Elmas yüksekliği girin (tek sayı olmalı): ");
            int yukseklik = int.Parse(Console.ReadLine());

            // Üst kısım
            for (int i = 0; i < yukseklik / 2 + 1; i++)
            {
                for (int j = 0; j < yukseklik / 2 - i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            // Alt kısım
            for (int i = yukseklik / 2 - 1; i >= 0; i--)
            {
                for (int j = 0; j < yukseklik / 2 - i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.Write("Üçgen yüksekliği girin: ");
            int yukseklk = int.Parse(Console.ReadLine());

            for (int i = yukseklk; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.Write("Üçgen yüksekliği girin: ");
            int ykskl = int.Parse(Console.ReadLine());

            for (int i = 0; i < ykskl; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            */

            /*
            //Console.Write("Kaç yaş gireceksiiz:");

            //int sayi = int.Parse(Console.ReadLine());

            //int[] yaslar = new int[sayi];

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine($"Yaş {i+1}: ");
            //    yaslar[i]= int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Yaş aralığının alt sınırını girin: ");

            //int altLimit= int.Parse(Console.ReadLine());

            //Console.WriteLine("Yaş aralığının üst limitini girin: ");

            //int ustLimit = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\n{altLimit} ile {ustLimit} yaşları arasındaki kişiler:");

            //foreach (int yas in yaslar)
            //{
            //    if (yas>= altLimit && yas<= ustLimit)
            //    {
            //        Console.WriteLine(yas + " ");
            //    }
            //}

             */

            /*
            //Console.Write("Kaç isim gireceksiniz? ");
            //int isimAdeti = int.Parse(Console.ReadLine());

            //string[] isimler = new string[isimAdeti];

            //for (int i = 0; i < isimAdeti; i++)
            //{
            //    Console.WriteLine($"İsim {i+1}: ");
            //    isimler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Hangi harfleri içeren isimleri" +
            //    "görmek istiyorsunuz?");
            //string harfAra = Console.ReadLine();

            //foreach (var isim in isimler)
            //{
            //    if (isim.Contains(harfAra, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine(isim);
            //    }
            //}
            */

            /*
            //Console.WriteLine("Kaç Not Gireceksiniz?: ");

            //int adet = int.Parse(Console.ReadLine());

            //int[] notlar= new int[adet];

            //int toplam = 0;

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine($"Not {1}: ");
            //    notlar[i]=int.Parse(Console.ReadLine());
            //    toplam += notlar[i];
            //}

            //double ortalama = toplam/ adet;

            //Console.WriteLine($"Notların Ortalaması: {ortalama}");

            //if (ortalama>=50)
            //{
            //    Console.WriteLine("Geçer not aldınız");
            //}
            //else
            //{
            //    Console.WriteLine("Kaldınız");
            //}

            */

            /*
            Console.WriteLine("*Hesap Makinesi*");
            Console.WriteLine("!. sayıyı Giriniz: ");

            double sayi1= double.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");

            double sayi2 = double.Parse(Console.ReadLine());

            Console.WriteLine("İşlemi seçin (+, -, *, /):");

            char islem = char.Parse(Console.ReadLine());

            double sonuc = 0;

            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi2 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçildi.");
                    return;
            }
            Console.WriteLine($"Sonuç: {sonuc}");

            */




            // bir şeyler ekledim
            Console.WriteLine("dbjbsjdf");
            kjfdbasdhsabdashd
        }

    }
}