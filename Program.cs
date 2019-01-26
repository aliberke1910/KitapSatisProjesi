using System;

namespace Proje_Denemesi_5
{
    class Program
    {
        static void Main(string[] args)
        {
            SatisYoneticisi yoneticisi = new SatisYoneticisi();
            Musteri musteri = new Musteri();
            Kasa kasa = new Kasa();
            musteri.Kitaplar();
            musteri.Stok();
            yoneticisi.Stok();

            musteri.Fiyat();
            yoneticisi.Fiyat();
            musteri.Add();
            yoneticisi.Add();
            kasa.Kayit();
            Console.ReadLine();
        }
    }

    interface IKitapevi
    {
        void Kitaplar();
    }

    interface IFiyat
    {
        void Fiyat();
    }

    interface IStok
    {
        void Stok();
    }
    interface IKayit
    {
        void Kayit();
    }

    class Musteri : IKitapevi, IFiyat
    {

        public void Kitaplar()
        {
            Console.WriteLine("Musteri: Merhaba, ben matematik, fizik, biyoloji kitaplari bakacaktim.");
            Console.ReadLine();
        }


        public void Stok()
        {
            Console.WriteLine("Musteri: Stogunuzda hangileri var?");
            Console.ReadLine();
        }

        public void Fiyat()
        {
            Console.WriteLine("Musteri: Matematik ve fizik kitabinin fiyati ne kadar?");
            Console.ReadLine();

        }

        public void Add()
        {
            Console.WriteLine("Musteri: Ben matematik kitabini satin almak istiyorum.");
            Console.ReadLine();
        }

    }

    class SatisYoneticisi : IStok, IFiyat
    {
        public void Fiyat()
        {
            int MatKitabi = 20;
            int FizikKitabi = 18;
            Console.WriteLine("Satis Yonetici: Matematik kitabinin fiyati {0} TL, Fizik kitabinin ise {1} TL'dir.", MatKitabi, FizikKitabi);
            Console.ReadLine();
        }

        public void Stok()
        {

            bool MatKitabiStogu = true;
            {
                Console.WriteLine("Satis Yonetici: Stogumuzda matematik kitabi = {0}", MatKitabiStogu);
                Console.ReadLine();
            }

            bool FizikKitabiStogu = true;
            {
                Console.WriteLine("Satis Yonetici: Stogumuzda fizik kitabi = {0}", FizikKitabiStogu);
                Console.ReadLine();
            }

            bool BioKitabiStogu = false;
            {
                Console.WriteLine("Satis Yonetici: Stogumuzda biyoloji kitabi = {0}", BioKitabiStogu);
                Console.ReadLine();
            }
        }

        public void Add()
        {
            Console.WriteLine("Musteri: Tabiki, buyrun kasaya gecelim.");
            Console.ReadLine();
        }

    }

    class Kasa : IKayit
    {
        public void Kayit()
        {
            {
                Console.WriteLine("Kasa: Matematik kitabi satildi.");
            }
        }
    }
}
