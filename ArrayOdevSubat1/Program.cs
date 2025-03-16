using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[5];


        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"{i + 1}. sayıyı giriniz: ");


            while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
            {
                Console.Write("Geçersiz değer! Lütfen bir sayı giriniz: ");
            }
        }


        Console.WriteLine("\nGirdiğiniz sayılar:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine($"sayilar[{i}] = {sayilar[i]}");
        }
    }
}

// 5 elemanlı bir int dizisi oluşturup, kullanıcıdan değer alan program

//class Buyuk
//{
//    static void Main(string[] args)
//    {
//        // Kullanıcıdan dizi boyutunu al
//        Console.Write("Dizi boyutunu giriniz: ");
//        int boyut;
//        while (!int.TryParse(Console.ReadLine(), out boyut) || boyut <= 0)
//        {
//            Console.Write("Geçersiz boyut! Pozitif bir tam sayı giriniz: ");
//        }

//        // Diziyi oluştur
//        int[] sayilar = new int[boyut];

//        // Diziyi doldur
//        for (int i = 0; i < sayilar.Length; i++)
//        {
//            Console.Write($"{i + 1}. sayıyı giriniz: ");
//            while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
//            {
//                Console.Write("Geçersiz değer! Lütfen bir sayı giriniz: ");
//            }
//        }

//        // En büyük sayıyı bul
//        int enBuyuk = sayilar[0]; // İlk elemanı en büyük kabul et

//        for (int i = 1; i < sayilar.Length; i++)
//        {
//            if (sayilar[i] > enBuyuk)
//            {
//                enBuyuk = sayilar[i];
//            }
//        }

//        // Sonucu yazdır
//        Console.WriteLine($"\nDizideki en büyük sayı: {enBuyuk}");

//        // Diziyi yazdır
//        Console.WriteLine("\nDizinin tüm elemanları:");
//        for (int i = 0; i < sayilar.Length; i++)
//        {
//            Console.WriteLine($"sayilar[{i}] = {sayilar[i]}");
//        }
//    }
//}