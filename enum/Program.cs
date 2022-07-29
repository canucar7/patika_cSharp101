﻿    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);


            int sıcaklık =32;

            if (sıcaklık<=(int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için biraz daha bekleyin. ");

            else if(sıcaklık>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün. ");

            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
                Console.WriteLine("Güzel bir gün dışarıya çıkalım. "); 

            
            


            
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=36,
        Cumartesi,
        Pazar 
    }

    enum HavaDurumu
    {
        Soguk =5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30
    }