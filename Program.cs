using System;

namespace _3.Hafta_alistirma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayiyi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 0;
            for (int i=1; i<=200; i++)
            {
                if (i%sayi == 0)
                {
                    sonuc++;
                }
                
            }
            Console.WriteLine("1-200 arasinda {0} sayinin bolunenlerinin sayisi {1}",sayi,sonuc);
         }
    }
}
