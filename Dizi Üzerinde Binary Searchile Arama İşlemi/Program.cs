using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 4, 8, 3, 84, 47, 76, 9, 24, 68 };//boyle bir dizimiz oldugunu var sayalım
        int aranan;//aranan adli degiskenimizi tanimladik
        Console.WriteLine("Dizimizdeki elemanlar sırasıyla:");
        Console.WriteLine("{ 4, 8, 3, 84, 47, 76, 9, 24, 68 }");
        Console.WriteLine("Aranan elemanin degerini giriniz:");
        aranan = Convert.ToInt32(Console.ReadLine());

        Array.Sort(dizi); // Sort ifadesi diziyi kucukden buyuge dogru sıralanır

        int baslangic = 0;
        int bitis = dizi.Length - 1;//Lengt ifadesiyle birlikte dizinin uzunlugu belli olur
        int orta;

        while (baslangic <= bitis)//donguyle kosullu saglıyoruz
        {
            orta = (baslangic + bitis) / 2;
            if (dizi[orta] == aranan)//aranana esitse durum gerceklesır
            {
                Console.WriteLine($"Aranan eleman dizinin {orta}. indeksinde bulundu.");
                return;//return ifadesiyle dongu durdurulur
            }
            else if (dizi[orta] < aranan)//aranandan kucukse durum
            {
                baslangic = orta + 1;
            }
            else//diger durumlarda
            {
                bitis = orta - 1;
            }
        }
        Console.WriteLine("Aranan eleman dizide bulunamadı.");
    }
}
