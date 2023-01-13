namespace Methodlar
{
    internal class Program
    {
        //public static void yazdir()
        //{
        //    Console.Write("Bu bir metottur.");
        //    Console.WriteLine();
        //    Console.Write("Burası metodun bir başka satırdır.");
        //    Console.WriteLine();
        //}
        //public static void toplamametodu()
        //{
        //    int sayi1 = 24, sayi2 = 30;
        //    int toplam = sayi1 + sayi2;
        //    Console.Write(toplam);
        //}
        //public static void yazıbosluk()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("***********");
        //    Console.WriteLine();

        //}
        //public static void ardisiksayilar()
        //{
        //    for(int i=1; i<=10; i++)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        public static void MetinYaz(string p)
        {
            Console.Write("*********");
            Console.WriteLine();
            Console.Write(p);
            Console.WriteLine();
            Console.Write("*********");
            Console.WriteLine();
        }
        public static void MetinYaz2(string parametre)
        {
            Console.Write("----------");
            Console.WriteLine();
            Console.Write(parametre);
            Console.WriteLine();
            Console.Write("----------");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //yazdir();
            ////Console.WriteLine("********");
            ////Console.WriteLine();
            //yazıbosluk();
            //yazdir();
            ////Console.WriteLine("*********");
            //yazıbosluk();
            //toplamametodu();
            //yazıbosluk();
            //ardisiksayilar();

            //void metotlarda parametre kullanımı
            Console.Write("Kelimeyi giriniz.");
            string kelime = Console.ReadLine();

            MetinYaz("Merhaba");            
            MetinYaz2(kelime);

            Console.Read();
        }
    }
}